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
    public partial class CalculadoraDeRaices : Form
    {
        public CalculadoraDeRaices()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            string v1 = textBoxvalor.Text;
            double V1 = double.Parse(v1);

            double resultado = Math.Sqrt(V1);

            textBoxResultado.Text = resultado.ToString();
        }
    }
}
