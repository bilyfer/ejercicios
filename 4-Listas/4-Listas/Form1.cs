using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_Listas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cliente1 = new Cliente();
            cliente1.Id = 1;
            cliente1.Nombre = "Batman";

            var cliente2 = new Cliente();
            cliente2.Id = 2;
            cliente2.Nombre = "Superman";

            var cliente3 = new Cliente();
            cliente3.Id = 3;
            cliente3.Nombre = "Aquaman";

            var listadeClientes = new List<Cliente>();
            listadeClientes.Add(cliente1);
            listadeClientes.Add(cliente2);
            listadeClientes.Add(cliente3);
            

            //for (int i = 0; i <= 2; i++)
            //{
            //    MessageBox.Show(listadeClientes[i].Nombre);
            //}

            foreach (var cliente in listadeClientes)
            {
                MessageBox.Show(cliente.Nombre);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var listaNombres = new List<string>();
            listaNombres.Add("Mujer Maravilla");
            listaNombres.Add("Linterna Verde");
            listaNombres.Add("Cyborg");

            foreach (var nombre in listaNombres)
            {
                MessageBox.Show(nombre);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var cliente1 = new Cliente();
            cliente1.Id = 1;
            cliente1.Nombre = "Batman";

            var cliente2 = new Cliente();
            cliente2.Id = 2;
            cliente2.Nombre = "Superman";

            var cliente3 = new Cliente();
            cliente3.Id = 3;
            cliente3.Nombre = "Aquaman";

            var listadeClientes = new List<Cliente>();
            listadeClientes.Add(cliente1);
            listadeClientes.Add(cliente2);
            listadeClientes.Add(cliente3);

            foreach (var cliente in listadeClientes)
            {
                listBox1.Items.Add(cliente.Id + " - " + cliente.Nombre);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox1.Items)
            {
                listBox2.Items.Add(item);
            }

            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var elementoSeleccionado = listBox1.SelectedItem;

            listBox2.Items.Add(elementoSeleccionado);

            listBox1.Items.Remove(elementoSeleccionado);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (var item in listBox2.Items)
            {
                listBox1.Items.Add(item);
            }

            listBox2.Items.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var elementoSeleccionado = listBox2.SelectedItem;

            listBox1.Items.Add(elementoSeleccionado);

            listBox2.Items.Remove(elementoSeleccionado);
        }
    }
}
