

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalGalaxy.Entities;

namespace PortalGalaxy.DataAccess.Configurations
{
    internal class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.Property(p => p.Nombre).HasMaxLength(50);

            var fecha = DateTime.Parse("2023-08-01");

            //Data Seeding
            builder.HasData(new List<Categoria>
            {
                new(){Id=1,Nombre=".NET",FechaCreacion = fecha},
                new(){Id=2,Nombre="Java",FechaCreacion = fecha},
                new(){Id=3,Nombre="AWS",FechaCreacion = fecha},
                new(){Id=4,Nombre="Azure",FechaCreacion = fecha},
                new(){Id=5,Nombre="Python",FechaCreacion = fecha},
            });
        }
    }
}
