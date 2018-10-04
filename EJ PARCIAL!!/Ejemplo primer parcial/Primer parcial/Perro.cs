using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_parcial
{
    public class Perro : Mascota
    {
        #region Atributos
        private int edad;
        private bool esAlfa;
        #endregion

        #region Constructores
        public Perro(string nombre, string raza) : this(nombre, raza, 0, false)
        { }
        public Perro(string nombre, string raza, int edad, bool esAlfa) :base(nombre, raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }
        #endregion

        #region Propiedades
        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                this.edad = value;
            }
        }

        public bool EsAlfa
        {
            get
            {
                return this.esAlfa;
            }
            set
            {
                this.esAlfa = value;
            }
        }
        #endregion

        #region Metodos
        public override bool Equals(object obj)
        {
            bool valor = false;
            if (obj is Perro)
            {
                if((Perro)obj == this)
                {
                    valor = true;
                }
            }
            else
            {
                valor = false;
            }

            return valor;
        }

        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            if(this.esAlfa == true)
            {
                sb.AppendFormat(base.DatosCompletos() + ", es alfa de la manada, edad " + this.edad.ToString() + "\n");
            }
            else
            {
                sb.AppendFormat(base.DatosCompletos() + " edad " + this.edad.ToString() +"\n");
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Ficha();
        }
        #endregion

        #region Operadores
        public static explicit operator int(Perro perro)
        {
            return perro.edad;
        }

        public static bool operator ==(Perro j1, Perro j2)
        {
            if (j1.Nombre == j2.Nombre && j1.Raza == j2.Raza && j1.edad == j2.edad)
            {
                return true;
            }
            else return false;
        }

        public static bool operator !=(Perro j1, Perro j2)
        {
            return !(j1 == j2);
        }
        #endregion
    }
}
