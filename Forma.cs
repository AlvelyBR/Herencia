using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalFiguras
{
    abstract class Forma
    {
        public double Ancho { get; set; }
        public double Alto { get; set; }

        public Forma(double ancho, double alto)
        {
            Ancho = ancho;
            Alto = alto;
        }

        public abstract double CalcularSuperficie();
    }
}
