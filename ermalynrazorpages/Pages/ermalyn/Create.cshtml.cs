#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ermalynrazorpages.Data;
using ermalynrazorpages.christian_songs;

namespace ermalynrazorpages.Pages.ermalyn
{
    public class CreateModel : PageModel
    {
        private readonly ermalynrazorpages.Data.ermalynrazorpagesContext _context;

        public CreateModel(ermalynrazorpages.Data.ermalynrazorpagesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public christiansongs christiansongs { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.christiansongs.Add(christiansongs);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
