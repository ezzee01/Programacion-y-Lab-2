using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio Nro 03";

      int numero;

      Console.Write("Ingrese un numero: ");

      numero = int.Parse(Console.ReadLine());

      for(int i = 1; i < numero; i++)
      {
        for(int j = 0; i< numero-1; i++)
        {
          if (j % )
          {
            Console.WriteLine("Numeros primos: {0}", i);
          }
        }
      }

      Console.ReadKey();
    }
  }
}
