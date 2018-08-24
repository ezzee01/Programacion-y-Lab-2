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
      int contador = 0;

      Console.Write("Ingrese un numero: ");

      numero = int.Parse(Console.ReadLine());

      for(int i = 2; i <= numero; i++)
      {
        for(int j = 1; j < numero; j++)
        {
          if(i % j == 0)
          {
            contador++;
          }
        }
        if (contador <= 2)
        {
          Console.WriteLine("Numeros primos: {0}", i);
        }
        contador = 0;
      }

      Console.ReadKey();
    }
  }
}
