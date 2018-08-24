using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02
{
    class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool retorno = false;
            while(valor < min || valor > max)
            {
                return retorno;
            }
            retorno = true;
            return retorno;
        }
    }
}
