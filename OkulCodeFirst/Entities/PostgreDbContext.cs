using Microsoft.EntityFrameworkCore;
using OkulCodeFirst.EntityBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulCodeFirst.Entities
{
    public class PostgreDbContext:DbContext
    {
        public DbSet<Sehir> Sehirler { get; set; }
        public DbSet<Ilce> Ilceler { get; set; }

        public DbSet<Adres> Adresler { get; set; }
        public DbSet<Sinif> Siniflar { get; set; }
        public DbSet<Alan> Alanlar { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Server=127.0.0.1;Database=OkulDb;User Id=postgres;Password=qweasd");
            //@"Server=(localdb)\mssqllocaldb;Database=OkulDb;Trusted_Connection=true"
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Alan>().HasIndex(p=>p.AlanAdi).IsUnique();
            modelBuilder.Entity<Alan>().HasData(
                new Alan { AlanAdi = "Sayisal", CreateDate = DateTime.Now ,Id=10},
                new Alan { AlanAdi = "Sözel", CreateDate = DateTime.Now, Id = 11 },
                new Alan { AlanAdi = "Dil", CreateDate = DateTime.Now, Id = 12 },
                new Alan { AlanAdi = "Eşit Ağirlik", CreateDate = DateTime.Now, Id = 13 });
            
            //Burasi modelimizin 
            modelBuilder.ApplyConfiguration(new SinifConfiguration());

            modelBuilder.Entity<Ogrenci>()
                .HasKey(p => new { p.Adi,p.Soyadi,p.Id});
            //base.OnModelCreating(modelBuilder);
        }

    }
}
