using DAL.Rentas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Win.Rentas
{
    public partial class Form1 : Form
    {
        ClientesBL _clientesBL;

        public Form1()
        {
            InitializeComponent();
            _clientesBL = new ClientesBL();

            listadeClientesBindingSource.DataSource =
                _clientesBL.ListadeClientes;
        }
    }
}
