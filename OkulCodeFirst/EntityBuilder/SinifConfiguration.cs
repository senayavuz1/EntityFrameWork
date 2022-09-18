using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OkulCodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulCodeFirst.EntityBuilder
{
    public class SinifConfiguration : IEntityTypeConfiguration<Sinif>
    {
        public void Configure(EntityTypeBuilder<Sinif> builder)
        {
            builder.HasData(
                new Sinif { SinifAdi = "10A", Kapasite = 40, Id = 10 },
                new Sinif { SinifAdi = "10B", Kapasite = 40, Id = 11 },
                new Sinif { SinifAdi = "10C", Kapasite = 40, Id = 12 },
                new Sinif { SinifAdi = "11A", Kapasite = 40, Id = 13 },
                new Sinif { SinifAdi = "11B", Kapasite = 40, Id = 14 },
                new Sinif { SinifAdi = "12C", Kapasite = 40, Id = 15 });
            builder.Property(x => x.SinifAdi).HasMaxLength(50);
            builder.HasIndex(x => x.SinifAdi).IsUnique();
            
        }
    }
}
