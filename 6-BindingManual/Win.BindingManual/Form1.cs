using DAL.BindingManual;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Win.BindingManual
{
    public partial class Form1 : Form
    {
        ClientesBL _clientes;

        public Form1()
        {
            InitializeComponent();

            _clientes = new ClientesBL();

            listadeClientesBindingSource.DataSource =
                   _clientes.ListadeClientes;

            listaTipoClienteBindingSource.DataSource =
                   _clientes.ListaTipoCliente;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
