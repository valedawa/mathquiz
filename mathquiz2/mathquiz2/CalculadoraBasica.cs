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
    public partial class CalculadoraBasica : Form
    {
        public CalculadoraBasica()
        {
            InitializeComponent();
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            try
            {
                string v1 = textBoxv1.Text;
                int V1 = int.Parse(v1);

                string v2 = textBoxv2.Text;
                int V2 = int.Parse(v2);

                int resultado = V1 + V2;
                textBoxResultado.Text = resultado.ToString();
            }
            catch
            {
                MessageBox.Show("Error verifique sus datos");
            }
            
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            try
            {
                string v1 = textBoxv1.Text;
                int V1 = int.Parse(v1);

                string v2 = textBoxv2.Text;
                int V2 = int.Parse(v2);

                int resultado = V1 - V2;
                textBoxResultado.Text = resultado.ToString();
            }
            catch
            {
                MessageBox.Show("Error verifique sus datos");
            }

        }

        private void buttonMultiplicacion_Click(object sender, EventArgs e)
        {
            try
            {
                string v1 = textBoxv1.Text;
                int V1 = int.Parse(v1);

                string v2 = textBoxv2.Text;
                int V2 = int.Parse(v2);

                int resultado = V1 / V2;
                textBoxResultado.Text = resultado.ToString();
            }
            catch
            {
                MessageBox.Show("Error verifique sus datos");
            }
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            try
            {

                string v1 = textBoxv1.Text;
                int V1 = int.Parse(v1);

                string v2 = textBoxv2.Text;
                int V2 = int.Parse(v2);

                int resultado = V1 * V2;
                textBoxResultado.Text = resultado.ToString();
            }
            catch
            {
                MessageBox.Show("Error verifique sus datos");
            }
        }
    }
}
