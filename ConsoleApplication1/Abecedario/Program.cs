using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abecedario
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<char, char> dic = new Dictionary<char, char>();
            Task t1 = Task.Factory.StartNew(() => {
                for (byte a = 65; a <= 90; a++)
                {
                    Console.WriteLine((char)a);

                }
            });


            Console.ReadKey();
        }
    }
}
