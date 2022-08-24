using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeProgram.Models.EntityFramework
{
    public class DbCafe : DbContext
    {
        public DbSet<Yiyecek> yiyecekler { get; set; }
        public DbSet<Icecek> icecekler { get; set; }
        public DbSet<Tatlı> tatlilar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-4K3804N; database=Cafe; integrated security=true;");
        }

        public class Yiyecek
        {
            public int yiyecekId { get; set; }
            public string yiyecekName { get; set; }
            public float yiyecekValue { get; set; }

        }
        public class Icecek
        {
            public int icecekId { get; set; }
            public string icecekName { get; set; }
            public float icecekValue { get; set; }

        }
        public class Tatlı
        {
            public int tatlıId { get; set; }
            public string tatlıName { get; set; }
            public float tatlıValue { get; set; }

        }

    }
}
