using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Rentas
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public bool Activo { get; set; }
        public List<TipoCliente> ListaTipoCliente { get; set; }

        public Cliente()
        {
            ListaTipoCliente = new List<TipoCliente>();

            var contado = new TipoCliente();
            contado.Id = 1;
            contado.Descripcion = "Contado";

            ListaTipoCliente.Add(contado);

            var credito = new TipoCliente();
            credito.Id = 2;
            credito.Descripcion = "Credito";

            ListaTipoCliente.Add(credito);

            Activo = true;
        }
    }
}
