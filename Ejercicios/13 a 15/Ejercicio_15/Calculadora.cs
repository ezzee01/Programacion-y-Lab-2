using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Calculadora
    {
        public static double Calcular(double NumeroUno, char Operacion, double NumeroDos)
        {
            switch (Operacion)
            {
                case '+':
                    return (NumeroUno + NumeroDos);
                    break;
                case '-':
                    return (NumeroUno - NumeroDos);
                    break;
            }
        }

        public static bool Validar(double Numero)
        {
            bool retorno = false;
            if (Numero != 0)
            {
                retorno = true;
                return retorno;
            }
            else return retorno;
        }

        public static void Mostrar(double Resultado)
        {
            Console.WriteLine("Resultado: {0}", Resultado);
        }
    }
}
