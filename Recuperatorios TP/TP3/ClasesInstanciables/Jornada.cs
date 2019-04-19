using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;

namespace ClasesInstanciables
{
    public class Jornada
    {
        #region Atributos
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;
        #endregion

        #region Propiedades

        /// <summary>
        /// Hace pública la lista de alumnos.
        /// </summary>
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        /// <summary>
        /// Hace pública el atributo clase.
        /// </summary>
        public Universidad.EClases Clase
        {
            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
        }

        /// <summary>
        /// Hace pública el atributo profesor.
        /// </summary>
        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor por defecto. Inicializa la lista de alumnos.
        /// </summary>
        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        /// <summary>
        /// Constructor de instancia. Inicializa clase e instructor.
        /// </summary>
        /// <param name="clase">Clase en la que consistirá la jornada.</param>
        /// <param name="instructor">Profesor que dará la clase</param>
        public Jornada(Universidad.EClases clase, Profesor instructor) : this()
        {
            this.instructor = instructor;
            this.clase = clase;
        }
        #endregion

        #region Operadores

        /// <summary>
        /// Una jornada será igual a un alumno si el mismo participa de la clase.
        /// </summary>
        /// <param name="j">Jornada a comparar.</param>
        /// <param name="a">Alumno a comparar.</param>
        /// <returns>Devuelve true si el alumno participa de la jornada, sino false.</returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            return j.Alumnos.Contains(a);
        }

        /// <summary>
        /// Una jornada será diferente a un alumno si el mismo NO participa de la clase.
        /// </summary>
        /// <param name="j">Jornada a comparar.</param>
        /// <param name="a">Alumno a comparar.</param>
        /// <returns>Devuelve true si el alumno NO participa de la jornada, sino false.</returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        /// <summary>
        /// Agrega un nuevo alumno a la lista de alumnos. 
        /// </summary>
        /// <param name="j">Jornada a la que agregar alumno.</param>
        /// <param name="a">Nuevo alumno a agregar.</param>
        /// <returns>La jornada con el nuevo alumno incluído.</returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
            {
                j.Alumnos.Add(a);
            }
            //else throw new AlumnoRepetidoException();
            return j;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Informa todos los datos de una jornada.
        /// </summary>
        /// <returns>Devuelve una cadena con los datos de la jornada.</returns>
        public override string ToString()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendFormat("CLASE DE {0} POR {1}", this.Clase, this.Instructor.ToString());
            datos.AppendLine("ALUMNOS:");
            foreach (Alumno alumno in this.Alumnos)
            {
                datos.AppendLine(alumno.ToString());
            }

            return datos.ToString();
        }

        /// <summary>
        /// Guarda una jornada en un archivo de texto.
        /// </summary>
        /// <param name="jornada">Jornada a guardar.</param>
        public static bool Guardar(Jornada jornada)
        {
            Texto texto = new Texto();        

            return texto.Guardar("Jornada.txt", jornada.ToString());
        }

        /// <summary>
        /// Lee el archivo donde se almacenan las jornadas y retorna la información obtenida.
        /// </summary>
        /// <returns>Devuelve los datos leídos del archivo en formato string.</returns>
        public static string Leer()
        {
            Texto texto = new Texto();
            string datos;

            texto.Leer("Jornada.txt", out datos);

            return datos;
        }
        #endregion
    }
}
