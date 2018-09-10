using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.codigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("Marca {0}", p.marca));
            sb.AppendLine(String.Format("Código de Barra {0}", p.codigoDeBarra));
            sb.AppendLine(String.Format("Precio {0}", p.precio));
            return sb.ToString();
        }

        public static explicit operator string (Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator == (Producto p1, Producto p2)
        {
            if (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
            {
                return true;
            }
            else return false;
        }
        public static bool operator !=(Producto p1,Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator == (Producto p, string marca)
        {
            if (p.marca == marca)
            {
                return true;
            }
            else return false;
        }
        public static bool operator !=(Producto p,string marca)
        {
            return !(p == marca);
        }
    }
}
