using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SinemaEntity.Entites;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SinemaConfiguration.Configurations
{
    public class GosterimConfiguration : IEntityTypeConfiguration<Gosterim>
    {
        public void Configure(EntityTypeBuilder<Gosterim> builder)
        {
            builder.HasKey(p => new { p.SalonId, p.FilmId, p.WeekId });
        }
    }
}
