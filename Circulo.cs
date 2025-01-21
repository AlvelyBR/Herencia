using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalFiguras
{
    class Circulo : Forma
    {
        public Circulo(double radio) : base(radio, radio) { }

        public override double CalcularSuperficie()
        {
            return Math.PI * Ancho * Ancho;
        }
    }
}
