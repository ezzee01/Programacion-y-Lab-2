using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_28
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void rtxtPalabras_TextChanged(object sender, EventArgs e)
    {

    }

    private void btnCalcular_Click(object sender, EventArgs e)
    {
      //char delimitador = ' ';
      Dictionary<string, int> diccionario = new Dictionary<string, int>();
      string[] palabras = rtxtPalabras.Text.Split(' ');
      int maximo = 0;
      string mensaje = "";
      int auxiliar;
      SortedDictionary<string, int> diccionarioOrdenado = new SortedDictionary<string, int>();

      foreach (string palabra in palabras)
      {
        if (diccionario.ContainsKey(palabra))
        {
          diccionario[palabra] = diccionario[palabra] + 1;
        }
        else
        {
          diccionario.Add(palabra, 1);
        }
      }

      foreach (int valor in diccionario.Values)
      {
        if (maximo == 0)
        {
          maximo = valor;
        }
        else if (valor > maximo)
        {
          maximo = valor;
        }
      }

      foreach (KeyValuePair<string, int> item in diccionario.OrderByDescending(keyValuePair => keyValuePair.Value).Take(3))
      {
        mensaje = mensaje + item.Key + " = " + item.Value + "\n";
      }

      MessageBox.Show(mensaje);
    }
  }
}
