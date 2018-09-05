using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 15";

            char Operacion;
            double NumeroUno;
            double NumeroDos;

            Console.WriteLine("Calculadora.");
            Console.WriteLine("Ingrese calculo a realizar: ");

            NumeroUno = double.Parse(Console.ReadLine());
            Operacion = char.Parse(Console.ReadLine());
            NumeroDos = double.Parse(Console.ReadLine());


            Console.ReadKey();
        }
    }
}
