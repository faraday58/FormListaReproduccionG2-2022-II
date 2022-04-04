
namespace FormListaReproduccionG2_2022_II
{
    partial class FormAgregar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbArtista = new System.Windows.Forms.TextBox();
            this.txtbCancion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbAlbum = new System.Windows.Forms.TextBox();
            this.errorProviderAgregar = new System.Windows.Forms.ErrorProvider(this.components);
            this.ptbPortada = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPortada)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Canción";
            // 
            // txtbArtista
            // 
            this.txtbArtista.Location = new System.Drawing.Point(324, 105);
            this.txtbArtista.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbArtista.Name = "txtbArtista";
            this.txtbArtista.Size = new System.Drawing.Size(654, 44);
            this.txtbArtista.TabIndex = 2;
            this.txtbArtista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbArtista_KeyPress);
            // 
            // txtbCancion
            // 
            this.txtbCancion.Location = new System.Drawing.Point(324, 180);
            this.txtbCancion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbCancion.Name = "txtbCancion";
            this.txtbCancion.Size = new System.Drawing.Size(654, 44);
            this.txtbCancion.TabIndex = 2;
            this.txtbCancion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbArtista_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(142, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Álbum";
            // 
            // txtbAlbum
            // 
            this.txtbAlbum.Location = new System.Drawing.Point(324, 250);
            this.txtbAlbum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbAlbum.Name = "txtbAlbum";
            this.txtbAlbum.Size = new System.Drawing.Size(654, 44);
            this.txtbAlbum.TabIndex = 2;
            this.txtbAlbum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbArtista_KeyPress);
            // 
            // errorProviderAgregar
            // 
            this.errorProviderAgregar.ContainerControl = this;
            // 
            // ptbPortada
            // 
            this.ptbPortada.Image = global::FormListaReproduccionG2_2022_II.Properties.Resources.disco_musical;
            this.ptbPortada.Location = new System.Drawing.Point(1187, 90);
            this.ptbPortada.Name = "ptbPortada";
            this.ptbPortada.Size = new System.Drawing.Size(264, 219);
            this.ptbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPortada.TabIndex = 3;
            this.ptbPortada.TabStop = false;
            // 
            // FormAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1874, 402);
            this.Controls.Add(this.ptbPortada);
            this.Controls.Add(this.txtbAlbum);
            this.Controls.Add(this.txtbCancion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbArtista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAgregar";
            this.Text = "FormAgregar";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPortada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbArtista;
        private System.Windows.Forms.TextBox txtbCancion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbAlbum;
        private System.Windows.Forms.ErrorProvider errorProviderAgregar;
        private System.Windows.Forms.PictureBox ptbPortada;
    }
}