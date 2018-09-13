using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Calculadora
    {
        private static string ValidarOperador(string operador)
        {
            if (string.Equals(operador, "+") == true || string.Equals(operador, "-") == true || string.Equals(operador, "*") == true || string.Equals(operador, "/") == true)
            {
                return operador;
            }
            else return "+";
        }

        public double Operar(Numero num1, Numero num2, string operador)
        {
      double resultado;

      switch (Calculadora.ValidarOperador(operador))
      {
        case "+":
          resultado = num1 + num2;
          break;
        case "-":
          resultado = num1 - num2;
          break;
        case "*":
          resultado = num1 * num2;
          break;
        case "/":
          resultado = num1 / num2;
          break;
      }
      return resultado;
    }
    }
}
