using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
  class DivisionExepcion 
  {
    //metodo estatico
    public static void exepcion()
    {
      throw new DivideByZeroException();
    }

    //capturo en constructor de instancia
    public DivisionExepcion()
    {
      try
      {
        DivisionExepcion.exepcion(); //llamo al metodo estatico
      }
      catch (DivideByZeroException e)
      {
        throw e;  //relanzo la exepcion
      }
    }

    //vuelvo a capturar en otro constructor de instancia y relanzo a UnaExeption
    public DivisionExepcion(int a)
    {
      try
      {
        new DivisionExepcion();
      }
      catch (DivideByZeroException e)
      {
        throw new UnaExeption("Una exepcion", e);
      }
    }
  }
}
