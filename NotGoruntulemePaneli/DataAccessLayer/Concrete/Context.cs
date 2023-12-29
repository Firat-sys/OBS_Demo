using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
   public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-A7U7GT0\\SQLEXPRESS; database=DersNotlariDB;integrated security=true;");
        }
        public DbSet<MeslekiInglizce> MeslekiInglizces { get; set; }
        public DbSet<OgretimUyesi> OgretimUyesis { get; set; }
        public DbSet<SayisalAnaliz> SayisalAnalizs { get; set; }
        public DbSet<VeriTabaniYsSis> VeriTabaniYsSiss { get; set; }
        public DbSet<ProgramlamaDilleri> ProgramlamaDilleris { get; set; }
        public DbSet<VeriYapilari> VeriYapilaris { get; set; }
    }
}
