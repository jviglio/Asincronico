using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Contador
    {
        int segundos;

        public int Segundos { get => segundos; set => segundos = value; }

        public async void Esperar()
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

        public async void Esperar2()
        {
            Task<int> task = new Task<int>(GetCharacterCount);
            task.Start();
            int count = await task; 
            Console.WriteLine("Esperar2 " + count);
        }

        private int GetCharacterCount()
        {
            int count = 0;
            using (StreamReader r = new StreamReader("C:\\theData.txt"))
            {
                string content = r.ReadToEnd();
                count = content.Length;
                Thread.Sleep(4000);
            }
            return count;
        }
    }
}
