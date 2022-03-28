using System;
using System.Windows.Forms;

namespace FormListaReproduccionG2_2022_II
{
    public partial class FormAgregar : Form
    {
        public delegate void DelegadoMusica(Musica musica);
        public event DelegadoMusica EnviarMusica;
        public FormAgregar()
        {
            InitializeComponent();
        }

        private void txtbArtista_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                string error = "Debes de rellenar el campo";
                if ( txtbArtista.Text == ""  )
                {
                    errorProviderAgregar.SetError(txtbArtista,error);
                    throw new ApplicationException();
                }else if (txtbAlbum.Text == "")
                {
                    errorProviderAgregar.SetError(txtbAlbum, error);
                    throw new ApplicationException();
                }
                else if( txtbCancion.Text == "")
                {
                    errorProviderAgregar.SetError(txtbCancion, error);
                    throw new ApplicationException();
                }

                errorProviderAgregar.Clear();
                EnviarMusica(new Musica(txtbCancion.Text, txtbArtista.Text, txtbAlbum.Text));
            }
            catch(ApplicationException)
            {

            }
        }
    }
}
