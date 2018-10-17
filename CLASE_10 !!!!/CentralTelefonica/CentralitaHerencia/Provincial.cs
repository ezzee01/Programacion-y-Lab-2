using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
  class Provincial : Llamada
  {
    #region Atributos
    public enum Franja
    {
      Franja_1,
      Franja_2,
      Franja_3
    }

    protected Franja franjaHoraria;
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
    public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
    { }

    public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
    {
      this.franjaHoraria = miFranja;
    }
    #endregion

    #region Metodos
    private float CalcularCosto()
    {
      float costo = 0;
      float retorno;

      switch(this.franjaHoraria)
      {
        case Franja.Franja_1: costo = (float)0.99;
          break;
        case Franja.Franja_2: costo = (float)1.25;
          break;
        case Franja.Franja_3: costo = (float)0.66;
          break;
      }
      retorno = costo * this.Duracion;
      return retorno;
    }

    public override string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine(base.Mostrar());
      sb.AppendFormat("\nFranja Horaria: {0}", this.franjaHoraria);
      sb.AppendFormat("\nCosto: {0}", this.CostoLlamada);

      return sb.ToString();
    }
    #endregion
  }
}
