using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{    
    public abstract class Persona
    {
        #region Atributos
        private string apellido;
        private int dni;
        private int edad;
        private string nombre;
        #endregion

        #region Constructores
        public Persona(string nombre, string apellido, int edad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
        }
        #endregion

        #region Proopiedades
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public int Edad
        {
            get
            {
                return this.edad;
            }
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
        }
        #endregion

        #region Metodos
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0}\n", this.nombre);
            sb.AppendFormat("Apellido: {0}\n", this.apellido);
            sb.AppendFormat("Edad: {0}\n", this.edad);
            sb.AppendFormat("DNI: {0}\n", this.dni);
            return sb.ToString();
        }

        public abstract bool ValidarAptitud();
        #endregion
    }
}
