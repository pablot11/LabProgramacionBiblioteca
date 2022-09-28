namespace pryTorresBiblioteca
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.msBiblioteca = new System.Windows.Forms.MenuStrip();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picLogoBiblioteca = new System.Windows.Forms.PictureBox();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msBiblioteca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoBiblioteca)).BeginInit();
            this.SuspendLayout();
            // 
            // msBiblioteca
            // 
            this.msBiblioteca.BackColor = System.Drawing.Color.Transparent;
            this.msBiblioteca.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msBiblioteca.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.msBiblioteca.Location = new System.Drawing.Point(0, 0);
            this.msBiblioteca.Name = "msBiblioteca";
            this.msBiblioteca.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.msBiblioteca.Size = new System.Drawing.Size(663, 24);
            this.msBiblioteca.TabIndex = 0;
            this.msBiblioteca.Text = "menuStrip1";
            this.msBiblioteca.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.msBiblioteca_ItemClicked);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.libroToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // libroToolStripMenuItem
            // 
            this.libroToolStripMenuItem.Name = "libroToolStripMenuItem";
            this.libroToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.libroToolStripMenuItem.Text = "Libros";
            this.libroToolStripMenuItem.Click += new System.EventHandler(this.libroToolStripMenuItem_Click);
            // 
            // picLogoBiblioteca
            // 
            this.picLogoBiblioteca.Image = ((System.Drawing.Image)(resources.GetObject("picLogoBiblioteca.Image")));
            this.picLogoBiblioteca.Location = new System.Drawing.Point(9, 25);
            this.picLogoBiblioteca.Margin = new System.Windows.Forms.Padding(2);
            this.picLogoBiblioteca.Name = "picLogoBiblioteca";
            this.picLogoBiblioteca.Size = new System.Drawing.Size(644, 384);
            this.picLogoBiblioteca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLogoBiblioteca.TabIndex = 1;
            this.picLogoBiblioteca.TabStop = false;
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(663, 410);
            this.Controls.Add(this.picLogoBiblioteca);
            this.Controls.Add(this.msBiblioteca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Biblioteca";
            this.msBiblioteca.ResumeLayout(false);
            this.msBiblioteca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoBiblioteca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msBiblioteca;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem libroToolStripMenuItem;
        private System.Windows.Forms.PictureBox picLogoBiblioteca;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

