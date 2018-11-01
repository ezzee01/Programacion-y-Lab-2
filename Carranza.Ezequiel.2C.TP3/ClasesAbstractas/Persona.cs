using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public abstract class Persona
    {
        #region Atributos
        public enum ENacionalidad
        { Argentino, Extranjero}
        private string apellido;
        private string nombre;
        private int dni;
        private ENacionalidad nacionalidad;
        #endregion

        #region Propiedades
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public int DNI
        {
            get { return this.dni; }
            set { this.dni = value; }
        }

        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }

        public string StringToDNI
        {
            set { this.dni = Convert.ToInt32(value); }
        }
        #endregion

        #region Constructores
        public Persona()
        { }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.nacionalidad = nacionalidad;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad):this(nombre,apellido,dni.ToString(),nacionalidad)
        {
            
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad):this(nombre,apellido,nacionalidad)
        {
            
        }
    }
}
