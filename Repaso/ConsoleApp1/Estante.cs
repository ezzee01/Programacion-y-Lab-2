using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;
        //private int capacidad;

        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }
        public Estante (int capacidad, int ubicacion) : this (capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Ubicacion: "+ e.ubicacionEstante);
            foreach (Producto p in e.productos)
            {
                if (!(((Object)p) == null))
                {
                    sb.AppendLine(Producto.MostrarProducto(p));
                }
            }
            return sb.ToString();
        }

        public static bool operator == (Estante e, Producto p)
        {
            foreach (Producto prod in e.productos)
            {
                if(!object.ReferenceEquals(null, prod))
                {
                    if(p == prod)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator + (Estante e, Producto p)
        {
            if (e != p) 
            {
                for(int i = 0; i < e.productos.Length; i++) 
                {
                    if(object.ReferenceEquals(null, e.productos[i]))
                    {
                        e.productos[i] = p;
                        return true;
                    }
                }
            }
            return false;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            for(int i = 0; i < e.productos.Length; i++)
            {
                Producto prod = e.productos[i];
                if (!p.Equals(null))
                {
                    if (p == prod)
                    {
                        e.productos[i] = null;
                        break;
                    }
                }
            }
            return e;
        }
    }
}
