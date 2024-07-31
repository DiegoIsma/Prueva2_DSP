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
        public Form1()
        {
            InitializeComponent();
            InitializeComboBoxes();
        }

        private void InitializeComboBoxes()
        {
            // agregamos los meses
            cbMes.Items.AddRange(new string[] {
                "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
                "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"
            });

            // agregamos los dias 
            for (int i = 1; i <= 31; i++)
            {
                cbDia.Items.Add(i);
            }

            for (int i = 1900; i <= DateTime.Now.Year; i++)
            {
                cbYear.Items.Add(i);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (cbMes.SelectedIndex == -1 || cbDia.SelectedIndex == -1 || cbYear.SelectedIndex == -1)
            {
                lblResult.Text = "Por favor, seleccione Mes, Día y Año.";
                return;
            }

            int month = cbMes.SelectedIndex + 1;
            int day = (int)cbDia.SelectedItem;
            int year = (int)cbYear.SelectedItem;

            if (IsValidDate(day, month, year))
            {
                lblResult.Text = $"Fecha válida: {cbMes.SelectedItem} {day}, {year}";
            }
            else
            {
                lblResult.Text = "Fecha inválida.";
            }
        }

        private bool IsValidDate(int day, int month, int year)
        {
            switch (month)
            {
                case 2:
                    if (IsLeapYear(year))
                    {
                        return day <= 29;
                    }
                    else
                    {
                        return day <= 28;
                    }
                case 4:
                case 6:
                case 9:
                case 11:
                    return day <= 30;
                default:
                    return day <= 31;
            }
        }

        private bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
 }

