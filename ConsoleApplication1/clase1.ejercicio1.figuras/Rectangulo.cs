using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase1.ejercicio1.figuras
{
    class Rectangulo
    {
        public Double calcular_area(Double a, Double b)
        {
            return b * a;
        }
        public Double calcular_perimetro(Double a, Double b)
        {
            return 2 * a + 2 * b;
        }
    }
}
