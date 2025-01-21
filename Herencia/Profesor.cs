using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Profesor : Persona
    {
        public List<Curso> Cursos { get; set; }
        public Profesor(string nombre) : base (nombre)
        {
           Cursos = new List<Curso>();
        }
    }
}
