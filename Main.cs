using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalFiguras
{
    class Program
    {
        static void Main()
        {
            
            Forma[] formas = new Forma[]
            {
            new Rectangulo(10, 5),
            new Triangulo(8, 4),
            new Circulo(6)
            };

           
            double[] areas = new double[formas.Length];
            for (int i = 0; i < formas.Length; i++)
            {
                areas[i] = formas[i].CalcularSuperficie();
            }

            // Mostrar los resultados
            for (int i = 0; i < formas.Length; i++)
            {
                Console.WriteLine($"El área de la forma {formas[i].GetType().Name} es: {areas[i]:F2}");
            }
        }
    }
}
