using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Profesor : Universitario
    {
        #region Atributos
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor de clase, inicializa el atributo Random.
        /// </summary>
        static Profesor()
        {
            random = new Random();
        }

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Profesor()
        { }

        /// <summary>
        /// Constructor de instancia. Inicializa la cola de clases del día del profesor.
        /// También asigna dos clases al azar a dicha cola. 
        /// </summary>
        /// <param name="id">Legajo del profesor.</param>
        /// <param name="nombre">Nombre del profesor.</param>
        /// <param name="apellido">Apellido del profesor.</param>
        /// <param name="dni">DNI del profesor.</param>
        /// <param name="nacionalidad">Nacionalidad del profesor.</param>
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad):base (id,nombre,apellido,dni,nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Asigna dos clases al azar a la cola de clases del día del profesor. 
        /// </summary>
        private void _randomClases()
        {
            this.clasesDelDia.Enqueue((Universidad.EClases)Profesor.random.Next(0, 4));
            this.clasesDelDia.Enqueue((Universidad.EClases)Profesor.random.Next(0, 4));
        }

        /// <summary>
        /// Muestra todos los datos del profesor. 
        /// </summary>
        /// <returns>Devuelve una cadena con todos los datos del profesor.</returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine(this.ParticiparEnClase());
            return sb.ToString();
        }

        /// <summary>
        /// Muestra las clases que da el profesor.
        /// </summary>
        /// <returns>Devuelve una cadena "TOMA CLASE DE" junto al nombre de las clases que da el profesor.</returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CLASES DEL DÍA:");
            if (!object.ReferenceEquals(this.clasesDelDia, null))
            {
                foreach (Universidad.EClases c in this.clasesDelDia)
                {
                    sb.AppendFormat("{0}\n", c);
                }
            }
            return sb.ToString();
        }

        /// <summary>
        /// Hace públicos los datos del profesor.
        /// </summary>
        /// <returns>Devuelve una cadena con todos los datos del profesor.</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion

        #region Operadores

        /// <summary>
        /// Será igual si el profesor da la clase.
        /// </summary>
        /// <param name="i">Profesor a comparar.</param>
        /// <param name="clase">Clase a comparar.</param>
        /// <returns>Devuelve true si el profesor da la clase, sino false.</returns>
        public static bool operator == (Profesor i, Universidad.EClases clase)
        {
            bool retorno = false;

            foreach(Universidad.EClases clas in i.clasesDelDia)
            {
                if(clas == clase)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Será distinto si el profesor no da la clase.
        /// </summary>
        /// <param name="i">Profesor a comparar.</param>
        /// <param name="clase">Clase a comparar.</param>
        /// <returns>Devuelve true si el profesor NO da la clase, sino false.</returns>
        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }
        #endregion
    }
}
