using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_16
{
    class Alumno
    {
        private byte _nota1;
        private byte _nota2;
        private float _notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        //CONSTRUCTOR
        //public Alumno(int leg, string apell, string nomb)
        //{
        //    this.legajo = leg;
        //    this.apellido = apell;
        //    this.nombre = nomb;
        //}

        public void CalcularFinal()
        {
            if (_nota1 >= 4 && _nota2 >= 4)
            {
                Thread.Sleep(150);
                Random notaFinal = new Random();
                this._notaFinal = notaFinal.Next();
            }
            else this._notaFinal = -1;
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;
        }

        public void Mostrar()
        {
            if (_notaFinal != -1)
            {
                Console.WriteLine("{0}{1}{2}{3}{5}", legajo, nombre, apellido, _nota1, _nota2, _notaFinal);
            }
            else Console.WriteLine("{0}{1}{2}{3}{5} Alumno desaprobado.", legajo, nombre, apellido, _nota1, _nota2);
        }
    }
}
