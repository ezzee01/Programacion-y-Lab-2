using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_02
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio Nro 02";

      double numero;
      double cuadrado;
      double cubo;

      Console.Write("Ingrese numero: ");
      numero = double.Parse(Console.ReadLine());

      while(numero < 0)
      {
        Console.Write("ERROR. ¡Reingresar número!: ");
        numero = double.Parse(Console.ReadLine());
      }

      cuadrado = Math.Pow(numero, 2);
      cubo = Math.Pow(numero, 3);

      Console.WriteLine("Cuadrado de {0}: {1}", numero, cuadrado);
      Console.WriteLine("Cubo de {0}: {1}", numero, cubo);

      Console.ReadKey();
    }
  }
}
