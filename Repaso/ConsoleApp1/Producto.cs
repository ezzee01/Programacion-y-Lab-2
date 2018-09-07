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

    public string GetCodigo()
    {
      return this.codigoDeBarra;
    }

    public static string MostrarProducto(Producto p)
    {
      return "Marca: " + p.marca + "Precio: " + p.precio + "Codigo de barras: " + p.codigoDeBarra;
    }

    public static explicit operator string (Producto p)
    {
      Producto p1 = new Producto(p.marca,p.codigoDeBarra, p.precio);
      string cod = p1.codigoDeBarra;
      return cod;
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
      if ((string)p1 == (string)p2 && p1.marca == p2.marca)
      {
        return true;
      }
      else return false;
    }

  }
}
