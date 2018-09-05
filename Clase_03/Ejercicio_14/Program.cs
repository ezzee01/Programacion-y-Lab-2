using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 14";

            char Respuesta = 'N';
            //CUADRADO
            int Opcion;
            double Lado;
            double AreaCuadrado;
            //TRIANGULO
            double Base;
            double Altura;
            double AreaTriangulo;
            //CIRCULO
            double Radio;
            double AreaCirculo;

            while (Respuesta == 'N')
            {
                Console.Clear();
                Console.WriteLine("Calculos de areas.");
                Console.WriteLine("1.Area de un cuadrado.");
                Console.WriteLine("2.Area de un triangulo.");
                Console.WriteLine("3.Area de un circulo.");
                Console.WriteLine("4.Salir.");


                Opcion = int.Parse(Console.ReadLine());

                switch (Opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ingrese lado: ");
                        Lado = double.Parse(Console.ReadLine());
                        AreaCuadrado = CalculoDeArea.CalcularCuadrado(Lado);
                        Console.WriteLine("El area es: {0}", AreaCuadrado);
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Ingrese base: ");
                        Base = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese altura: ");
                        Altura = double.Parse(Console.ReadLine());
                        AreaTriangulo = CalculoDeArea.CalcularTriangulo(Base, Altura);
                        Console.WriteLine("El area es: {0}", AreaTriangulo);
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Ingrese radio: ");
                        Radio = double.Parse(Console.ReadLine());
                        AreaCirculo = CalculoDeArea.CalcularCirculo(Radio);
                        Console.WriteLine("El area es: {0}", AreaCirculo);
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("¿Desea salir?S/N");
                        Respuesta = char.ToUpper(char.Parse(Console.ReadLine()));
                        break;
                }
                Console.ReadKey();
            }
         }
    }
}
