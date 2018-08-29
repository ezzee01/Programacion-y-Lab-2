using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 05";

            int numero;
            int sumaUno=0;
            int sumaDos = 0;

            Console.WriteLine("Ingrese un numero");
            numero = int.Parse(Console.ReadLine());

            for(int i=1;i<numero;i++)
            {
                for(int j = i; i<=i; j++)
                {
                    sumaUno += j;

                    for(int z = i+1; z<numero;z++)
                    {
                        sumaDos += z;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
