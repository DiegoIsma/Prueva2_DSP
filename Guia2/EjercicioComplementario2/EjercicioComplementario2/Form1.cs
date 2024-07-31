using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioComplementario2
{
    public partial class Form1 : Form
    {
        private List<double> numbers = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtNumber.Text, out double number))
            {
                numbers.Add(number);
                lstNumbers.Items.Add(number);

                if (numbers.Count == 4)
                {
                    CalculateStatistics();
                }

                lblMessage.Text = $"Número {number} agregado.";
            }
            else
            {
                lblMessage.Text = "Por favor, ingrese un número válido.";
            }

            txtNumber.Clear();
            txtNumber.Focus();
        }
        private void CalculateStatistics()
        {
            double mean = numbers.Average();
            double variance = numbers.Sum(num => Math.Pow(num - mean, 2)) / numbers.Count;
            double standardDeviation = Math.Sqrt(variance);

            lblResult.Text = $"Promedio: {mean}\nDesviación Típica: {standardDeviation}";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
