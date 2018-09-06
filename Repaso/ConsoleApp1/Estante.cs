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
    { }

    public static bool operator == (Estante e,Producto p)
    { }

    public static Estante operator -(Estante e, Producto p)
    { }

    public static bool operator +(Estante e,Producto p)
    { }
  }
}
