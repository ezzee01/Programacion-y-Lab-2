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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        { }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        { }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        { }
        
        private void lblResultado_Click(object sender, EventArgs e)
        { }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            double resultado = Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.Text);
            lblResultado.Text = resultado.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string resultado = lblResultado.Text;
            Numero numero = new Numero(resultado);

            lblResultado.Text = numero.DecimalBinario(resultado);
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string resultado = lblResultado.Text;
            Numero numero = new Numero(resultado);            
            lblResultado.Text = numero.BinarioDecimal(resultado);
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);

            return Calculadora.Operar(num1, num2, operador);
        }

        private void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            lblResultado.ResetText();
            cmbOperador.ResetText();
        }
    }
}
