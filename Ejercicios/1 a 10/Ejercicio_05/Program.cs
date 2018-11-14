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
            int sumaUno;
            int sumaDos;
            int contador = 0;

            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            while (contador < numero)
            {

                contador++;
                sumaUno = 0;
                sumaDos = 0;

                // Calculo para atras
                for (int i = 1; i < contador; i++)
                {
                    sumaUno += i;
                }
                //calculo para adelante
                for (int j = contador + 1; j <= sumaUno; j++)
                {
                    if ((sumaDos == sumaUno) || (sumaDos > sumaUno))
                        break;
                    sumaDos += j;
                }

                // Mostrando en pantalla
                if (sumaUno == sumaDos)
                    Console.WriteLine("Es centro numerico: {0}", contador);
            }

            Console.ReadKey();
        }
    }
}
