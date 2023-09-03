using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace PortalGalaxy.DataAccess
{
    public class PortalGalaxyDbContext : DbContext
    {
        public PortalGalaxyDbContext(DbContextOptions<PortalGalaxyDbContext> options)
            :base(options) 
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //se va agregar la configuracion de las entidades desde este mismo ensamblado
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}