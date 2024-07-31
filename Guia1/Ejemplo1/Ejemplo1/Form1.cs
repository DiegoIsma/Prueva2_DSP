using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

            string mesa = "aun no ha precionado botón contar ";

            label1.Text = mesa;
            int conta;

            //eventoo se ejecutara al iniciar ejecucion de from1
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            int conta = 0;
            // acumlador, total que presione boton 
            conta = conta + 1;
            // conta+=1: en forma de operador abreviado
            string mesa = "presiono boton contar, un total:" + Convert.ToString(conta) + " veces";
        }

        private void btnReinicio_Click(object sender, EventArgs e)
        {
            int conta = 0;
            // acumlador, total que presione boton 
            conta = conta + 1;
            // conta+=1: en forma de operador abreviado
            string mesa = "presiono boton  contar, una total:" + Convert.ToString(conta) + "veces:";
            label1.Text = mesa;
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Close();  // finaliza la aplicacion
        }
    }
}
