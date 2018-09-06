using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  class Producto
  {
    protected string codigoDeBarra;
    protected string marca;
    protected float precio;

    public Producto(string marca, string codigo, float precio)
    {
      this.marca = marca;
      this.codigoDeBarra = codigo;
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
      return "Marca: " + p.marca + "Precio: " + p.precio + "Codigo de barras: " + p.codigoDeBarra;
    }

    public static explicit operator string (Producto p)
    {
      return p.codigoDeBarra;
    }

    public static bool operator != (Producto p, string marca)
    {
      return !(p == marca);
    }

    public static bool operator !=(Producto p1, Producto p2)
    {
      return !(p1 == p2);
    }

    public static bool operator ==(Producto p, string marca)
    {
      if (p.marca == marca)
      {
        return true;
      }
      else return false;
    }

    public static bool operator ==(Producto p1, Producto p2)
    {
      if (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
      {
        return true;
      }
      else return false;
    }

  }
}
