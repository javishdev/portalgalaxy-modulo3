using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalGalaxy.Entities
{
    public class Taller:EntityBase
    {
        public string Nombre { get; set; } = default!;
        public Categoria Categoria { get; set; }=default!;
        public int CategoriaId { get; set; }

        public Instructor Instructor { get; set; }=default!;
        public int  InstructorId { get; set; }

        public DateTime FechaInicio { get; set; }
        public DateTime HoraInicio { get; set; }

        public SituacionTaller SituacionTaller { get; set; }
        public string? PortalURL { get; set; }
        public string? Temario { get; set; }
    }
}
