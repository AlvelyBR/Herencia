using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Estudiante : Persona
    {
        public int id { get; set; }

        public Estudiante(string nombre, int id) : base(nombre)
        {
           
        }

 
    }
}
