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
    { }
  }
}
