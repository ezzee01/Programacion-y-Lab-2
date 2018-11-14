using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_50
{
  class GuardarTexto<T, V> : IGuardar<T,V>
  {
    public bool Guardar(T obj)
    {
      return true;
    }
    public V Leer()
    {
      string valor = "Texto Leido";
      
      V retorno = (V) Convert.ChangeType(valor, typeof(V));

      return retorno;
    }

  }
}
