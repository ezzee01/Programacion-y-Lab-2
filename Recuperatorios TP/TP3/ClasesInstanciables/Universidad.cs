using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;

namespace ClasesInstanciables
{
    public class Universidad 
    {
        #region Atributos
        private List<Alumno> alumnos;
        private List<Jornada> jornadas;
        private List<Profesor> profesores;
        public enum EClases { Laboratorio, Programacion, Legislacion, SPD }
        #endregion

        #region Propiedades

        /// <summary>
        /// Hace pública la lista de Alumnos.
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
        /// Hace pública la lista de Instructores.
        /// </summary>
        public List<Profesor> Instructores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }
        }

        /// <summary>
        /// Hace pública la lista de Jornadas.
        /// </summary>
        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornadas;
            }
            set
            {
                this.jornadas = value;
            }
        }

        /// <summary>
        /// Indexador para las jornadas.
        /// </summary>
        /// <param name="i">Índice de la jornada.</param>
        /// <returns>Retorna una jornada o null.</returns>
        public Jornada this[int i]
        {
            get
            {
                if (i >= 0 && i < this.Jornadas.Count)
                {
                    return this.Jornadas[i];
                }
                else return null;
            }
            set
            {
                if (i >= 0 && i < this.Jornadas.Count)
                {
                    this.Jornadas[i] = value;
                }
            }
        }
        #endregion

        #region Constructores

        /// <summary>
        /// Constructor por defecto Inicializa las listas.
        /// </summary>
        public Universidad()
        {
            this.jornadas = new List<Jornada>();
            this.profesores = new List<Profesor>();
            this.alumnos = new List<Alumno>();
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Genera una cadena con los datos de la universidad.
        /// </summary>
        /// <param name="uni">Universidad de la que se quiere mostrar los datos.</param>
        /// <returns>Cadena con los datos de la universidad.</returns>
        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();

            foreach(Jornada jornada in uni.Jornadas)
            {
                sb.AppendLine("JORNADA:");
                sb.AppendLine(jornada.ToString());
                sb.AppendLine("< ------------------------------------------------------------------- >");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Sobrescritura del metodo ToString(); Retorna datos de la universidad.
        /// </summary>
        /// <returns>Cadena con los datos de la universidad.</returns>
        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }

        /// <summary>
        /// Serializa una universidad en formato XML.
        /// </summary>
        /// <param name="gim">Universidad a serializar.</param>
        public static bool Guardar(Universidad uni)
        {
            Xml<Universidad> xml = new Xml<Universidad>();

            return xml.Guardar("Universidad.xml", uni);
        }

        /// <summary>
        /// Deserializa una universidad guardada en formato XML.
        /// </summary>
        /// <returns>Objeto tipo Universidad con todos los datos guardados en el XML.</returns>
        public static Universidad Leer()
        {
            Universidad retorno;
            Xml<Universidad> xml = new Xml<Universidad>();

            xml.Leer("Universidad.xml", out retorno);

            return retorno;
        }
        #endregion

        #region Operadores

        /// <summary>
        /// Una universidad es igual a un alumno si ese alumno está inscripto en la universidad. 
        /// </summary>
        /// <param name="g">Universidad a comparar.</param>
        /// <param name="a">Alumno a comparar.</param>
        /// <returns>Devuelve true si el alumno está inscripto en la universidad, sino false.</returns>
        public static bool operator ==(Universidad g, Alumno a)
        {
            return g.Alumnos.Contains(a);
        }

        /// <summary>
        /// Una universidad es igual a un profesor si ese profesor es parte de la universidad. 
        /// </summary>
        /// <param name="g">Universidad a comparar.</param>
        /// <param name="i">Profesor a comparar.</param>
        /// <returns>Devuelve true si el profesor es parte de la universidad, sino false.</returns>
        public static bool operator ==(Universidad g, Profesor i)
        {
            return g.profesores.Contains(i);
        }

        /// <summary>
        /// Devuelve el primer profesor de esa universidad que de esa clase.
        /// </summary>
        /// <param name="g">Universidad a evaluar.</param>
        /// <param name="clase">Clase que debe dar el profesor.</param>
        /// <returns>Devuelve el primer profesor que de esa clase. Si no hay ninguno lanza 
        /// SinProfesorException.</returns>
        public static Profesor operator ==(Universidad g, EClases clase)
        {
            foreach(Profesor p in g.Instructores)
            {
                if(p == clase)
                {
                    return p;
                }
            }

            throw new SinProfesorException();
        }

        /// <summary>
        /// Una universidad es distinta a un alumno si ese alumno no está inscripto en la universidad. 
        /// </summary>
        /// <param name="g">Universidad a comparar.</param>
        /// <param name="a">Alumno a comparar.</param>
        /// <returns>Devuelve true si el alumno no está inscripto en la universidad, sino false.</returns>
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        /// <summary>
        /// Una universidad es distinta a un profesor si ese profesor no es parte de la universidad. 
        /// </summary>
        /// <param name="g">Universidad a comparar.</param>
        /// <param name="i">Profesor a comparar.</param>
        /// <returns>Devuelve true si el profesor no es parte de la universidad, sino false.</returns>
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }

        /// <summary>
        /// Devuelve el primer profesor de esa universidad que no de esa clase.
        /// </summary>
        /// <param name="g">Universidad a evaluar.</param>
        /// <param name="clase">Clase que NO debe dar el profesor.</param>
        /// <returns>Devuelve el primer profesor que NO de esa clase. Si no hay ninguno lanza SinProfesorException.</returns>
        public static Profesor operator !=(Universidad g, EClases clase)
        {
            return (g != clase);
        }

        /// <summary>
        /// Agrega una nueva jornada de clase y asigna un profesor y a los alumnos que tomen esa clase.
        /// </summary>
        /// <param name="g">Universidad en cuestión.</param>
        /// <param name="clase">Clase a agregar.</param>
        /// <returns>La universidad con la nueva jornada de clase cargada.</returns>
        public static Universidad operator +(Universidad g, EClases clase)
        {
            Jornada jornada = new Jornada(clase, (g == clase));

            foreach (Alumno alumno in g.Alumnos) //Por cada alumno inscripto en la universidad...
            {
                if (alumno == clase) //Será igual si toma esa clase y no es deudor...
                {
                    jornada.Alumnos.Add(alumno); //Lo agrega a lista de alumnos de la clase...
                }
            }
            g.Jornadas.Add(jornada);

            return g;
        }

        /// <summary>
        /// Agrega a un alumno a la universidad solo si no esta inscripto.
        /// </summary>
        /// <param name="g">Universidad a la que inscribir.</param>
        /// <param name="a">Alumno a inscribir.</param>
        /// <returns>Devuelve la universidad con el nuevo alumno cargado. En el caso que el alumno ya estuviera inscripto devuelve AlumnoRepetidoException</returns>
        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (u != a) 
            {
                u.Alumnos.Add(a);
                return u;
            }
            else
            {
                throw new AlumnoRepetidoException();
            }
        }

        /// <summary>
        /// Agrega un profesor a la universidad solo si no es parte de la misma.
        /// </summary>
        /// <param name="g">Universidad a la que agregar un profesor.</param>
        /// <param name="i">Profesor a agregar.</param>
        /// <returns>Devuelve la universidad con el nuevo profesor cargado. En el caso que el profesor ya este en la lista devuelve ProfesorRepetidoException</returns>
        public static Universidad operator +(Universidad u, Profesor i)
        {
            if(u != i)
            {
                u.Instructores.Add(i);
            }
            return u;
        }
        #endregion
    }
}
