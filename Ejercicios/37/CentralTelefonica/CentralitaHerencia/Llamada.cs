using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
  class Llamada
  {
    #region Atributos
    protected float duracion;
    protected string nroDestino;
    protected string nroOrigen;

    public enum TipoLlamada
    {
      Local,
      Provincial,
      Todas
    }
    #endregion

    #region Propiedades
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
    #endregion

    #region Constructores
    public Llamada(float duracion, string nroDestino, string nroOrigen)
    {
      this.duracion = duracion;
      this.nroDestino = nroDestino;
      this.nroOrigen = nroOrigen;
    }
    #endregion

    #region Metodos
    /// <summary>
    /// Muestra toda informacion de la llamada
    /// </summary>
    /// <returns></returns>
    public virtual string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("****LLAMADA****");
      sb.AppendFormat("\nDuracion: {0}", this.duracion);
      sb.AppendFormat("\nNro Destino: {0}", this.nroDestino);
      sb.AppendFormat("\nNro Origen: {0}", this.nroOrigen);

      return sb.ToString();
    }

    /// <summary>
    /// Orddena llamadas por duracion
    /// </summary>
    /// <param name="llamada1"></param>
    /// <param name="llamada2"></param>
    /// <returns>Retorna 1 si llamada1 es mayor a llamada2, -1 si llamada1 es menor a llamada2, 0 si son iguales</returns>
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
    #endregion
  }
}
