using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
  class Local : Llamada
  {
    #region Atributos
    protected float costo;
    #endregion

    #region Propiedades
    public float CostoLlamada
    {
      get
      {
        return CalcularCosto();
      }
    }
    #endregion

    #region Constructores
    public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
    { }

    public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
    {
      this.costo = costo;
    }
    #endregion

    #region Metodos
    /// <summary>
    /// Calcula el costo de la llamada dependiendo de su duracion
    /// </summary>
    /// <returns>Retorna el costo de la llamada local</returns>
    private float CalcularCosto()
    {
      float valor;
      valor = this.Duracion * this.costo;
      return valor;
    }

    /// <summary>
    /// Muestra toda la informacion de la llamada local
    /// </summary>
    /// <returns></returns>
    public override string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("****LLAMADA LOCAL****");
      sb.AppendLine(base.Mostrar());
      sb.AppendFormat("\nCosto: {0}", this.CostoLlamada);

      return sb.ToString();
    }
    #endregion
  }
}
