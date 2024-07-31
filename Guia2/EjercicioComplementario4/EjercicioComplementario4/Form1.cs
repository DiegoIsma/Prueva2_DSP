using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioComplementario4
{
    public partial class Form1 : Form
    {
        // Diccionario con las tasas de cambio ficticias. En una aplicación real, estas tasas se obtendrían de una fuente actualizada.
        private readonly Dictionary<string, Dictionary<string, double>> exchangeRates = new Dictionary<string, Dictionary<string, double>>()
        {
            {"USD", new Dictionary<string, double>{{"USD", 1}, {"EUR", 0.85}, {"JPY", 110}, {"GBP", 0.75}, {"CHF", 0.91}}},
            {"EUR", new Dictionary<string, double>{{"USD", 1.18}, {"EUR", 1}, {"JPY", 129}, {"GBP", 0.88}, {"CHF", 1.07}}},
            {"JPY", new Dictionary<string, double>{{"USD", 0.0091}, {"EUR", 0.0078}, {"JPY", 1}, {"GBP", 0.0068}, {"CHF", 0.0083}}},
            {"GBP", new Dictionary<string, double>{{"USD", 1.33}, {"EUR", 1.14}, {"JPY", 147}, {"GBP", 1}, {"CHF", 1.21}}},
            {"CHF", new Dictionary<string, double>{{"USD", 1.1}, {"EUR", 0.94}, {"JPY", 120}, {"GBP", 0.83}, {"CHF", 1}}}
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                double cantidad = double.Parse(txtCantidad.Text);
                string monedaOrigen = cmbMonedaOrigen.SelectedItem.ToString();
                string monedaDestino = cmbMonedaDestino.SelectedItem.ToString();

                double cantidadConvertida = cantidad * exchangeRates[monedaOrigen][monedaDestino];
                lblResultado.Text = $"{cantidad} {monedaOrigen} = {cantidadConvertida:F2} {monedaDestino}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
