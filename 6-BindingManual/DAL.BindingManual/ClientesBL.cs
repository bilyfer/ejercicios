using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.BindingManual
{
    public class ClientesBL
    {
        public List<Cliente> ListadeClientes { get; set; }
        public List<TipoCliente> ListaTipoCliente { get; set; }

        public ClientesBL()
        {
            ListadeClientes = new List<Cliente>();

            var cliente1 = new Cliente();
            cliente1.Id = 1;
            cliente1.Nombre = "Batman";

            ListadeClientes.Add(cliente1);

            var cliente2 = new Cliente();
            cliente2.Id = 2;
            cliente2.Nombre = "Superman";

            ListadeClientes.Add(cliente2);

            // Tipo Cliente
            ListaTipoCliente = new List<TipoCliente>();

            var contado = new TipoCliente();
            contado.Id = 1;
            contado.Descripcion = "Contado";

            var credito = new TipoCliente()
            {
                Id = 2,
                Descripcion = "Credito"
            };

            ListaTipoCliente.Add(contado);
            ListaTipoCliente.Add(credito);
        }
    }
}
