using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Excepciones;

namespace ClasesAbstractas
{
    public abstract class Persona
    {
        #region Atributos
        public enum ENacionalidad
        { Argentino, Extranjero }
        private string apellido;
        private string nombre;
        private int dni;
        private ENacionalidad nacionalidad;
        #endregion

        #region Propiedades

        /// <summary>
        /// Establece/Obtiene el Apellido de una Persona (Validado).
        /// </summary>
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = ValidarNombreApellido(value); }
        }

        /// <summary>
        /// Establece/Obtiene el Nombre de una Persona (Validado).
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = ValidarNombreApellido(value); }
        }

        /// <summary>
        /// Establece/Obtiene el DNI de una Persona (Validado).
        /// </summary>
        public int DNI
        {
            get { return this.dni; }
            set { this.dni = ValidarDni(this.nacionalidad, value); }
        }

        /// <summary>
        /// Establece/Obtiene la Nacionalidad de una Persona (Validado).
        /// </summary>
        public ENacionalidad Nacionalidad
        {
            get { return this.nacionalidad; }
            set { this.nacionalidad = value; }
        }

        /// <summary>
        /// Establece/Obtiene el DNI de una Persona (Validado).
        /// </summary>
        public string StringToDNI
        {
            set { this.dni = ValidarDni(this.nacionalidad, value); }
        }
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Persona()
        { }

        /// <summary>
        /// Constructor de instancia.
        /// </summary>
        /// <param name="nombre">Nombre/s de la persona.</param>
        /// <param name="apellido">Apellido/s de la persona.</param>
        /// <param name="nacionalidad">Nacionalidad de la persona.</param>
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.nacionalidad = nacionalidad;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        /// <summary>
        /// Constructor de instancia
        /// </summary>
        /// <param name="nombre">Nombre/s de la persona.</param>
        /// <param name="apellido">Apellido/s de la persona.</param>
        /// <param name="dni">DNI de la persona(INT).</param>
        /// <param name="nacionalidad">Nacionalidad de la persona.</param>
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }

        /// <summary>
        /// Constructor de instancia
        /// </summary>
        /// <param name="nombre">Nombre/s de la persona.</param>
        /// <param name="apellido">Apellido/s de la persona.</param>
        /// <param name="dni">DNI de la persona(STRING).</param>
        /// <param name="nacionalidad">Nacionalidad de la persona.</param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Sobrescritura del metodo ToString(); Retorna datos de la persona.
        /// </summary>
        /// <returns>Nombre completo y nacionalidad de la persona.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("NOMBRE COMPLETO: {0}, {1}", this.Apellido, this.Nombre);
            sb.AppendFormat("\nNACIONALIDAD: {0}", this.nacionalidad);
            return sb.ToString();
        }

        /// <summary>
        /// Valida DNI segun nacionalidad
        /// Si es ARGENTINO: Entre 1 y 89999999 
        /// Si es EXTRANJERO: Entre 90000000 y 99999999 
        /// </summary>
        /// <param name="nacionalidad">Nacionalidad de la persona.</param>
        /// <param name="dato">DNI de la persona(INT).</param>
        /// <returns>DNI valido(INT).</returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if (dato < 1 || dato > 99999999)
            {
                throw new DniInvalidoException("DNI en rango invalido");
            }

            switch (nacionalidad)
            {
                case ENacionalidad.Argentino:
                    if (dato > 89999999)
                    {
                        throw new NacionalidadInvalidaException("DNI no corresponde a nacionalidad");
                    }
                    break;
                case ENacionalidad.Extranjero:
                    if (dato <= 89999999)
                    {
                        throw new NacionalidadInvalidaException("DNI no corresponde a nacionalidad");
                    }
                    break;
            }
            return dato;
        }

        /// <summary>
        /// Valida DNI segun nacionalidad
        /// Si es ARGENTINO: Entre 1 y 89999999 
        /// Si es EXTRANJERO: Entre 90000000 y 99999999 
        /// </summary>
        /// <param name="nacionalidad">Nacionalidad de la persona.</param>
        /// <param name="dato">DNI de la persona(STRING).</param>
        /// <returns>DNI valido(INT).</returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int dniEntero;

            if (Regex.IsMatch(dato, @"^[0-9]+[0-9\.]*$"))
            {
                dato = dato.Replace(".", "");
                //dniEntero = Int32.Parse(dato);
                Int32.TryParse(dato, out dniEntero);
            }
            else throw new DniInvalidoException("DNI ingresado tiene un formato inválido.");

            return ValidarDni(nacionalidad, dniEntero);
        }

        /// <summary>
        /// Valida que el apellido/nombre sea sólo letras, con opción de poner un espacio seguido de un segundo apellido/nombre. 
        /// </summary>
        /// <param name="dato">Nombre/Apellido a validar</param>
        /// <returns>Apellido/nombre validado o cadena vacía.</returns>
        private string ValidarNombreApellido(string dato)
        {
            string retorno = "";

            if(Regex.IsMatch(dato, @"^([a-zA-Záéíóú]+)(\s[a-zA-Záéíóú]+)*$"))
            {
                retorno = dato;
            }

            return retorno;
        }
        #endregion
    }
}
