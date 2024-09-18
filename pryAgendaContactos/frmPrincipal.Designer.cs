namespace pryAgendaContactos
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarEliminarModificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarEliminarModificarToolStripMenuItem,
            this.busquedadToolStripMenuItem,
            this.contactosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarEliminarModificarToolStripMenuItem
            // 
            this.agregarEliminarModificarToolStripMenuItem.Name = "agregarEliminarModificarToolStripMenuItem";
            this.agregarEliminarModificarToolStripMenuItem.Size = new System.Drawing.Size(186, 20);
            this.agregarEliminarModificarToolStripMenuItem.Text = "Agregar - Eliminar - Modificar...";
            this.agregarEliminarModificarToolStripMenuItem.Click += new System.EventHandler(this.agregarEliminarModificarToolStripMenuItem_Click);
            // 
            // busquedadToolStripMenuItem
            // 
            this.busquedadToolStripMenuItem.Name = "busquedadToolStripMenuItem";
            this.busquedadToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.busquedadToolStripMenuItem.Text = "Búsqueda...";
            this.busquedadToolStripMenuItem.Click += new System.EventHandler(this.busquedadToolStripMenuItem_Click);
            // 
            // contactosToolStripMenuItem
            // 
            this.contactosToolStripMenuItem.Name = "contactosToolStripMenuItem";
            this.contactosToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.contactosToolStripMenuItem.Text = "Contactos...";
            this.contactosToolStripMenuItem.Click += new System.EventHandler(this.contactosToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 412);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarEliminarModificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactosToolStripMenuItem;
    }
}

