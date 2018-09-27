using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
  class Centralita
  {
    private List<Llamada> listaDeLLamadas;
    protected string razonSocial;

    public float GananciasPorLocal
    {
      get
      {
        return CalcularGanancia(Llamada.TipoLlamada.Local);
      }
    }

    public float GananciasPorProvincial
    {
      get
      {
        return CalcularGanancia(Llamada.TipoLlamada.Provincial);
      }
    }

    public float GananciasPorTotal
    {
      get
      {
        return CalcularGanancia(Llamada.TipoLlamada.Todas);
      }
    }

    public List<Llamada> Llamadas
    {
      get
      {
        return listaDeLLamadas;
      }
    }

    public Centralita()
    {
      this.listaDeLLamadas = new List<Llamada>();
    }

    public Centralita(string nombreEmpresa) : this()
    {
      this.razonSocial = nombreEmpresa;
    }

    private float CalcularGanancia(Llamada.TipoLlamada tipo)
    {
      float ganancia = 0;

      foreach(Llamada llamada in this.listaDeLLamadas)
      {
        switch(tipo)
        {
          case Llamada.TipoLlamada.Local:
            if (llamada is Local)
            {
              ganancia = ganancia + ((Local)llamada).CostoLlamada;
            }
            break;
          case Llamada.TipoLlamada.Provincial:
            if (llamada is Provincial)
            {
              ganancia = ganancia + ((Provincial)llamada).CostoLlamada;
            }
            break;
          case Llamada.TipoLlamada.Todas:
            if (llamada is Local)
            {
              ganancia = ganancia + ((Local)llamada).CostoLlamada;
            }
            else if(llamada is Provincial)
            {
              ganancia = ganancia + ((Provincial)llamada).CostoLlamada;
            }
            break;
        }
      }
      return ganancia;
    }

    public string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendFormat("\nRazon social: ", this.razonSocial);
      sb.AppendFormat("\n")
    }

    public void OrdenarLlamadas()
    { }
  }
}
