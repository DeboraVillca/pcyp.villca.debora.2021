using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Palabras
{
    class Palabras
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, enter paragraph");
            String texto;
            texto = Console.ReadLine();
           
            string[] words = texto.Split();
            int[] nro_repeticion_palabra = new int[words.Length];
            Dictionary<string,int> values = new Dictionary<string, int>();
            /// falta implementacion de diccionario
            /// 


            for (int i = 0; i < words.Length; i++){
              for (int j = 0; j < words.Length; j++){
                        if (words[i].CompareTo(words[j]) == 0) {   
            nro_repeticion_palabra[i]++;
                     }
                }
            Console.WriteLine(words[i] + " "+nro_repeticion_palabra[i]);

            }
            Console.ReadLine();
        }
    }
}
