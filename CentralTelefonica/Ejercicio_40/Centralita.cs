using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        #region Atributos
        private List<Llamada> listaDeLLamadas;
        protected string razonSocial;
        #endregion

        #region Propiedades
        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return listaDeLLamadas;
            }
        }
        #endregion

        #region Constructores
        public Centralita()
        {
            this.listaDeLLamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        #endregion

        #region Metodos
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float ganancia = 0;

            foreach (Llamada llamada in this.listaDeLLamadas)
            {
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if (llamada is Local)
                        {
                            ganancia = ganancia + ((Local)llamada).CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if (llamada is Provincial)
                        {
                            ganancia = ganancia + ((Provincial)llamada).CostoLlamada;
                        }
                        break;
                    case Llamada.TipoLlamada.Todas:
                        if (llamada is Local)
                        {
                            ganancia = ganancia + ((Local)llamada).CostoLlamada;
                        }
                        else if (llamada is Provincial)
                        {
                            ganancia = ganancia + ((Provincial)llamada).CostoLlamada;
                        }
                        break;
                }
            }
            return ganancia;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nRazon social: {0}", this.razonSocial);
            sb.AppendFormat("\nGanancia total: {0}", this.GananciasPorTotal);
            sb.AppendFormat("\nGanancia por provincial: {0}", this.GananciasPorProvincial);
            sb.AppendFormat("\nGanancia por local: {0}", this.GananciasPorLocal);
            sb.AppendLine("\n******LLAMADAS******");
            foreach (Llamada llamada in Llamadas)
            {
                sb.Append("\n---------------------------------------");
                sb.Append(llamada.ToString());
            }

            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLLamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }


        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.listaDeLLamadas.Add(nuevaLlamada);
        }

        #endregion

        #region Operadores
        public static bool operator ==(Centralita c, Llamada llamada)
        {
            bool valor = false;

            foreach (Llamada l1 in c.listaDeLLamadas)
            {
                if (l1 == llamada)
                {
                    valor = true;
                }
            }

            return valor;
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static Centralita operator +(Centralita c, Llamada nuevaLamada)
        {
            if (c != nuevaLamada)
            {
                c.AgregarLlamada(nuevaLamada);
            }

            return c;
        }
        #endregion
    }
}
