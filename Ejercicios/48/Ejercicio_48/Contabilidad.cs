using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_48
{
    public class Contabilidad<T,U> where U : Documento, new()  where T: Documento
    {
        private List<T> egresos;
        private List<U> ingresos;

        public Contabilidad()
        {
            egresos = new List<T>();
            ingresos = new List<U>();
        }

        public static Contabilidad<T,U> operator +(Contabilidad<T,U> C, T egreso)
        {
            C.egresos.Add(egreso);
            return C;
        }

        public static Contabilidad<T,U> operator +(Contabilidad<T,U> c, U ingreso)
        {
            c.ingresos.Add(ingreso);
            return c;
        }

    public string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("****Lista de egresos****");
      foreach(Documento d in this.egresos)
      {
        sb.AppendFormat(d.Mostrar());
      }
      sb.AppendLine("\n****Lista de ingresos****");
      foreach(Documento d in this.ingresos)
      {
        sb.AppendFormat(d.Mostrar());
      }
      return sb.ToString();
    }
    }
}
