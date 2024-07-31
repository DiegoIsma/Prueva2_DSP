using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioComplementario1
{
    public partial class Form1 : Form
    {
        private List<decimal> numbers = new List<decimal>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtNumber.Text, out decimal number))
            {
                if (numbers.Count < 10)
                {
                    numbers.Add(number);
                    lblMessage.Text = $"Número {number} agregado. Total: {numbers.Count}/10";
                }
                else
                {
                    lblMessage.Text = "Ya se han ingresado 10 números.";
                }
            }
            else
            {
                lblMessage.Text = "Por favor, ingrese un número válido.";
            }

            txtNumber.Clear();
            txtNumber.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (numbers.Count < 10)
            {
                lblResult.Text = "Debe ingresar 10 números.";
                return;
            }

            string selectedOption = cbOption.SelectedItem?.ToString();

            if (selectedOption == "a")
            {
                var negativeNumbers = numbers.Where(n => n < 0).ToList();
                var positiveNumbers = numbers.Where(n => n > 0).ToList();

                if (negativeNumbers.Any() && positiveNumbers.Any())
                {
                    decimal minNegative = negativeNumbers.Min();
                    decimal maxNegative = negativeNumbers.Max();
                    decimal avgPositive = positiveNumbers.Average();

                    lblResult.Text = $"Menor negativo: {minNegative}\nMayor negativo: {maxNegative}\nPromedio positivos: {avgPositive}";
                }
                else
                {
                    lblResult.Text = "No hay suficientes números negativos y/o positivos para calcular.";
                }
            }
            else if (selectedOption == "b")
            {
                decimal mean = numbers.Average();
                lblResult.Text = $"Media de toda la serie: {mean}";
            }
            else
            {
                lblResult.Text = "Seleccione una opción válida.";
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
