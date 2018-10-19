using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
  public class GuardarTexto<T, V>
  {
    public bool Guardar(T obj)
    {
      return true;
    }

    public V Leer()
    {
      string valor = "Texto leido";
      return (V) Convert.ChangeType(valor, typeof(V));
    }
  }
}
