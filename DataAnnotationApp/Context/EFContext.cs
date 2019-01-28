using DataAnnotationApp.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAnnotationApp.Context
{
    public class EFContext:DbContext
    {
        public EFContext():base("Data Source=.;Initial Catalog=AdoDeneme;Integrated Security=True")
        {
            if(!Database.Exists())
            Database.Create();
        }

        public DbSet<Firma> Firmalar { get; set; }

        public DbSet<Kisiler> Kisiler { get; set; }

        public DbSet<Adresler> Adresler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Citys>().ToTable("City")
                .HasKey<int>(I => I.CityId);

            modelBuilder.Entity<Citys>().Property(I => I.CityName)
                .IsRequired().
                HasMaxLength(50);
              
        }
    }
}
