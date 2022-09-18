using Microsoft.EntityFrameworkCore;
using SinemaEntity.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SinemaConfiguration.Contexts
{
    public class PostgreDbContext:DbContext
    {
        //public DbSet<Categori> Kategoriler { get; set; }
        //public DbSet<Film> Filmler { get; set; }
        //public DbSet<Gosterim> Gosterim { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=127.0.0.1;Database=Sinema;User Id=postgres;password=qweasd");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            
                
        
        }

    }
}
