using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalGalaxy.Entities
{
    public class EntityBase
    {
        public int Id { get; set; }

        public bool Estado { get; set; }

        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        protected EntityBase()
        {
            Estado = true;
            FechaCreacion = DateTime.Now;
        }
    }
}
