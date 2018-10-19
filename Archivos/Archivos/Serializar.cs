using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
  class Serializar <S,V>
  {
    public bool Guardar(S obj)
    { }

    public V Leer()
    {
      string valor = "Objeto leido";
      return (V)Convert.ChangeType(valor, typeof(V));
    }
  }
}
