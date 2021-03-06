﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
        public enum EEstado { Ingresado, EnViaje, Entregado}
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;

        public string DireccionEntrega
        {
            get { return this.direccionEntrega; }
            set { this.direccionEntrega = value; }
        }

        public EEstado Estado
        {
            get { return this.estado; }
            set { this.estado = value; }
        }

        public string TrackingID
        {
            get { return this.trackingID; }
            set { this.trackingID = value; }
        }

        public Paquete(string direccionEntrega, string trackingID)
        {
            this.trackingID = trackingID;
            this.direccionEntrega = direccionEntrega;
        }

        public void MockCicloDeVida()
        { }

        public string MostrarDatos(IMostrar<Paquete> elemento)
        { }

        public override string ToString()
        {
            
        }
    }
}
