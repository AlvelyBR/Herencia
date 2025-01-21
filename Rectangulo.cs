using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalFiguras
{
    class Rectangulo : Forma
    {
        public Rectangulo(double ancho, double alto) : base(ancho, alto) { }

        public override double CalcularSuperficie()
        {
            return Ancho * Alto;
        }
    }
}
