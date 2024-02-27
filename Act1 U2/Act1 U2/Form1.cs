using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act1_U2
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            double numero = Convert.ToDouble(metroTextBox1.Text);

            switch (numero)
            {
                case 1:
                    metroLabel1.Text = "Lunes";
                    break;
                case 2:
                    metroLabel1.Text = "Martes";
                    break;
                case 3:
                    metroLabel1.Text = "Miercoles";
                    break;
                case 4:
                    metroLabel1.Text = "Jueves";
                    break;
                case 5:
                    metroLabel1.Text = "Viernes";
                    break;
                case 6:
                    metroLabel1.Text = "Sabado";
                    break;
                case 7:
                    metroLabel1.Text = "Domingo";
                    break;
                default:
                    metroLabel1.Text = "Numero no valido.";
                    break;



            }
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
