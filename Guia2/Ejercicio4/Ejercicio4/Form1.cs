using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class frmULAM : Form
    {
        public frmULAM()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Leer el número de términos desde el TextBox
            if (!int.TryParse(txtnumero.Text, out int numTerms) || numTerms <= 0)
            {
                MessageBox.Show("Ingrese un número entero positivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnumero.BackColor = Color.Red;
                return;
            }

            // Lista para almacenar la sucesión de Ulam
            List<int> ulamSequence = new List<int> { 1, 2 };

            // Agregar los dos primeros términos al ListBox
            lstLista.Items.Add(1);
            lstLista.Items.Add(2);

            // Inicializamos el contador de términos calculados
            int count = 2;

            while (count < numTerms)
            {
                int nextTerm = ulamSequence[ulamSequence.Count - 1] + 1;

                while (true)
                {
                    int numWays = 0;

                    for (int i = 0; i < ulamSequence.Count; i++)
                    {
                        for (int j = i + 1; j < ulamSequence.Count; j++)
                        {
                            if (ulamSequence[i] + ulamSequence[j] == nextTerm)
                            {
                                numWays++;
                            }
                        }
                    }

                    if (numWays == 1)
                    {
                        ulamSequence.Add(nextTerm);
                        lstLista.Items.Add(nextTerm); // Agregar el término al ListBox
                        count++;
                        break;
                    }
                    else
                    {
                        nextTerm++;
                    }
                }
            }
        }

        private void lstLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstLista.SelectedItem != null)
            {
                MessageBox.Show("Seleccionaste: " + lstLista.SelectedItem.ToString());
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstLista.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtnumero_TextChanged(object sender, EventArgs e)
        {
            txtnumero.BackColor = Color.White;
        }
    }
}
