﻿
namespace FormListaReproduccionG2_2022_II
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstbCanciones = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbArtista = new System.Windows.Forms.Label();
            this.lbAlbum = new System.Windows.Forms.Label();
            this.lbCancion = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarCancionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCancionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lstbCanciones
            // 
            this.lstbCanciones.FormattingEnabled = true;
            this.lstbCanciones.ItemHeight = 29;
            this.lstbCanciones.Location = new System.Drawing.Point(79, 105);
            this.lstbCanciones.Name = "lstbCanciones";
            this.lstbCanciones.Size = new System.Drawing.Size(359, 439);
            this.lstbCanciones.TabIndex = 0;
            this.lstbCanciones.SelectedIndexChanged += new System.EventHandler(this.lstbCanciones_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Artista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(594, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Álbum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(594, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Canción";
            // 
            // lbArtista
            // 
            this.lbArtista.AutoSize = true;
            this.lbArtista.Location = new System.Drawing.Point(708, 177);
            this.lbArtista.Name = "lbArtista";
            this.lbArtista.Size = new System.Drawing.Size(79, 29);
            this.lbArtista.TabIndex = 1;
            this.lbArtista.Text = "label1";
            // 
            // lbAlbum
            // 
            this.lbAlbum.AutoSize = true;
            this.lbAlbum.Location = new System.Drawing.Point(708, 251);
            this.lbAlbum.Name = "lbAlbum";
            this.lbAlbum.Size = new System.Drawing.Size(79, 29);
            this.lbAlbum.TabIndex = 1;
            this.lbAlbum.Text = "label1";
            // 
            // lbCancion
            // 
            this.lbCancion.AutoSize = true;
            this.lbCancion.Location = new System.Drawing.Point(708, 351);
            this.lbCancion.Name = "lbCancion";
            this.lbCancion.Size = new System.Drawing.Size(79, 29);
            this.lbCancion.TabIndex = 1;
            this.lbCancion.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1558, 45);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarCancionesToolStripMenuItem,
            this.agregarCancionesToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(128, 41);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cargarCancionesToolStripMenuItem
            // 
            this.cargarCancionesToolStripMenuItem.Name = "cargarCancionesToolStripMenuItem";
            this.cargarCancionesToolStripMenuItem.Size = new System.Drawing.Size(390, 48);
            this.cargarCancionesToolStripMenuItem.Text = "Cargar Canciones";
            this.cargarCancionesToolStripMenuItem.Click += new System.EventHandler(this.cargarCancionesToolStripMenuItem_Click);
            // 
            // agregarCancionesToolStripMenuItem
            // 
            this.agregarCancionesToolStripMenuItem.Name = "agregarCancionesToolStripMenuItem";
            this.agregarCancionesToolStripMenuItem.Size = new System.Drawing.Size(390, 48);
            this.agregarCancionesToolStripMenuItem.Text = "Agregar Canciones";
            this.agregarCancionesToolStripMenuItem.Click += new System.EventHandler(this.agregarCancionesToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FormListaReproduccionG2_2022_II.Properties.Resources.american_teen_album;
            this.pictureBox1.Location = new System.Drawing.Point(843, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 385);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1556, 440);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1558, 656);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbCancion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbAlbum);
            this.Controls.Add(this.lbArtista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbCanciones);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbCanciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbArtista;
        private System.Windows.Forms.Label lbAlbum;
        private System.Windows.Forms.Label lbCancion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarCancionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCancionesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

