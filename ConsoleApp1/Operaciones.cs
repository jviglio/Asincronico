using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Persona
    {
        string nombre;
        int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }

        public void Imprimir()
        {
            Console.WriteLine(Nombre + ", " + Edad + " años");
        }
    }

    public class Empleado : Persona
    {
        float sueldo;

        public float Sueldo { get => sueldo; set => sueldo = value; }

        public void Imprimir()
        {
            base.Imprimir();
            Console.WriteLine("El sueldo es " + Sueldo);
        }
    }

}
