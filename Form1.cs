using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace FormListaReproduccionG2_2022_II
{
    public partial class Form1 : Form
    {
        private ArrayList canciones;
        private Musica cancion;
        public Form1()
        {
            InitializeComponent();
            canciones = new ArrayList();
        }

        private void cargarCancionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaCanciones();
            foreach(  Musica musica in canciones)
            {
                lstbCanciones.Items.Add(musica.Cancion);
            }

        }

        private void ListaCanciones()
        {
            canciones.Add(new Musica("Saved", "Khalid "," American teen" ));
            canciones.Add(new Musica("Evil Incarnate", "Hammerfall", "Revolution"));
            canciones.Add(new Musica("", "", ""));
        }

        private void lstbCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {   
                            //Casteando a Musica
            Musica cancion =(Musica)canciones[lstbCanciones.SelectedIndex];
            lbArtista.Text = cancion.Artista;
            lbAlbum.Text = cancion.Album;
            lbCancion.Text = cancion.Cancion;

        }

        private void agregarCancionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregar formAgregar = new FormAgregar();
            formAgregar.EnviarMusica += FormAgregar_EnviarMusica;
            formAgregar.ShowDialog();
            
        }

        private void FormAgregar_EnviarMusica(Musica musica)
        {
            canciones.Add(musica);
            lstbCanciones.Items.Add(musica.Cancion);
        }

        


    }
}
