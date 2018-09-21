using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        protected Franja franjaHoraria;

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        public Provincial(Franja miFranja, Llamada llamada):this (llamada.NroOrigen,miFranja,llamada.Duracion,llamada.NroDestino)
        { }

        public Provincial(string origen, Franja miFranja, float duracion, string destino):base (duracion,destino,origen)
        {
            this.franjaHoraria = miFranja;
        }

        private float CalcularCosto()
        {

        }

        public string Mostrar()
        { }


    }
}
