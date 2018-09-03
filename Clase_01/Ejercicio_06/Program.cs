using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 06";

            int año;
            while (true)
            {
                Console.WriteLine("Ingrese año: ");
                año = int.Parse(Console.ReadLine());

                if (año % 4 == 0 && año % 100 != 0 || año % 100 == 0 && año % 400 == 0)
                {
                    Console.WriteLine("El año {0} es biciesto.", año);
                }
                else Console.WriteLine("El año {0} NO es biciesto.", año);

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
