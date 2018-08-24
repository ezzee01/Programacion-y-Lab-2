using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 11";

            int Numero;
            int minimo = int.MaxValue;
            int maximo = int.MinValue;
            int suma =0;
            float promedio;

            for(int i = 0; i<10;i++)
            {
                Console.WriteLine("Ingrese un numero entre -100 y 100: ");

                Numero = int.Parse(Console.ReadLine());

                while (!Validacion.Validar(Numero, -100, 100))
                {
                    Console.WriteLine("Error, reingrese: ");
                    Numero = int.Parse(Console.ReadLine());
                } 

                if(Numero < minimo)
                {
                    minimo = Numero;
                }
                else if(Numero > maximo)
                {
                    maximo = Numero;
                }
                suma += Numero;
            }
            promedio = (float)suma / 10;

            Console.WriteLine("El numero minimo es: {0}", minimo);
            Console.WriteLine("El numero maximo es: {0}", maximo);
            Console.WriteLine("El promedio es: {0}", promedio);

            Console.ReadKey();
        }
    }
}
