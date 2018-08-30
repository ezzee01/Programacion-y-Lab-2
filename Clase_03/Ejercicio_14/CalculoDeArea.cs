using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
  class CalculoDeArea
  {
    public static double CalcularCuadrado(double Numero)
    {
      return (Numero * Numero);
    }

    public static double CalcularTriangulo(double Base, double Altura)
    {
      return (Base * Altura / 2);
    }

    public static double CalcularCirculo(double Radio)
    {
      return (3.1415 * Radio * Radio);
    }
  }
}
