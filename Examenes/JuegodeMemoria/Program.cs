using Examen2_JuegodeMemoria.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2_JuegodeMemoria
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static Bitmap ObtenerImagen(string id)
        {
            var rm = Resources.ResourceManager.GetObject(id);
            Bitmap imagen = (Bitmap)rm;

            return imagen;
        }
    }
}
