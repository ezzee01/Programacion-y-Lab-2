using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        #region ATributos
        private int añosExperiencia;
        #endregion

        #region Cosntructores
        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia):base(nombre,apellido,edad,dni)
        {
            this.añosExperiencia = añosExperiencia;
        }
        #endregion

        #region Propiedades
        public int AñosExperiencia
        {
            get
            {
                return this.añosExperiencia;
            }
            set
            {
                this.añosExperiencia = value;
            }
        }
        #endregion

        #region Metodos
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("Años de experiencia: {0}\n", this.añosExperiencia);

            return sb.ToString();
        }

        public override bool ValidarAptitud()
        {
            bool retorno = false;
            if(this.añosExperiencia >= 2 && Edad < 65)
            {
                retorno = true;
            }
            return retorno;
        }
        #endregion
    }
}
