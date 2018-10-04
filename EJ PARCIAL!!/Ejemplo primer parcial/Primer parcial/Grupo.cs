using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_parcial
{
    class Grupo
    {
        #region Atributos
        public enum TipoManada
        {
            Única,
            Mixta
        }
        private List<Mascota> manada;
        private string nombre;
        private static TipoManada tipo;
        #endregion

        #region Propiedades
        public TipoManada Tipo
        {
            set
            {
                tipo = value;
            }
        }
        #endregion

        #region Constructores
        private Grupo()
        {
            this.manada = new List<Mascota>();
        }

        static Grupo()
        {
            tipo = TipoManada.Única;
        }

        public Grupo(string nombre): this()
        {
            this.nombre = nombre;
        }

        public Grupo (string nombre, TipoManada tipo):this(nombre)
        {
            this.Tipo = tipo;
        }
        #endregion

        #region Operadores
        public static implicit operator string(Grupo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("**{0} {1}**\n", e.nombre, Grupo.tipo);
            sb.AppendLine("Integrantes: ");

            foreach(Mascota m in e.manada)
            {
                sb.AppendFormat(m.ToString());
            }
            return sb.ToString();
        }

        public static bool operator !=(Grupo e, Mascota j)
        {
            return !(e == j);
        }

        public static bool operator ==(Grupo e, Mascota j)
        {
            bool valor = false;
            foreach(Mascota m in e.manada)
            {
                if(j == m)
                {
                    valor = true;
                    return valor;                    
                }
            }
            return valor;
        }

        public static Grupo operator -(Grupo e, Mascota j)
        {
            foreach(Mascota m in e.manada)
            {
                if(m == j)
                {
                    e.manada.Remove(j);
                    break;
                }
            }
            return e;
        }

        public static Grupo operator +(Grupo e, Mascota j)
        {
            foreach(Mascota m in e.manada)
            {
                if(m == j)
                {
                    return e;
                }
            }
            e.manada.Add(j);
            return e;
        }
        #endregion
    }
}
