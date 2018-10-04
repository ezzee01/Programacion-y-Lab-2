using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        #region Atributos
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;
        #endregion

        #region Constructores
        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(string nombre):this()
        {
            this.nombre = nombre;
        }
        #endregion

        #region Propiedades
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if(value.ValidarAptitud())
                {
                    this.directorTecnico = value;
                }                
            }
        }
        #endregion

        #region Metodos
        public static bool ValidarEquipo(Equipo e)
        {
            bool valor = false;
            int cont = 0;
            if(e.directorTecnico != null)
            {
                foreach(Jugador j in e.jugadores)
                {
                    switch(j.Posicion)
                    {
                        case Posicion.Arquero: cont++;
                            if(cont >1)
                            {
                                return valor;
                            }
                            else
                            {
                                valor = true;
                            }
                            break;
                        case Posicion.Central:  valor = true;
                            break;
                        case Posicion.Defensor:  valor = true;
                            break;
                        case Posicion.Delantero: valor = true;
                            break;
                    }

                }
            }
            return valor;
        }
        #endregion

        #region Operadores
        public static explicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre de equipo: {0}\n", e.nombre);
            if (e.directorTecnico != null)
            {
                sb.AppendLine( e.directorTecnico.Mostrar());
            }
            else sb.AppendLine("Sin DT asignado.");
            foreach(Jugador j in e.jugadores)
            {
                sb.AppendLine(j.Mostrar());
            }

            return sb.ToString();
        }

        public static bool operator ==(Equipo e, Jugador j)
        {
            bool valor = false;
            foreach(Jugador g in e.jugadores)
            {
                if(g == j)
                {
                    valor = true;
                    break;
                }
            }

            return valor;
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            foreach( Jugador g in e.jugadores)
            {
                if(g != j && e.jugadores.Count < 6 && j.ValidarAptitud() == true)
                {
                    e.jugadores.Add(j);
                }
            }
            return e;
        }
        #endregion
    }
}
