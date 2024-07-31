using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioComplementario3
{
    public partial class Form1 : Form
    {
        private List<decimal> positiveNumbers = new List<decimal>();
        private List<decimal> negativeNumbers = new List<decimal>();
        private int numberCount = 0;
        private const int MaxNumbers = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            if (numberCount >= MaxNumbers)
            {
                lblMessage.Text = "Ya se han ingresado 10 números.";
                return;
            }

            if (decimal.TryParse(txtNumber.Text, out decimal number))
            {
                if (number >= 0)
                {
                    positiveNumbers.Add(number);
                    lstPositiveNumbers.Items.Add(number);
                }
                else
                {
                    negativeNumbers.Add(number);
                    lstNegativeNumbers.Items.Add(number);
                }

                numberCount++;
                lblMessage.Text = $"Número {number} agregado. Total: {numberCount}/{MaxNumbers}";
            }
            else
            {
                lblMessage.Text = "Por favor, ingrese un número válido.";
            }

            txtNumber.Clear();
            txtNumber.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (numberCount < MaxNumbers)
            {
                lblResult.Text = "Debe ingresar 10 números.";
                return;
            }

            decimal? minNegative = negativeNumbers.Count > 0 ? negativeNumbers.Min() : (decimal?)null;
            decimal avgPositive = positiveNumbers.Count > 0 ? positiveNumbers.Average() : 0;

            lblResult.Text = $"Menor negativo: {(minNegative.HasValue ? minNegative.Value.ToString() : "N/A")}\n" +
                             $"Promedio positivos: {(positiveNumbers.Count > 0 ? avgPositive.ToString() : "N/A")}";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

