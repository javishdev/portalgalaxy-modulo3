using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalGalaxy.Entities
{
    public class Alumno : EntityBase
    {
        public string NroDocumento { get; set; } = default!;
        public string NombreCompleto { get; set; } = default!;

        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Departamento { get; set; }=default!;
        public string Provincia { get; set; } = default!;
        public string Distrito { get; set; } = default!;

        public DateTime FechaInscripcion { get; set; }

    }
}
