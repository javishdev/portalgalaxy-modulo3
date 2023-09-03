using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalGalaxy.Entities
{
    public class Inscripcion:EntityBase
    {
        public Alumno Alumno { get; set; } = default!;
        public int AlumnoId { get; set; }
        public Taller Taller { get; set; }=default!;
        public int TallerId { get; set; }
        public SituacionTaller situacion { get; set; }
    }
}
