using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
  class Llamada
  {
    protected float duracion;
    protected string nroDestino;
    protected string nroOrigen;

    public enum TipoLlamada
    {
      Local,
      Provincial,
      Todas
    }

    public float Duracion
    {
      get
      {
        return this.duracion;
      }
    }

    public string NroDestino
    {
      get
      {
        return this.nroDestino;
      }
    }

    public string NroOrigen
    {
      get
      {
        return this.nroOrigen;
      }
    }

    public Llamada(float duracion, string nroDestino, string nroOrigen)
    {
      this.duracion = duracion;
      this.nroDestino = nroDestino;
      this.nroOrigen = nroOrigen;
    }

    public string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendFormat("\nDuracion: {0}", this.duracion);
      sb.AppendFormat("\nNro Destino: {0}", this.nroDestino);
      sb.AppendFormat("\nNro Origen: {0}", this.nroOrigen);

      return sb.ToString();
    }

    public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
    {
      int retorno = 0;

      if(llamada1.duracion > llamada2.duracion)
      {
        retorno = 1;
      }
      else if(llamada1.duracion < llamada2.duracion)
      {
        retorno = -1;
      }
      return retorno;
    }
  }
}
