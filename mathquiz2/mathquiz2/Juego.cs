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
    public partial class Juego : Form
    {
        Random randomizer = new Random();

        public Juego()
        {
            InitializeComponent();
        }

        private void buttonComenzar_Click(object sender, EventArgs e)
        {
                int label1v = randomizer.Next(20);
                int label2v = randomizer.Next(20);
                int label3v = randomizer.Next(20);
                int label4v = randomizer.Next(100);
                int label5v = randomizer.Next(100);
                int label6v = randomizer.Next(100);
                int label7v = randomizer.Next(500);
                int label8v = randomizer.Next(500);
                int label9v = randomizer.Next(500);
                int label10v = randomizer.Next(1000);
                int label11v = randomizer.Next(1000);
                int label12v = randomizer.Next(1000);
                // enviarlos a los label
                label1.Text = label1v.ToString();
                label2.Text = label2v.ToString();
                label3.Text = label3v.ToString();
                label4.Text = label4v.ToString();
                label5.Text = label5v.ToString();
                label6.Text = label6v.ToString();
                label7.Text = label7v.ToString();
                label8.Text = label8v.ToString();
                label9.Text = label9v.ToString();
                label10.Text = label10v.ToString();
                label11.Text = label11v.ToString();
                label12.Text = label12v.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string n1 = label1.Text;
                int N1 = int.Parse(n1);
                string n2 = label2.Text;
                int N2 = int.Parse(n2);
                string n3 = label3.Text;
                int N3 = int.Parse(n3);

                string r2 = textResultado1.Text;
                int re2 = int.Parse(r2);

                if (re2 == N1 + N2 + N3)
                {
                    MessageBox.Show("¡El resultado es correcto!");

                }
                else
                {
                    MessageBox.Show("Ohh, tienes un error con tu respuesta",
                                     "Intentalo de nuevo con otra operación");
                }
            }
            catch
            {
                MessageBox.Show("No ingresaste los datos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string n4 = label4.Text;
                int N4 = int.Parse(n4);
                string n5 = label5.Text;
                int N5 = int.Parse(n5);
                string n6 = label6.Text;
                int N6 = int.Parse(n6);

                string r21 = textResultado2.Text;
                int re21 = int.Parse(r21);

                if (re21 == N4 + N5 + N6)
                {
                    MessageBox.Show("¡El resultado es correcto!");

                }
                else
                {
                    MessageBox.Show("Ohh, tienes un error con tu respuesta",
                                     "Intentalo de nuevo con otra operación");
                }
            }
            catch
            {
                MessageBox.Show("No ingresaste los datos");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string n7 = label7.Text;
                int N7 = int.Parse(n7);
                string n8 = label8.Text;
                int N8 = int.Parse(n8);
                string n9 = label9.Text;
                int N9 = int.Parse(n9);

                string r22 = textResultado3.Text;
                int re22 = int.Parse(r22);

                if (re22 == N7 + N8 + N9)
                {
                    MessageBox.Show("¡El resultado es correcto!");

                }
                else
                {
                    MessageBox.Show("Ohh, tienes un error con tu respuesta",
                                     "Intentalo de nuevo con otra operación");
                }
            }
            catch
            {
                MessageBox.Show("No ingresaste los datos ingresaste los datos");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string n10 = label10.Text;
                int N10 = int.Parse(n10);
                string n11 = label11.Text;
                int N11 = int.Parse(n11);
                string n12 = label12.Text;
                int N12 = int.Parse(n12);

                string r23 = textResultado4.Text;
                int re23 = int.Parse(r23);

                if (re23 == N10 + N11 + N12)
                {
                    MessageBox.Show("¡El resultado es correcto!");

                }
                else
                {
                    MessageBox.Show("Ohh, tienes un error con tu respuesta",
                                      "Intentalo de nuevo con otra operación");
                }
            }
            catch
            {
                MessageBox.Show("No ingresaste los datos ingresaste los datos");
            }


        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Juego_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
