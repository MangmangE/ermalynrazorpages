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
    public class IndexModel : PageModel
    {
        private readonly ermalynrazorpages.Data.ermalynrazorpagesContext _context;

        public IndexModel(ermalynrazorpages.Data.ermalynrazorpagesContext context)
        {
            _context = context;
        }

        public IList<christiansongs> christiansongs { get;set; }

        public async Task OnGetAsync()
        {
            christiansongs = await _context.christiansongs.ToListAsync();
        }
    }
}
