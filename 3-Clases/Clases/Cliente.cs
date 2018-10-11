using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        public Cliente()
        {
            Id = 1;
        }

        public Cliente(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }        
    }
}
