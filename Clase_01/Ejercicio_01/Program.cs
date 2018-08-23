using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio Nro 1";

      int numero, suma=0;
      int maximo = int.MinValue;
      int minimo = int.MaxValue;
      float promedio;

      for(int i=0; i<5 ; i++)
      {
        Console.Write("Ingrese numero: ");
        numero = int.Parse(Console.ReadLine());
        
        if(numero > maximo)
        {
          maximo = numero;
        }
        else if (numero < minimo)
            {
          minimo = numero;
        }
        suma += numero;
      }

      promedio = (float) suma / 5;

      Console.WriteLine("Maximo: {0}", maximo);
      Console.WriteLine("Minimo: {0}", minimo);
      Console.WriteLine("Promedio: {0}", promedio);

      Console.ReadKey();
    }
  }
}
