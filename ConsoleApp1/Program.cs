using ConsoleApp1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Espera();
        }

        private static void Espera()
        {
            Contador cont = new Contador();
            cont.Esperar2();

            cont.Segundos = 5;
            cont.Esperar();

            Contador cont2 = new Contador();
            cont2.Segundos = 3;
            cont2.Esperar();

            Console.ReadKey();
        }             
        
    }
}

