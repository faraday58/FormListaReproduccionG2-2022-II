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
        private int duracion;
        #endregion

        #region Constructor
        public Musica(string cancion, string artista, string album, Bitmap portada, int duracion)
        {
            Cancion = cancion;
            Artista = artista;
            Album = album;
            Portada = portada;
            Duracion= duracion;
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

        public int Duracion {
            get => duracion;
            set
            {
                if( value == 0)
                {
                    duracion = 128;
                }
                else
                {
                    duracion = value;
                }                
            } 

                
        }
        #endregion

        public override string ToString()
        {
            int minutos = Duracion / 60;
            int segundos = Duracion  - minutos * 60 ; 

            return minutos +":"+segundos + "[min]"  ;
        }




    }
}
