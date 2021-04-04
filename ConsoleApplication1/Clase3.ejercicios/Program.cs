using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase3.ejercicios1.diccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            ///ejercicio a
            Dictionary<string, string> values = new Dictionary<string, string>();
            values.Add("Juan", "55423412");
            values.Add("Ernesto", "56985623");
            values.Add("Mariana", "54787451");
            // ContainsKey

            if (values.ContainsKey("Juan") == true)
            {
                Console.WriteLine(values["Juan"]);
            }
            //ejercicio b 
            // TryGetValue
            string mensaje = "";
                if (values.TryGetValue("Pedro", out mensaje))
                {
                    Console.WriteLine(values.Keys);

                }
                else
                    Console.WriteLine("No contiene llave");
            //ejercicio c 
            foreach (var p in values)
            {
                Console.WriteLine(p.Key+", "+p.Value);
            }

            //ejercicio d 

            if (values.ContainsKey("Mariana")==true) {
                values.Remove("54787451");
            }
            Console.WriteLine("Press key for continue...");
            Console.ReadLine();

        }

    }
}
