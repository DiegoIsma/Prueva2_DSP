﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2
{
    public partial class Form1 : Form
    {

        private double TasaIn;
        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rdbInteres3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbInteres3.Checked == true)
            {
                txtTasaInterEX.Enabled = true;
                txtTasaInterEX.Focus();
            }
            else
            {
                txtTasaInterEX.Text = "0";
                txtTasaInterEX.Enabled = false;
            }


        }

        private void rdbInteres1_CheckedChanged(object sender, EventArgs e)
        {
            TasaIn = 0.12;
        }

        private void rdbInteres2_CheckedChanged(object sender, EventArgs e)
        {
            TasaIn = 0.235;

        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            string NomEmpre;
            double MontoInic = 0, MontoFin = 0;
            int Tiempo;
            NomEmpre = txtEmpresa.Text;
            NomEmpre = NomEmpre.Trim();//Quita el espacio-blanco al inicio-final
            if (NomEmpre.Length == 0)
            {
                //si no hay caracteres en nombre empresa
                MessageBox.Show("Debe indicar Nombre de la empresa", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMonto.Focus(); //metodo que indica que control txtEmpresa recibira cursor
                return;//sale del procedimiento btnanalisis
            }
            if (!(IsNumeric(txtMonto.Text)))
            {
                MessageBox.Show("Valor Monto incorrecto", "ERROR", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                txtMonto.Focus(); //metodo que indica que control txtEmpresa recibira cursor
                return;
            }
            else
            {
                MontoInic = Convert.ToDouble(txtMonto.Text);
                if (!(MontoInic > 0))
                {
                    MessageBox.Show("Valor Monto no puede ser negativo", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMonto.Focus(); //metodo que indica que control txtEmpresa recibira cursor
                    return;
                }
            }
            Tiempo = Convert.ToInt32(txtTiempo.Text);
            //si selcciono Tasa interes 3, valida que sea correcta
            txtTasaInterEX.Text = txtTasaInterEX.Text.Trim();
            if (rdbInteres3.Checked == true)
            {
                if (txtTasaInterEX.Text.Length > 0)
                {
                    if (!(IsNumeric(txtTasaInterEX.Text) == true))
                    {
                        MessageBox.Show("Tasa interes incorrecto", "ERROR", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                        txtTasaInterEX.Text = "0";
                        txtTasaInterEX.Focus();
                        return;
                    }
                    else
                    {
                        TasaIn = Convert.ToDouble(txtTasaInterEX.Text) / 100;
                    }
                }
                else
                {
                    MessageBox.Show("Aun no ha indicado una tasa interes", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTasaInterEX.Focus();
                    return;
                }
            }
            //Hace el cálculo esperado
            MontoFin = (1 + TasaIn);
            MontoFin = MontoInic * (Math.Pow(Convert.ToDouble(MontoFin), Tiempo));
            TasaIn *= 100;
            //Muestra la respuesta (Monto a pagar)
            lstResul.Items.Clear();
            lstResul.Items.Add("Empresa: " + txtEmpresa.Text);
            lstResul.Items.Add("Monto: $" + MontoInic + ", Tasa anual: " + TasaIn);
            lstResul.Items.Add("Monto a pagar: $" + MontoFin);
        }
    }
}
