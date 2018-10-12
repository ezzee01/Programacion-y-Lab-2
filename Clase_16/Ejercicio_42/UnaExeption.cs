using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
  class UnaExeption : Exception
  {
    //almaceno exepcion original
    public UnaExeption(string mensaje, Exception innerinnerException):base (mensaje,innerinnerException)
    { }
  }
}
