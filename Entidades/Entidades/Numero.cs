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

        private static double ValidarNumero(string strNumero)
        {
            double numero;

            if (double.TryParse(strNumero, out numero))
            {
                return numero;
            }
            else return (double) 0;
        }

        public double SetNumero()
        {
            
        }
    }
}
