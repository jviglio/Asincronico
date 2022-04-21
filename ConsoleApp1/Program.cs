using ConsoleApp1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Contador cont = new Contador();
            cont.Esperar2();

            cont.Segundos = 5;
            var e = cont.Esperar();

            Contador cont2 = new Contador();
            cont2.Segundos = 3;
            var e2 = cont2.Esperar();

            await Task.WhenAll(e, e2);

            Console.WriteLine("Fin");
            Thread.Sleep(1000);
        }                  
    }
}

