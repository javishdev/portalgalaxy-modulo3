using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalGalaxy.Entities
{
    public class Instructor:EntityBase
    {
        public string Nombres { get; set; } = default!;
        public string NroDocumento { get; set; } = default;
        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }
    }
}
