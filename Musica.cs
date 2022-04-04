using System.Drawing;

namespace FormListaReproduccionG2_2022_II
{
    public class Musica
    {
        #region Atributos
        private string cancion;
        private string artista;
        private string album;
        private Bitmap portada;
        #endregion

        #region Constructor
        public Musica(string cancion, string artista, string album,Bitmap portada)
        {
            Cancion = cancion;
            Artista = artista;
            Album = album;
            Portada= portada;
        }
        #endregion

        #region Propiedades
        public string Cancion { 
            get => cancion; 
            set            
            {
                if( value == "")
                {
                    cancion = "El borrego";
                }
                else
                {
                    cancion = value;
                }

            }
            
        }
        public string Artista { 
            get => artista;
            set
            {
                if( value == "")
                {
                    artista = "Café Tacuba";
                }else
                {
                    artista = value;
                }
                
            }
        }
        public string Album { 
            get => album; 
            set
            {
                if ( value == "")
                {
                    album = "RE";
                }
                else
                {
                    album = value;
                }
                
            }
                
        }

        public Bitmap Portada {
            get => portada; 
            set
            {
                if(  value == null)
                {
                    portada = Properties.Resources.cafe_tacuba_re;
                }
                else
                {
                    portada = value;
                }
                
            }
                
        }
        #endregion






    }
}
