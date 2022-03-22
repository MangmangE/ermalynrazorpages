#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ermalynrazorpages.Data;
using ermalynrazorpages.christian_songs;

namespace ermalynrazorpages.Pages.ermalyn
{
    public class EditModel : PageModel
    {
        private readonly ermalynrazorpages.Data.ermalynrazorpagesContext _context;

        public EditModel(ermalynrazorpages.Data.ermalynrazorpagesContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(christiansongs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!christiansongsExists(christiansongs.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool christiansongsExists(int id)
        {
            return _context.christiansongs.Any(e => e.ID == id);
        }
    }
}
