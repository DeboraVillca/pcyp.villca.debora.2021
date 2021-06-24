using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Clase9.WaitAllOneByOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = Stopwatch.StartNew();

            sw.Start();

            int suma = 0;
            Task t1 = Task.Factory.StartNew((arg) => {
                Thread.Sleep(1000);
                int sumaT = (int)arg + 10;
                return sumaT;
            }, suma);


            Task t2 = Task.Factory.StartNew((arg) => {
                Thread.Sleep(1000);
                Thread.Sleep(1000);
                int sumaT = (int)arg + 10;
                return sumaT;
            }, suma);

            int cantidadTareas = 2;
            Task[] tasks = new Task[] { t1, t2 };
            int indice;

            while (cantidadTareas > 0)
            {
                indice = Task.WaitAny(tasks);
                cantidadTareas--;
                suma += tasks[indice].result;
            }

            sw.Stop();

            Console.WriteLine("El total es {0} en {1} segundos", suma, (sw.ElapsedMilliseconds / 1000));
        }
    }
}
