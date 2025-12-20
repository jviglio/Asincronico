using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Contador
    {
        int segundos;

        public int Segundos { get => segundos; set => segundos = value; }

        public async Task Esperar()
        {
            Console.WriteLine("Inicio de contador " + segundos + " segundos - id: " + Thread.CurrentThread.ManagedThreadId);
            await Task.Run(() =>
            {
                Thread.Sleep(segundos * 1000);
                Console.WriteLine("Fin del contador de " + segundos + " segundos - id: " + Thread.CurrentThread.ManagedThreadId);
            });
        }
    }
}
