using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Examen2_JuegodeMemoria
{
    public partial class Form1 : Form
    {
        Timer _myTimer;
        List<int> _listaNumeros;
        PictureBox _ultimoPictureBoxEncontrado;
        int _contador = 1;

        public Form1()
        {
            InitializeComponent();

            _listaNumeros = new List<int>();
            numerosAlAzar();

            _myTimer = new Timer();
            _myTimer.Tick += new EventHandler(Tiempo);
            _myTimer.Interval = 1000;
            _myTimer.Start();
        }

        private void Tiempo(object myObject, EventArgs myEventArgs)
        {
            int aciertos = 0;
            foreach (var control in this.Controls)
            {
                if (control is PictureBox)
                {
                    var picturebox = control as PictureBox;

                    if (picturebox.Image != null)
                    {
                        aciertos += 1;
                    }
                }
            }

            if (aciertos == 16)
            {
                _myTimer.Stop();
                MessageBox.Show("Ganaste!");
            }
            else
            {
                _contador++;
                label1.Text = (_contador).ToString();
            }
        }

        private void numerosAlAzar()
        {
            var random = new Random();

            for (int i = 0; i < 8; i++)
            {
                int numeroAlAzar = random.Next(1, 16);
                while (_listaNumeros.Contains(numeroAlAzar)) numeroAlAzar = random.Next(1, 16);

                // Agrega numeros dos veces
                _listaNumeros.Add(numeroAlAzar);
                _listaNumeros.Add(numeroAlAzar);
            }

            // Reordena los elementos de la lista al azar
            _listaNumeros = _listaNumeros.OrderBy(a => Guid.NewGuid()).ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicia un nuevo juego
            int j = 0;
            // Asignar imagenes a los pictureboxes
            for (int i = 0; i < this.Controls.Count; i++)
            {
                var control = this.Controls[i];

                if (control is PictureBox)
                {
                    var pictureBox = control as PictureBox;
                    pictureBox.Image = null;
                    pictureBox.Tag = _listaNumeros[j];
                    j++;
                }
            }
            _contador = 1;
            label1.Text = _contador.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var pictureBox = sender as PictureBox;
            if (pictureBox.Image == null)
            {
                var numeroImagen = pictureBox.Tag.ToString();
                pictureBox.Image = Program.ObtenerImagen(numeroImagen);

                if (_ultimoPictureBoxEncontrado != null)
                {
                    if (_ultimoPictureBoxEncontrado.Tag.ToString() != pictureBox.Tag.ToString())
                    {
                        MessageBox.Show("Fallaste");
                        pictureBox.Image = null;
                        _ultimoPictureBoxEncontrado.Image = null;
                    }

                    _ultimoPictureBoxEncontrado = null;
                }
                else
                {
                    _ultimoPictureBoxEncontrado = pictureBox;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var pictureBox = sender as PictureBox;
            if (pictureBox.Image == null)
            {
                var numeroImagen = pictureBox.Tag.ToString();
                pictureBox.Image = Program.ObtenerImagen(numeroImagen);

                if (_ultimoPictureBoxEncontrado != null)
                {
                    if (_ultimoPictureBoxEncontrado.Tag.ToString() != pictureBox.Tag.ToString())
                    {
                        MessageBox.Show("Fallaste");
                        pictureBox.Image = null;
                        _ultimoPictureBoxEncontrado.Image = null;
                    }

                    _ultimoPictureBoxEncontrado = null;
                }
                else
                {
                    _ultimoPictureBoxEncontrado = pictureBox;
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var pictureBox = sender as PictureBox;
            if (pictureBox.Image == null)
            {
                var numeroImagen = pictureBox.Tag.ToString();
                pictureBox.Image = Program.ObtenerImagen(numeroImagen);

                if (_ultimoPictureBoxEncontrado != null)
                {
                    if (_ultimoPictureBoxEncontrado.Tag.ToString() != pictureBox.Tag.ToString())
                    {
                        MessageBox.Show("Fallaste");
                        pictureBox.Image = null;
                        _ultimoPictureBoxEncontrado.Image = null;
                    }

                    _ultimoPictureBoxEncontrado = null;
                }
                else
                {
                    _ultimoPictureBoxEncontrado = pictureBox;
                }
            }
        }
    }
}
