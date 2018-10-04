using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Posicion
    {
        Arquero, Defensor, Central, Delantero
    }
    public class Jugador : Persona
    {
        #region Atributos
        private float altura;
        private float peso;
        private Posicion posicion;
        #endregion

        #region Constructores
        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion):base(nombre,apellido,edad,dni)
        {
            this.peso = peso;
            this.altura = altura;
            this.posicion = posicion;
        }
        #endregion

        #region Propiedades
        public float Altura
        {
            get
            {
                return this.altura;
            }
        }

        public float Peso
        {
            get
            {
                return this.peso;
            }
        }

        public Posicion Posicion
        {
            get
            {
                return this.posicion;
            }
        }

        #endregion

        #region Metodos
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.Mostrar());
            sb.AppendFormat("Altura {0}\n", this.altura);
            sb.AppendFormat("Peso {0}\n", this.peso);
            sb.AppendFormat("Posicion {0}\n", this.posicion);
            return sb.ToString();
        }

        public override bool ValidarAptitud()
        {
            bool retorno = false;
            if(this.Edad <= 40 && ValidarEstadoFisico() == true)
            {
                retorno = true;
            }
            return retorno;
        }

        public bool ValidarEstadoFisico()
        {
            bool retorno = false;
            float IMC = this.peso / (float)Math.Pow(this.altura, 2);

            if (IMC >= 18.5 || IMC <= 25.00)
            {
                retorno = true;
            }
            return retorno;
        }
        #endregion
    }
}
