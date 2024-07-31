using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int[] numbers;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            numbers = new int[20];
            for(int i =0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(100);
            }

            listBoxNumbers.Items.Add(numbers);

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (numbers == null)
            {
                MessageBox.Show("Primero genera la lista de números.");
                return;
            }

            // Ordenar la lista utilizando el método de la burbuja
            BubbleSort(numbers);

            // Mostrar la lista ordenada en el ListBox
            listBoxNumbers.Items.Clear();
            foreach (int number in numbers)
            {
                listBoxNumbers.Items.Add(number);
            }
        }
        static void BubbleSort(int[] array)
        {
            int n = array.Length;
            bool swapped;
            do
            {
                swapped = false;
                for (int i = 0; i < n - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        // Intercambiar los elementos
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        swapped = true;
                    }
                }
                n--; // Optimización: No es necesario comparar hasta el final de la lista en cada pasada
            } while (swapped);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            listBoxNumbers.Items.Clear();
        }

        private void bntSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
