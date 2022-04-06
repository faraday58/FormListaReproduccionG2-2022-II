
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
            this.components = new System.ComponentModel.Container();
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
            this.ptbPortada = new System.Windows.Forms.PictureBox();
            this.cmsMenuLista = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.borrarCanciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reproducirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPortada)).BeginInit();
            this.cmsMenuLista.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstbCanciones
            // 
            this.lstbCanciones.ContextMenuStrip = this.cmsMenuLista;
            this.lstbCanciones.FormattingEnabled = true;
            this.lstbCanciones.ItemHeight = 37;
            this.lstbCanciones.Location = new System.Drawing.Point(107, 134);
            this.lstbCanciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstbCanciones.Name = "lstbCanciones";
            this.lstbCanciones.Size = new System.Drawing.Size(486, 559);
            this.lstbCanciones.TabIndex = 0;
            this.lstbCanciones.SelectedIndexChanged += new System.EventHandler(this.lstbCanciones_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(806, 226);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Artista";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(806, 320);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Álbum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(806, 448);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Canción";
            // 
            // lbArtista
            // 
            this.lbArtista.AutoSize = true;
            this.lbArtista.Location = new System.Drawing.Point(961, 226);
            this.lbArtista.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbArtista.Name = "lbArtista";
            this.lbArtista.Size = new System.Drawing.Size(100, 37);
            this.lbArtista.TabIndex = 1;
            this.lbArtista.Text = "label1";
            // 
            // lbAlbum
            // 
            this.lbAlbum.AutoSize = true;
            this.lbAlbum.Location = new System.Drawing.Point(961, 320);
            this.lbAlbum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAlbum.Name = "lbAlbum";
            this.lbAlbum.Size = new System.Drawing.Size(100, 37);
            this.lbAlbum.TabIndex = 1;
            this.lbAlbum.Text = "label1";
            // 
            // lbCancion
            // 
            this.lbCancion.AutoSize = true;
            this.lbCancion.Location = new System.Drawing.Point(961, 448);
            this.lbCancion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCancion.Name = "lbCancion";
            this.lbCancion.Size = new System.Drawing.Size(100, 37);
            this.lbCancion.TabIndex = 1;
            this.lbCancion.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(2479, 58);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarCancionesToolStripMenuItem,
            this.agregarCancionesToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(168, 52);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cargarCancionesToolStripMenuItem
            // 
            this.cargarCancionesToolStripMenuItem.Name = "cargarCancionesToolStripMenuItem";
            this.cargarCancionesToolStripMenuItem.Size = new System.Drawing.Size(517, 66);
            this.cargarCancionesToolStripMenuItem.Text = "Cargar Canciones";
            this.cargarCancionesToolStripMenuItem.Click += new System.EventHandler(this.cargarCancionesToolStripMenuItem_Click);
            // 
            // agregarCancionesToolStripMenuItem
            // 
            this.agregarCancionesToolStripMenuItem.Name = "agregarCancionesToolStripMenuItem";
            this.agregarCancionesToolStripMenuItem.Size = new System.Drawing.Size(517, 66);
            this.agregarCancionesToolStripMenuItem.Text = "Agregar Canciones";
            this.agregarCancionesToolStripMenuItem.Click += new System.EventHandler(this.agregarCancionesToolStripMenuItem_Click);
            // 
            // ptbPortada
            // 
            this.ptbPortada.Image = global::FormListaReproduccionG2_2022_II.Properties.Resources.hammer_fall;
            this.ptbPortada.Location = new System.Drawing.Point(1614, 123);
            this.ptbPortada.Margin = new System.Windows.Forms.Padding(4);
            this.ptbPortada.Name = "ptbPortada";
            this.ptbPortada.Size = new System.Drawing.Size(527, 491);
            this.ptbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPortada.TabIndex = 3;
            this.ptbPortada.TabStop = false;
            // 
            // cmsMenuLista
            // 
            this.cmsMenuLista.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.cmsMenuLista.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrarCanciónToolStripMenuItem,
            this.reproducirToolStripMenuItem});
            this.cmsMenuLista.Name = "cmsMenuLista";
            this.cmsMenuLista.Size = new System.Drawing.Size(421, 182);
            // 
            // borrarCanciónToolStripMenuItem
            // 
            this.borrarCanciónToolStripMenuItem.Name = "borrarCanciónToolStripMenuItem";
            this.borrarCanciónToolStripMenuItem.Size = new System.Drawing.Size(420, 56);
            this.borrarCanciónToolStripMenuItem.Text = "Quitar de mi lista";
            this.borrarCanciónToolStripMenuItem.Click += new System.EventHandler(this.borrarCanciónToolStripMenuItem_Click);
            // 
            // reproducirToolStripMenuItem
            // 
            this.reproducirToolStripMenuItem.Name = "reproducirToolStripMenuItem";
            this.reproducirToolStripMenuItem.Size = new System.Drawing.Size(372, 56);
            this.reproducirToolStripMenuItem.Text = "Reproducir";
            // 
            // ptbPortada
            // 
            this.ptbPortada.Location = new System.Drawing.Point(929, 91);
            this.ptbPortada.Name = "ptbPortada";
            this.ptbPortada.Size = new System.Drawing.Size(333, 332);
            this.ptbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPortada.TabIndex = 3;
            this.ptbPortada.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2479, 837);
            this.Controls.Add(this.ptbPortada);
            this.Controls.Add(this.lbCancion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbAlbum);
            this.Controls.Add(this.lbArtista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstbCanciones);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPortada)).EndInit();
            this.cmsMenuLista.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox ptbPortada;
        private System.Windows.Forms.ContextMenuStrip cmsMenuLista;
        private System.Windows.Forms.ToolStripMenuItem borrarCanciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reproducirToolStripMenuItem;
    }
}

