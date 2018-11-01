using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_52
{
  class Lapiz : IAcciones
  {
    private float tamanioMina;

    public ConsoleColor Color
    {
      get
      {
        
      }
      set
      {
        this.Color = value;
      }
    }

    public float UnidadesDeEscritura
    {
      get { return this.tamanioMina; }
      set { this.tamanioMina = value; }
    }

    public Lapiz(int unidades)
    {
      this.
    }

    EscrituraWrapper IAcciones.Escribir(string texto)
    { }

    bool IAcciones.Recargar(int unidades)
    { }
  }
}
