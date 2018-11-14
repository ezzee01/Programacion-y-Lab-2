using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;

        public List<Paquete> Paquetes
        {
            get { return this.paquetes; }
            set { this.paquetes = value; }
        }

        public Correo()
        {
            this.mockPaquetes = new List<Thread>();
            this.paquetes = new List<Paquete>();
        }

        //FinEntregas cerrará todos los hilos activos.
        public void FinEntregas()
        { }

        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            string datos = "";
            //foreach (Paquete p in this.Paquetes)
            //{
            //    datos = string.Format("{0} para {1} ({2})", p.TrackingID, p.DireccionEntrega, p.Estado.ToString());
            //}

            return datos;
        }

        //Falta . Crear un hilo para el método MockCicloDeVida del paquete, y agregar dicho hilo a mockPaquetes. y ejecutarlo
        public static Correo operator +(Correo c, Paquete p) 
        {
            foreach (Paquete paq in c.Paquetes)
            {
                if(paq != p)
                {
                    c.paquetes.Add(p);
                }
                else throw new TrackingIdRepetidoException("El paquete ya existe");
            }
            return c;
        }
    }
}
