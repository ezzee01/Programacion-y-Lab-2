using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 08";

            float valorHora;
            string nombre;
            int antiguedad;
            float horasTrabajadas;
            char respuesta = 'S';
            float importeACobrar;
            float importeCobrado;
            float descuentos;

            while(respuesta != 'N')
            {
                Console.WriteLine("Ingrese nombre: ");
                nombre = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Ingrese antiguedad: ");
                antiguedad = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Ingrese valor por hora trabajada: ");
                valorHora = float.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Ingrese cantidad de horas trabajadas en el mes: ");
                horasTrabajadas = float.Parse(Console.ReadLine());
                Console.Clear();

                importeACobrar = (float) (valorHora * horasTrabajadas) + (antiguedad * 150);
                descuentos = (float) importeACobrar * 13 / 100;
                importeCobrado = importeACobrar - descuentos;

                Console.WriteLine("Nombre-----Antiguedad-----Valor Hora-----Total Bruto-----Desc-----Total Neto");
                Console.WriteLine("{0}     {1}              {2}             {3}      {4}     {5}", nombre, antiguedad, valorHora, importeACobrar, descuentos, importeCobrado);

                Console.WriteLine("\nDesea seguir ingresando? (S/N)");
                respuesta = char.ToUpper(char.Parse(Console.ReadLine()));
                Console.Clear();
            }
                                 
            Console.ReadKey();
        }
    }
}
