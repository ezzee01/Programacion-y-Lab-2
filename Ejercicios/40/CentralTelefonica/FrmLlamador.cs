using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace CentralTelefonica
{
    public partial class FrmLlamador : Form
    {
        Centralita Centralita = new Centralita("");

        public FrmLlamador(Centralita centralita)
        {
            this.Centralita = centralita;
            InitializeComponent();
        }

        public Centralita MostrarCentralita
        {
            get
            {
                return this.Centralita;
            }
        }
    }
}
