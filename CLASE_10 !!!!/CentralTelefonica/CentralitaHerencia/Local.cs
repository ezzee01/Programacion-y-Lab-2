using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
  class Local : Llamada
  {
    protected float costo;

    public float CostoLlamada
    {
      get
      {
        return CalcularCosto();
      }
    }

    public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
    { }

    public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
    {
      this.costo = costo;
    }

    private float CalcularCosto()
    {
      float valor;
      valor = this.Duracion * this.costo;
      return valor;
    }

    public string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendFormat("\nDuracion: {0}", this.Duracion);
      sb.AppendFormat("\nNumero Destino: {0}", this.NroDestino);
      sb.AppendFormat("\nNumero Origen: {0}", this.NroOrigen);
      sb.AppendFormat("\nCosto: {0}", this.CostoLlamada);

      return sb.ToString();
    }
  }
}
