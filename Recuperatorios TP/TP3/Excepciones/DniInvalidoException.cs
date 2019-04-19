﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {
        private static string mensajeBase;

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        static DniInvalidoException()
        {
            mensajeBase = "DNI invalido.";
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="e">InnerException</param>
        public DniInvalidoException(Exception e) : this(mensajeBase,e)
        {

        }

        /// <summary>
        /// Constructor permite setear un mensaje.
        /// </summary>
        /// <param name="message">Mensaje de la excepción.</param>
        public DniInvalidoException(string message) :this(message, null)
        {
        }        

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="message">Mensaje de la excepción.</param>
        /// <param name="e">InnerException</param>
        public DniInvalidoException(string message, Exception e):base(message,e)
        {

        }
    }
}
