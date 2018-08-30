using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 12";
            char Respuesta = 'N';
            int Suma = 0;
            int NumeroUno;
            int NumeroDos;

            do
            {
                Console.WriteLine("Ingrese un numero: ");

                NumeroUno = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese otro numero: ");

                NumeroDos = int.Parse(Console.ReadLine());

                Suma = NumeroUno + NumeroDos;

                Console.WriteLine("La suma es: {0}", Suma);

                Console.WriteLine("¿Desea volver a sumar numeros? S/N");
                Respuesta = char.ToUpper(char.Parse(Console.ReadLine()));

            } while (ValidarRespuesta.ValidaS_N(Respuesta));

            Console.ReadKey();
        }
    }
}
