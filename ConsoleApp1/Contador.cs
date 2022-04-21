using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Contador
    {
        int segundos;

        public int Segundos { get => segundos; set => segundos = value; }

        public async Task Esperar()
        {
            Console.WriteLine("Inicio de contador " + segundos + " segundos");
            await LongOperation();
        }

        private Task LongOperation()
        {
            return Task.Run(() =>
            {
                System.Threading.Thread.Sleep(segundos * 1000);
                Console.WriteLine("Fin del contador de " + segundos + " segundos");
            });
        }
    }
}
