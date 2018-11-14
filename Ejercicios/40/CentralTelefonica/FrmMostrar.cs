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
    public partial class FrmMostrar : Form
    {
        Centralita Centralita = new Centralita("");

        public FrmMostrar(Centralita centralita)
        {
            this.Centralita = centralita;
            InitializeComponent();
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {

        }
    }
}
