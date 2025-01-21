using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Clase
    {
       public string claseTipo { get; set; }

        public List<Estudiante> Estudiantes { get; set; } 
        public List<Profesor> Profesores { get; set; }

        public Clase(string claseTipo)
        {
            this.claseTipo = claseTipo;
            Estudiantes = new List<Estudiante>();
            Profesores = new List<Profesor>();
        }

   
    }
}
