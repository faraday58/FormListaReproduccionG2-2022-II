
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Canción";
            // 
            // txtbArtista
            // 
            this.txtbArtista.Location = new System.Drawing.Point(205, 71);
            this.txtbArtista.Name = "txtbArtista";
            this.txtbArtista.Size = new System.Drawing.Size(415, 31);
            this.txtbArtista.TabIndex = 2;
            this.txtbArtista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbArtista_KeyPress);
            // 
            // txtbCancion
            // 
            this.txtbCancion.Location = new System.Drawing.Point(205, 122);
            this.txtbCancion.Name = "txtbCancion";
            this.txtbCancion.Size = new System.Drawing.Size(415, 31);
            this.txtbCancion.TabIndex = 2;
            this.txtbCancion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbArtista_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Álbum";
            // 
            // txtbAlbum
            // 
            this.txtbAlbum.Location = new System.Drawing.Point(205, 169);
            this.txtbAlbum.Name = "txtbAlbum";
            this.txtbAlbum.Size = new System.Drawing.Size(415, 31);
            this.txtbAlbum.TabIndex = 2;
            this.txtbAlbum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbArtista_KeyPress);
            // 
            // errorProviderAgregar
            // 
            this.errorProviderAgregar.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormListaReproduccionG2_2022_II.Properties.Resources.disco_general;
            this.pictureBox1.Location = new System.Drawing.Point(706, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 262);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtbAlbum);
            this.Controls.Add(this.txtbCancion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbArtista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAgregar";
            this.Text = "FormAgregar";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}