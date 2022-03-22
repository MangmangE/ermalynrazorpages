#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ermalynrazorpages.christian_songs;

namespace ermalynrazorpages.Data
{
    public class ermalynrazorpagesContext : DbContext
    {
        public ermalynrazorpagesContext (DbContextOptions<ermalynrazorpagesContext> options)
            : base(options)
        {
        }

        public DbSet<ermalynrazorpages.christian_songs.christiansongs> christiansongs { get; set; }
    }
}
