using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace clase1.ejercicio2.archivo
{
    class Program
    {
        static void Main(string[] args)
        {
            String line;
            try
            {
                
                StreamReader sw = new StreamReader("C:\\Users\\Daniel\\Documents\\GitHub\\pcyp.villca.debora.2021\\ConsoleApplication1\\clase1.ejercicio2.archivo\\vial.csv");
               
                //Read the first line of text
                line = sw.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the lie to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sw.ReadLine();
                }
                //close the file
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
