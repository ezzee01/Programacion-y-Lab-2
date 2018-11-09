using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Temporizador
{
    public sealed class Temporizador
    {
    private Thread hilo;
    private int intervalo;

    public bool Activo
    {
      get
      {
        
      }
      set
      {
        
      }
    }

    public int Intervalo
    {
      get
      {
        return this.intervalo;
      }
      set
      {
        this.intervalo = value;
      }
    }

    private void Corriendo()
    {

    }
    }
}
