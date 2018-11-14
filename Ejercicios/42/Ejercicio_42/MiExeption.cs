using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
  class MiExeption : Exception
  {
    public MiExeption(string mensaje, Exception innerinnerException) : base(mensaje, innerinnerException)
    { }
  }
}
