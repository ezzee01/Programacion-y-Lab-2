using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 16";

            byte notaUno;
            byte notaDos;

            byte nota1;
            byte nota2;

            //CON CONSTRUCTOR
            //Alumno alumnoUno = new Alumno(001, "Perez ", "Juan");
            //Alumno alumnoDos = new Alumno(002, "Gomez ", "Pedro");
            //Alumno alumnoTres = new Alumno(003, "Lopez ", "Damian");

            Alumno alumnoUno = new Alumno();
            Alumno alumnoDos = new Alumno();
            Alumno alumnoTres = new Alumno();

            alumnoUno.nombre = "Juan";
            alumnoUno.apellido = "Perez ";
            alumnoUno.legajo = 101;

            alumnoDos.nombre = "Pedro";
            alumnoDos.apellido = "Gomez ";
            alumnoDos.legajo = 102;

            alumnoTres.nombre = "Damian";
            alumnoTres.apellido = "Lopez ";
            alumnoTres.legajo = 103;

            Console.WriteLine("Ingrese primer nota de {0}{1}", alumnoUno.apellido, alumnoUno.nombre);
            notaUno = byte.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segunda nota de {0}{1}", alumnoUno.apellido, alumnoUno.nombre);
            notaDos = byte.Parse(Console.ReadLine());
            alumnoUno.Estudiar(notaUno, notaDos);

            Console.WriteLine("Ingrese primer nota de {0}{1}", alumnoDos.apellido, alumnoDos.nombre);
            nota1 = byte.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segunda nota de {0}{1}", alumnoDos.apellido, alumnoDos.nombre);
            nota2 = byte.Parse(Console.ReadLine());
            alumnoDos.Estudiar(nota1, nota2);

            Console.WriteLine("Ingrese primer nota de {0}{1}", alumnoTres.apellido, alumnoTres.nombre);
            notaUno = byte.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segunda nota de {0}{1}", alumnoTres.apellido, alumnoTres.nombre);
            notaDos = byte.Parse(Console.ReadLine());
            alumnoTres.Estudiar(notaUno, notaDos);

            Console.WriteLine("Lista de alumnos.");
            Console.WriteLine("Legajo-----Apellido-----Nombre-----Primera Nota-----Segunda Nota-----Nota Final");
            alumnoUno.Mostrar();
            alumnoDos.Mostrar();
            alumnoTres.Mostrar();

            Console.ReadKey();
        }
    }
}
