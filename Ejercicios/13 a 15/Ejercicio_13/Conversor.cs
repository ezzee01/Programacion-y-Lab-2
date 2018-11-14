using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Conversor
    {
        public static string DecimalBinario(double numero)
        {
            string binario = "";
            int resto;
            int numeroEntero =(int)numero;
            
                while (numeroEntero > 0)
                {
                    resto = numeroEntero % 2;
                    numeroEntero = numeroEntero / 2;

                    binario = resto.ToString() + binario;
                }
                return binario;
            //}
            //else return "Valor inválido";
        }

        public static double BinarioDecimal(string binario)
        {
            double numeroDecimal = 0;

            if (int.Parse(binario) > 0)
            {
                for (int i = 1; i <= binario.Length; i++)
                {
                    if (binario.ElementAt(i - 1) == '1')
                    {
                        numeroDecimal += Math.Pow(2, binario.Length - i);
                    }
                }
                return numeroDecimal;
            }
            else return -1;
        }
    }
}
