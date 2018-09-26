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
        return CalcularGanancia(TipoLlamada.Local);
      }
    }

    public float GananciasPorProvincial
    {
      get
      {
        return CalcularGanancia(TipoLlamada.Provincial);
      }
    }

    public float GananciasPorTotal
    {
      get
      {
        return CalcularGanancia(TipoLlamada.Todas);
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
      float valor;

      foreach(Llamada llamada in this.listaDeLLamadas)
      {

      }
    }

    public string Mostrar()
    { }

    public void OrdenarLlamadas()
    { }
  }
}
