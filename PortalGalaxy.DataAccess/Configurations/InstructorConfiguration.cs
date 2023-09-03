

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalGalaxy.Entities;

namespace PortalGalaxy.DataAccess.Configurations
{
    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.Property(p => p.Nombres).HasMaxLength(200);

            builder.Property(p=>p.NroDocumento)
                .IsUnicode(false)
                .HasMaxLength(11);
        }
    }
}
