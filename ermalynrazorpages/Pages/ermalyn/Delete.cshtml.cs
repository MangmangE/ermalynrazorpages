#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ermalynrazorpages.Data;
using ermalynrazorpages.christian_songs;

namespace ermalynrazorpages.Pages.ermalyn
{
    public class DeleteModel : PageModel
    {
        private readonly ermalynrazorpages.Data.ermalynrazorpagesContext _context;

        public DeleteModel(ermalynrazorpages.Data.ermalynrazorpagesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public christiansongs christiansongs { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            christiansongs = await _context.christiansongs.FirstOrDefaultAsync(m => m.ID == id);

            if (christiansongs == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            christiansongs = await _context.christiansongs.FindAsync(id);

            if (christiansongs != null)
            {
                _context.christiansongs.Remove(christiansongs);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
