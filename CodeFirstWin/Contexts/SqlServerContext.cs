using CodeFirstWin.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWin.Contexts
{
    public class SqlServerContext:DbContext
    {
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Stok> Stoklar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\mssqllocaldb;Database=Market;Trusted_Connection=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Stok>()
                .Property(p => p.StokAdi)
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnName("StokAdi");

            modelBuilder.Entity<Stok>()
                .Property(p => p.Aciklama)
                .HasMaxLength(100);

            modelBuilder.Entity<Kategori>()
                .Property(p => p.KategoriAdi)
                .HasColumnName("KatAdi");


        }
    }
}
