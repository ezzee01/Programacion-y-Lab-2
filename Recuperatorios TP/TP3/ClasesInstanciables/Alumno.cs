using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Alumno : Universitario
    {
        #region Atributos
        public enum EEstadoCuenta { AlDia, Deudor, Becado}
        private EEstadoCuenta estadoCuenta;
        private Universidad.EClases claseQueToma;
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Alumno()
        { }

        /// <summary>
        /// Constructor de instancia. 
        /// </summary>
        /// <param name="id">Legajo del alumno.</param>
        /// <param name="nombre">Nombre del alumno.</param>
        /// <param name="apellido">Apellido del alumno.</param>
        /// <param name="dni">DNI del alumno.</param>
        /// <param name="nacionalidad">Nacionalidad del alumno.</param>
        /// <param name="claseQueToma">La clase que toma el alumno.</param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma):base(id,nombre,apellido,dni,nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        /// <summary>
        /// Constructor de instancia.
        /// </summary>
        /// <param name="id">Legajo del alumno.</param>
        /// <param name="nombre">Nombre del alumno.</param>
        /// <param name="apellido">Apellido del alumno.</param>
        /// <param name="dni">DNI del alumno.</param>
        /// <param name="nacionalidad">Nacionalidad del alumno.</param>
        /// <param name="claseQueToma">La clase que toma el alumno.</param>
        /// <param name="estadoCuenta">El estado de cuenta del alumno.</param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta):this(id,nombre,apellido,dni,nacionalidad,claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }
        #endregion

        #region Operadores

        /// <summary>
        /// Un Alumno será igual a un EClase si toma esa clase y su estado de cuenta no es Deudor.
        /// </summary>
        /// <param name="a">Alumno a comparar.</param>
        /// <param name="clase">Clase a comparar.</param>
        /// <returns>Devuelve true si el alumno toma la clase y su estado de cuenta es distinto de Deudor, sino false.</returns>
        public static bool operator == (Alumno a, Universidad.EClases clase)
        {
            return (a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor);
        }

        /// <summary>
        /// Un Alumno será distinto a un EClase sólo si no toma esa clase
        /// </summary>
        /// <param name="a">Alumno a comparar.</param>
        /// <param name="clase">Clase a comparar.</param>
        /// <returns>Devuelve true si el alumno no toma la clase, sino false.</returns>
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            return (a.claseQueToma != clase);
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Muestra todos los datos del alumno. 
        /// </summary>
        /// <returns>Devuelve una cadena con todos los datos del alumno.</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            if (this.estadoCuenta == EEstadoCuenta.AlDia)
            {
                sb.AppendLine("ESTADO DE CUENTA: Cuota al día");
            }
            else
            {
                sb.AppendFormat("ESTADO DE CUENTA: {0}\n", this.estadoCuenta);
            }
            sb.AppendLine(this.ParticiparEnClase());

            return sb.ToString();
        }

        /// <summary>
        /// Muestra la clase que toma el alumno.
        /// </summary>
        /// <returns>Devuelve una cadena "TOMA CLASE DE" junto al nombre de la clase que toma el alumno.</returns>
        protected override string ParticiparEnClase()
        {
            return string.Format("TOMA CLASES DE {0}", this.claseQueToma);
        }

        /// <summary>
        /// Hace públicos los datos del alumno.
        /// </summary>
        /// <returns>Devuelve una cadena con todos los datos del alumno.</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion
    }
}
