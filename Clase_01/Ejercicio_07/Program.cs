using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 07";

            DateTime date;
            int año;
            int dias = 0;
            int diasNw = 0;
            long diasVividos;
            int contadorBic = 0;
            int contador = 0;

            Console.WriteLine("Ingrese fecha de nacimiento (aa/bb/cccc): ");

            date = DateTime.Parse(Console.ReadLine());
            año = date.Year;

            for(int i = año+1; i<= DateTime.Now.Year; i++) 
            {
                if (i % 4 == 0 && i % 100 != 0 || i % 100 == 0 && i % 400 == 0)
                {
                    contadorBic++;
                }
                else contador++;
            }

            for (int i = date.Month; i <= 12; i++)
            {
                switch(i)
                {
                    case 01: dias += 31;
                        break;
                    case 02:
                        if (año % 4 == 0 && año % 100 != 0 || año % 100 == 0 && año % 400 == 0)
                        {
                            dias += 29;
                        }
                        else dias += 28;
                        break;
                    case 03: dias += 31;
                        break;
                    case 04: dias += 30;
                        break;
                    case 05: dias += 31;
                        break;
                    case 06: dias += 30;
                        break;
                    case 07: dias += 31;
                        break;
                    case 08: dias += 31;
                        break;
                    case 09: dias += 30;
                        break;
                    case 10: dias += 31;
                        break;
                    case 11: dias += 30;
                        break;
                    case 12: dias += 31;
                        break;
                }
            }

            for (int i = DateTime.Now.Month; i <= 12; i++)
            {
                switch (i)
                {
                    case 01:
                        diasNw += 31;
                        break;
                    case 02:
                        if (año % 4 == 0 && año % 100 != 0 || año % 100 == 0 && año % 400 == 0)
                        {
                            diasNw += 29;
                        }
                        else diasNw += 28;
                        break;
                    case 03:
                        diasNw += 31;
                        break;
                    case 04:
                        diasNw += 30;
                        break;
                    case 05:
                        diasNw += 31;   
                        break;
                    case 06:
                        diasNw += 30;
                        break;
                    case 07:
                        diasNw += 31;
                        break;
                    case 08:
                        diasNw += 31;
                        break;
                    case 09:
                        diasNw += 30;
                        break;
                    case 10:
                        diasNw += 31;
                        break;
                    case 11:
                        diasNw += 30;
                        break;
                    case 12:
                        diasNw += 31;
                        break;
                }
            }

            diasVividos = (contador * 365) + (contadorBic * 366) + (dias - date.Day) - (diasNw - DateTime.Now.Day);

            Console.WriteLine("Tiene {0} dias vividos", diasVividos);

            Console.ReadKey();
        }
    }
}
