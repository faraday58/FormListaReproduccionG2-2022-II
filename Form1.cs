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
        private int contSegundos;
        private int contMinutos;
        private int contSegundero;
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
            canciones.Add(new Musica("Saved", "Khalid "," American teen",Properties.Resources.american_teen_album,222));
            canciones.Add(new Musica("Evil Incarnate", "Hammerfall", "Revolution",Properties.Resources.hammer_fall,257));
            canciones.Add(new Musica("", "", "",null,0));
        }

        private void lstbCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Casteando a Musica
            try
            {

                cancion = (Musica)canciones[lstbCanciones.SelectedIndex];
                lbArtista.Text = cancion.Artista;
                lbAlbum.Text = cancion.Album;
                lbCancion.Text = cancion.Cancion;
                ptbPortada.Image = cancion.Portada;

                lbTiempoTotal.Text = cancion.ToString();
            }
            catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Canción eliminada de forma correcta");
            }
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

        private void borrarCanciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //El orden para eliminar la canción, nos interesa para
            //evitar una Excepción.
            canciones.RemoveAt(lstbCanciones.SelectedIndex);
            lstbCanciones.Items.RemoveAt(lstbCanciones.SelectedIndex);
        }

        private void reproducirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerCiclo.Start();
            pgbDuracion.Maximum = 180;
        }

        private void timerCiclo_Tick(object sender, EventArgs e)
        {

            pgbDuracion.Value = contSegundos;

            if (contSegundero < 60 && contMinutos == 0 )
            {
                lbTiempoTrans.Text = contSegundero + "[s]";
            }
            else 
            {
                if(contSegundero == 60 )
                {
                    contSegundero = 0;
                    contMinutos += 1;
                }                
                
                lbTiempoTrans.Text = contMinutos  +  ":" + contSegundero + "[min]";
               
            }
            contSegundero += 1;


            contSegundos += 1; //Contador de segundos
            if( pgbDuracion.Value == 180   )
            {
                timerCiclo.Stop();
            }
        }
    }
}
