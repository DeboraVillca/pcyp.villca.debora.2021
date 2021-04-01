using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace clase1.ejercicio2.archivo
{
    class main
    {
        static void Main(string[] args)
        {
            String line;
            try
            {
                StreamReader sw = new StreamReader("C:\\Users\\Daniel\\Documents\\GitHub\\pcyp.villca.debora.2021\\ConsoleApplication1\\clase1.ejercicio2.archivo\\vial.csv");
                line = sw.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sw.ReadLine();
                }
                sw.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
