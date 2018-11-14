using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_04
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio Nro 04";

            int suma=0;
            int contador = 1;
            
            for(; ; )
            {
                contador++;

                for(int i=1; i<contador; i++)
                {
                    if(contador%i == 0)
                    {
                        suma += i;
                    }                    
                }
                if (suma == contador)
                {
                    Console.WriteLine("{0} es numero perfecto", contador);                    
                }
                suma = 0;
            }

      //Console.ReadKey();
    }
  }
}
