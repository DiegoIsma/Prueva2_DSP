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
        // Listas para almacenar números positivos y negativos, y un contador para ceros
        private List<int> positiveNumbers = new List<int>();
        private List<int> negativeNumbers = new List<int>();
        private int zeroCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddNumber_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumber.Text, out int number))
            {
                // Verificar si el número está en el rango permitido
                if (number < -40 || number > 45)
                {
                    lblMessage.Text = "Por favor, ingrese un número en el rango de -40 a 45.";
                    return;
                }

                // Clasificar el número como positivo, negativo o cero y agregarlo a la lista correspondiente
                if (number > 0)
                {
                    positiveNumbers.Add(number);
                }
                else if (number < 0)
                {
                    negativeNumbers.Add(number);
                }
                else
                {
                    zeroCount++;
                }

                // Actualizar las estadísticas después de agregar el nuevo número
                UpdateStatistics();
                lblMessage.Text = $"Número {number} agregado.";
            }
            else
            {
                lblMessage.Text = "Por favor, ingrese un número válido.";
            }

         
            txtNumber.Clear();
            txtNumber.Focus();
        }


        // Método para actualizar las estadísticas y mostrarlas en el formulario
        private void UpdateStatistics()
        {
            int totalCount = positiveNumbers.Count + negativeNumbers.Count + zeroCount;

            // Calcular el mayor número negativo
            int maxNegative = negativeNumbers.Count > 0 ? negativeNumbers.Max() : int.MinValue;


            // Calcular el promedio de los números negativos
            double averageNegative = negativeNumbers.Count > 0 ? negativeNumbers.Average() : 0;


          
            double positivePercentage = totalCount > 0 ? (double)positiveNumbers.Count / totalCount * 100 : 0;
            double negativePercentage = totalCount > 0 ? (double)negativeNumbers.Count / totalCount * 100 : 0;
            double zeroPercentage = totalCount > 0 ? (double)zeroCount / totalCount * 100 : 0;

            // Mostrar las estadísticas en la etiqueta
            lblStatistics.Text = $"Mayor número negativo: {(maxNegative == int.MinValue ? "N/A" : maxNegative.ToString())}\n" +
                                $"Cantidad de positivos: {positiveNumbers.Count}\n" +
                                $"Promedio de negativos: {averageNegative:F2}\n" +
                                $"Porcentaje de positivos: {positivePercentage:F2}%\n" +
                                $"Porcentaje de negativos: {negativePercentage:F2}%\n" +
                                $"Porcentaje de ceros: {zeroPercentage:F2}%";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
