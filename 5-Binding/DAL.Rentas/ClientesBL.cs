using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Rentas
{
    public class ClientesBL
    {
        public List<Cliente> ListadeClientes { get; set; }

        public ClientesBL()
        {
            ListadeClientes = new List<Cliente>();

            var cliente1 = new Cliente();
            cliente1.Id = 1;
            cliente1.Nombre = "Superman";
            cliente1.Telefono = "555555";

            ListadeClientes.Add(cliente1);
        }
    }
}
