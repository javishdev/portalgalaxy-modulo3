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
    public class AlumnoConfiguration : IEntityTypeConfiguration<Alumno>
    {
        public void Configure(EntityTypeBuilder<Alumno> builder)
        {
            builder.Property(p => p.NroDocumento).HasMaxLength(20);

            builder.Property(p => p.NombreCompleto).HasMaxLength(200);

            builder.Property(p=>p.Correo).HasMaxLength(200);
            builder.Property(p=>p.Telefono).HasMaxLength(20);
            builder.Property(p=>p.Departamento).HasMaxLength(5);
            builder.Property(p=>p.Provincia).HasMaxLength(5);
            builder.Property(p=>p.Distrito).HasMaxLength(5);
        }
    }
}
