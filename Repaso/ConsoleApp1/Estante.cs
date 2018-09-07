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

    private Estante (int capacidad)
    {
      this.productos = new Producto[capacidad];
    }

    public Estante(int capacidad, int ubicacion) : this(capacidad)
    {
      this.ubicacionEstante = ubicacion;
    }

    public Producto[] GetProductos()
    {
      return productos;
    }

    public static string MostrarEstante(Estante e)
    {
      return "Ubicacion de estante: " + e.ubicacionEstante + Producto.MostrarProducto(e.productos[e.ubicacionEstante]);
    }

    public static bool operator !=(Estante e, Producto p)
    {
      return !(e.productos[e.ubicacionEstante] == p);
    }

    public static bool operator == (Estante e,Producto p)
    {
      if (e.productos[e.ubicacionEstante] == p)
      {
        return true;
      }
      else return false;
    }

    public static Estante operator -(Estante e, Producto p)
    {
      if (e == p)
      {
        e.productos[e.ubicacionEstante] = null;
        return e;
      }
      else return e;
    }

    public static bool operator +(Estante e,Producto p)
    {
      if (e != p)
      {
        e.productos[e.ubicacionEstante] = p;
        return true;
      }
      else return false;
    }
  }
}
