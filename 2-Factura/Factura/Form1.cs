using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Calcular();
        }

        private void Calcular()
        {
            double subtotal;
            double calculoImpuesto;
            double total;

            subtotal = Convert.ToDouble(textBox1.Text);
            calculoImpuesto = subtotal * 0.15;
            total = subtotal + calculoImpuesto;

            textBox2.Text = calculoImpuesto.ToString("c");
            textBox3.Text = total.ToString("c");

            label5.Text = "Total a pagar de " + textBox4.Text + " es de " + textBox3.Text;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Add("Granita de Café -- L 30.00");

            double valor = Convert.ToDouble(textBox1.Text);

            textBox1.Text = Convert.ToString(valor + 30);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Capuccino -- L 20.00");

            double valor = Convert.ToDouble(textBox1.Text);

            textBox1.Text = Convert.ToString(valor + 20);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Calcular();
        }
    }
}
