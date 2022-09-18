using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SinemaEntity.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinemaConfiguration.Configurations
{
    public class FilmConfiguration : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder)
        {
            builder.Property(p=>p.FilmAdi)
                .IsRequired()
                .HasMaxLength(50);
            
            builder.Property(p => p.Akilama).HasMaxLength(500);

            
        }
    }
}
