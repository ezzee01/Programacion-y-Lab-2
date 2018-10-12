using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
  class OtraClase
  {
    //capturo y relanzo MiExeption
    public void MetodoInstancia()
    {
      try
      {
        new DivisionExepcion();
      }
      catch(Exception e)
      {
        throw new MiExeption("Mi exepcion", e);
      }
    }
  }
}
