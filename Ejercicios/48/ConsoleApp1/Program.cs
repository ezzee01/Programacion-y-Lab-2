using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_48;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
      Recibo d1 = new Recibo(250);
      Factura d2 = new Factura(400);
      Factura d3 = new Factura(1564);
      Recibo d4 = new Recibo();
      Contabilidad<Factura, Recibo> c = new Contabilidad<Factura, Recibo>();

      c += d2;
      c += d1;
      c += d3;
      c += d4;

      Console.WriteLine(c.Mostrar());

      Console.Read();
    }
  }
}
