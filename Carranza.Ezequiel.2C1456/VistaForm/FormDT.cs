using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class FormDT : Form
    {
        DirectorTecnico dt;

        public FormDT()
        {
            InitializeComponent();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            dt = new DirectorTecnico(textBoxNombre.Text, textBoxApellido.Text, int.Parse(numericUpDownEdad.TextAlign.ToString()),int.Parse(numericUpDownDni.TextAlign.ToString()), int.Parse((numericUpDownExperiencia.TextAlign.ToString())));

        }

        private void buttonValidar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
