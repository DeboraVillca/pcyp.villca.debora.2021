using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.ejercicios
{
    class List
    {

        private static readonly string[] colors = { "MAGENTA", "RED", "WHITE", "BLUE", "CYAN" };
        private static readonly string[] removeColors = { "RED", "WHITE", "BLUE" };
        static void Main(string[] args)
        {

            List<string> colors_ = new List<string>(colors);
            List<string> removeColors_ = new List<string>(removeColors);
            Console.Write("List: ");
            foreach (string name in colors_) {
                Console.Write( name+",");
            }
            Console.WriteLine(" ");
            Console.WriteLine("Lista luego de eliminar  "); 
            for (int i = 0; i < colors_.Count; i++){
                for (int j = 0; j < removeColors_.Count; j++) {
                    if (colors_[i] == removeColors_[j]) {
                        colors_.RemoveAt(i);
                    }
               }Console.Write(colors_[i]+" "); 
            }
            Console.WriteLine(" ");
            Console.WriteLine("Press key for continue...");
            Console.ReadLine();
        }
         
    }
}
