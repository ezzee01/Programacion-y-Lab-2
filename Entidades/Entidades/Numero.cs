using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  class Numero
  {
    private double numero;

    static Numero()
    { }

    public Numero(double numero)
    {
      this.numero = numero;
    }

    public Numero(string strNumero)
    {
      this.numero = ValidarNumero(strNumero);
    }

    private static double ValidarNumero(string strNumero)
    {
      double numero = 0;

      if (double.TryParse(strNumero, out numero))
      {
        return numero;
      }
      else return numero;
    }

    public double SetNumero()
    {}

    public string BinarioDecimal(string binario)
    { }

    public string DecimalBinario(double numero)
    {
      string binario;

      if( numero >0)
      {
        
      }
    }

    public string DecimalBinario(string numero)
    { }

    public static double operator +(Numero n1, Numero n2)
    {
      return n1.numero + n2.numero;
    }

    public static double operator - (Numero n1, Numero n2)
    {
      return n1.numero - n2.numero;
    }

    public static double operator *(Numero n1, Numero n2)
    {
      return n1.numero * n2.numero;
    }

    public static double operator /(Numero n1, Numero n2)
    {
      if (n2.numero != 0)
      {
        return n1.numero / n2.numero;
      }
      else Console.WriteLine("Error, no se puede dividir por 0.");
      return 0;
    }
  }
}
