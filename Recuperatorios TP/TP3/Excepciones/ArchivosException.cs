using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivosException : Exception
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="innerException">InnerException</param>
        public ArchivosException(Exception innerException) : base("Excepción de archivo.", innerException)
        {

        }           
    }
}