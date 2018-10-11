using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cliente1 = new Cliente();
            cliente1.Nombre = "Juan Perez";

            var cliente2 = new Cliente(2, "Maria Martinez");

            MessageBox.Show(cliente1.Id + " " + cliente1.Nombre);
            MessageBox.Show(cliente2.Id + " " + cliente2.Nombre);
        }
    }
}
