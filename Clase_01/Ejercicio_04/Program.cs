using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio Nro 04";

      int contador = 0;
      int contador2 = 0;
      int acumulador = 0;

      for(; ; )
      {
        contador++;

        for(int i=1; i < contador; i++)
        {
          if(contador % i == 0)
          {
            acumulador += i;
          }
        }
        if(acumulador == contador)
        {
          contador2++;
          Console.WriteLine("Numeros perfectos: {0}", contador);
        }
        if(contador2 == 4)
        {
          break;
        }
      }
      Console.ReadKey();
    }
  }
}
