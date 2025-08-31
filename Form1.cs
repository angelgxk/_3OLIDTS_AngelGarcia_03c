using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3OLIDTS_AngelGarcia_03c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCelsius.Text != "" || txtFahrenhait.Text != "" || txtKevin.Text != "")
            {

                if (!string.IsNullOrEmpty(txtCelsius.Text))
                {
                    MessageBox.Show("Celsius");

                    float Ce = float.Parse(txtCelsius.Text);
                    float Fa = (Ce * 9.0f / 5.0f) + 32;
                    txtFahrenhait.Text = Fa.ToString();
                    float Ke = Ce + 273;

                    txtKevin.Text = Ke.ToString();
                }
                else if (!string.IsNullOrEmpty(txtFahrenhait.Text))
                {
                    MessageBox.Show("Fahrenhait");
                    float Fa = float.Parse(txtFahrenhait.Text);
                    float Ce = (Fa - 32) * 5.0f / 9.0f;
                    txtCelsius.Text = Ce.ToString();
                    float Ke = Ce + 273;
                    txtKevin.Text = Ke.ToString();
                }
                else if (!string.IsNullOrEmpty(txtKevin.Text))
                {
                    MessageBox.Show("Kelvin");
                    float Ke = float.Parse(txtKevin.Text);
                    float Ce = Ke - 273;
                    txtCelsius.Text = Ce.ToString();
                    float Fa = (Ce * 9.0f / 5.0f) + 32;
                    txtFahrenhait.Text = Fa.ToString();
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores en los TextBox para el calculo de temperatura");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCelsius.Text = "0.0";
            txtFahrenhait.Text = "0.0";
            txtKevin.Text = "0.0";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbTemperatura_Click(object sender, EventArgs e)
        {

        }

        private void lbCelsius_Click(object sender, EventArgs e)
        {

        }

        private void lbFahrenhait_Click(object sender, EventArgs e)
        {

        }

        private void lbKelvin_Click(object sender, EventArgs e)
        {

        }

        private void txtCelsius_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFahrenhait_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtKevin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}