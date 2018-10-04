using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_parcial
{
    public class Gato : Mascota
    {
        #region Constructores
        public Gato(string nombre, string raza): base(nombre,raza)
        { }
        #endregion

        #region Metodos
        public override bool Equals (object obj)
        {
            bool valor = false;

            if (obj is Gato)
            {
                if ((Gato)obj == this)
                {
                    valor = true;
                }
            }
            else valor = false;

            return valor;
        }

        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.DatosCompletos());
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Ficha();
        }
        #endregion

        #region Operadores
        public static bool operator == (Gato obj1, Gato obj2)
        {
            if (obj1.Nombre == obj2.Nombre && obj1.Raza == obj2.Raza)
            {
                return true;
            }
            else return false;
        }

        public static bool operator != (Gato obj1, Gato obj2)
        {
            return !(obj1 == obj2);
        }
        #endregion
    }
}
