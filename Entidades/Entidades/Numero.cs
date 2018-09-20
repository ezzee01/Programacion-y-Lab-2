using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Numero
    {
        private double numero;

        private double SetNumero
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

        public Numero(string strNumero) : this(ValidarNumero(strNumero))
        { }

        private static double ValidarNumero(string strNumero)
        {
            double numero = 0;
            bool resultadoValidacion = false;

            foreach(var num in strNumero)
            {
                if (num >= 48 && num <= 57 || double.TryParse(strNumero,out numero))
                {
                    resultadoValidacion = true;
                }
                else
                {
                    resultadoValidacion = false;
                    break;
                }
            }
            
            if (resultadoValidacion == true)
            {
                numero = double.Parse(strNumero);
                return numero;
            }
            else return numero;
        }

        public string BinarioDecimal(string binario)
        {
            int numeroDecimal = 0;
            string resultado = "Valor inválido";
            bool esBinario = false;
            
            foreach(var num in binario)
            {
                if(num == '1' || num == '0')
                {
                    esBinario = true;
                }
                else
                {
                    esBinario = false;
                    break;
                }
            }

            if (esBinario == true)
            {
                resultado = "";
                for(int i =1; i<= binario.Length; i++)
                {
                    if (binario.ElementAt(i - 1) == '1')
                    {
                        numeroDecimal += (int) Math.Pow(2, binario.Length - i);
                    }
                }
                resultado = numeroDecimal.ToString();
                return resultado;
            }
            else return resultado;
        }

        public string DecimalBinario(double numero)
        {
            string binario = "";
            int numeroEntero = (int)numero;
            
            if(numeroEntero <= 0)
            {
                binario = "Valor inválido";
            }
            while(numeroEntero > 0)
            {
                binario = (numeroEntero % 2).ToString() + binario;
                numeroEntero = numeroEntero / 2;
            }

            return binario;
        }

        public string DecimalBinario(string numero)
        {
            string resultado = "Valor inválido";

            if (numero != "" && numero != "Valor inválido")
            {
                resultado = DecimalBinario(double.Parse(numero));
                return resultado;
            }
            else return resultado;            
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
            else return double.MinValue;
        }
    }
}
