using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase1.ejercicio1.figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the menu");
            Console.WriteLine(" 1 -options square ");
            Console.WriteLine("2 -options rectangle");
            Console.WriteLine("3- options triangle ");
            Console.WriteLine(" ");
            ConsoleKeyInfo tecla;
            do
            {


                tecla = Console.ReadKey(false);
            } while ((tecla.KeyChar != '1')&& (tecla.KeyChar != '2') && (tecla.KeyChar != '3'));
            if (tecla.KeyChar == '1')
            {
                Cuadrado c = new Cuadrado();
                Console.WriteLine(" enter one side ");
                Double l = Double.Parse(Console.ReadLine());
                Console.WriteLine("enter an option");
                Console.WriteLine("1- calculate area");
                Console.WriteLine("2- calculate perimeter");
                int valor = int.Parse(Console.ReadLine());
                switch (valor)
                {

                    case 1:
                        Console.WriteLine("the area is {0} ", c.calcular_area(l));
                        break;
                    case 2:
                        Console.WriteLine("the perimeter is {0} ", c.calcular_perimetro(l));
                        break;
                }
            }
            if (tecla.KeyChar == '2') { 
            Rectangulo r = new Rectangulo();
            Console.WriteLine(" enter base ");
            Double bas = Double.Parse(Console.ReadLine());
            Console.WriteLine(" enter height ");
            Double alt = Double.Parse(Console.ReadLine());
            Console.WriteLine("enter an option");
            Console.WriteLine("1- calculate area");
            Console.WriteLine("2-calculate perimeter");
            int valor_option = int.Parse(Console.ReadLine());
            switch (valor_option)
            {

                case 1:
                    Console.WriteLine("the area is {0} ", r.calcular_area(bas, alt));
                    break;
                case 2:
                    Console.WriteLine("the perimeter is {0} ", r.calcular_perimetro(bas, alt));
                    break;
            }
        }
            if (tecla.KeyChar == '3')
            {
                Triangulo t = new Triangulo();
                Console.WriteLine(" enter side one ");
                Double l1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("enter side two ");
                Double l2 = Double.Parse(Console.ReadLine());
                Console.WriteLine("enter side three");
                Double l3 = Double.Parse(Console.ReadLine());

                Console.WriteLine("enter base ");
                Double b = Double.Parse(Console.ReadLine());
                Console.WriteLine("enter height");
                Double a = Double.Parse(Console.ReadLine());

                Console.WriteLine("enter an option");
                Console.WriteLine("1- calculate area");
                Console.WriteLine("2-calculate perimeter");
                int valor_option_ = int.Parse(Console.ReadLine());
                switch (valor_option_)
                {

                    case 1:
                        Console.WriteLine("the area is {0} ", t.calcular_area(b,a));
                        break;
                    case 2:
                        Console.WriteLine("the perimeter is {0} ", t.calcular_perimetro(l1,l2,l3));
                        break;
                }
            }
            Console.WriteLine("Press a key to finish.. ");
            Console.ReadKey(true);

        }
  
    }
}
