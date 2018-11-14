using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_50
{
    class Serializar<S,V> : IGuardar<S,V>
    {
    public bool Guardar(S obj)
    {
      return true;
    }

    public V Leer()
    {
      string valor = "Objeto Leido";
      V retorno = (V)Convert.ChangeType(valor, typeof(V));
      return retorno;
    }
    }
}
