using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 13";

            double NumeroDecimal;
            string NumeroBinario;

            double NumeroEnDecimal;
            string NumeroEnBinario;

            Console.WriteLine("Ingrese numero decimal: ");

            NumeroDecimal = Convert.ToDouble(Console.ReadLine());

            NumeroEnBinario = Conversor.DecimalBinario(NumeroDecimal);

            Console.WriteLine("El numero decimal en binario es: {0}", NumeroEnBinario);

            Console.WriteLine("Ingrese numero binario: ");

            NumeroBinario = Console.ReadLine();

            NumeroEnDecimal = Conversor.BinarioDecimal(NumeroBinario);

            Console.WriteLine("El numero binario en decimal es: {0}", NumeroEnDecimal);

            Console.ReadKey();
        }
    }
}
