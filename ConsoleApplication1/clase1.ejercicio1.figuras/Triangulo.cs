using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase1.ejercicio1.figuras
{
    class Triangulo
    {
        public Double calcular_area(Double b, Double a)
        {
            return b * a / 2;
        }
        public Double calcular_perimetro(Double l1, Double l2,Double l3)
        {
            return l1 + l2 + l3;
        }
    }
}
