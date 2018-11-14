using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        OtraClase clase = new OtraClase();
        clase.MetodoInstancia();
      }
      catch(MiExeption e)
      {
        Console.WriteLine(e.Message);
      }

      Console.ReadKey();
    }
  }
}
