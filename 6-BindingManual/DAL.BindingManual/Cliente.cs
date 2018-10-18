using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.BindingManual
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }
        public TipoCliente TipoCliente { get; set; }

        public Cliente()
        {
            TipoCliente = new TipoCliente();
            Activo = true;
        }
    }
}
