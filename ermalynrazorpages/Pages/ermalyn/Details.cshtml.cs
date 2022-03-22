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
    public class DetailsModel : PageModel
    {
        private readonly ermalynrazorpages.Data.ermalynrazorpagesContext _context;

        public DetailsModel(ermalynrazorpages.Data.ermalynrazorpagesContext context)
        {
            _context = context;
        }

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
    }
}
