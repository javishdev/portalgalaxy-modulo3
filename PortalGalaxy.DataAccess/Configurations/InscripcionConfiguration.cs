using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalGalaxy.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalGalaxy.DataAccess.Configurations
{
    public class InscripcionConfiguration : IEntityTypeConfiguration<Inscripcion>
    {
        public void Configure(EntityTypeBuilder<Inscripcion> builder)
        {
            builder.Property(p=>p.situacion).HasColumnType("smallint");
        }
    }
}
