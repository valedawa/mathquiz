using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mathquiz2
{
    public partial class CalculadoraDePotencias : Form
    {
        public CalculadoraDePotencias()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string potencia1 = textBox1.Text;
                long Potencia1 = long.Parse(potencia1);

                string valor1 = textBox2.Text;
                long Valor1 = long.Parse(valor1);

                double potencia = Math.Pow(Valor1, Potencia1);

                textBox3.Text = potencia.ToString();
            }
            catch
            {
                MessageBox.Show("Ingresa tus datos");
            }
        }
    }
}
