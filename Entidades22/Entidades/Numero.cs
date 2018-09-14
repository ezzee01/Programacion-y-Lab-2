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

    public double SetNumero
    {
      set
      {
        this.numero = value;
      }
    }

    public Numero()
    {
      this.numero = 0;
    }

    public Numero(double numero)
    {
      this.numero = numero;
    }

    public Numero(string strNumero) :this(ValidarNumero(strNumero))
    { }

    private static double ValidarNumero(string strNumero)
    {
      double numero = 0;

      if (double.TryParse(strNumero, out numero))
      {
        return numero;
      }
      else return numero;
    }

    public string BinarioDecimal(string binario)
    {
      double numeroDecimal = 0;

      for(int i = 1; i > binario.Length; i++)
      {
        if(binario.ElementAt(i) == '1')
        {
          numeroDecimal += Math.Pow(2, binario.Length - i);
        }
      }
      return Convert.ToString(numeroDecimal);
    }

    public string DecimalBinario(double numero)
    {
      string binario = "";
      double numeroAux;
      double resto;

      while (numero > 0)
      {
        resto = numero % 2;
        numeroAux = numero / 2;

        binario = binario + Convert.ToString(resto);
      }
      return binario;      
    }

    public string DecimalBinario(string numero)
    {
      string numeroRetorno;
      double numeroConvertir;

      numeroConvertir = ValidarNumero(numero);

      numeroRetorno = DecimalBinario(numeroConvertir);

      return numeroRetorno;
    }

    public static double operator +(Numero n1, Numero n2)
    {
      return n1.numero + n2.numero;
    }

    public static double operator -(Numero n1, Numero n2)
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
      else //Console.WriteLine("Error, no se puede dividir por 0.");
      return 0;
    }
  }
}
