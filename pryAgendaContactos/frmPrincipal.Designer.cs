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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarEliminarModificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAEM = new System.Windows.Forms.Button();
            this.btnContactos = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.panelForms = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.btnBusqueda);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnContactos);
            this.panel1.Controls.Add(this.btnAEM);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 537);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 148);
            this.panel2.TabIndex = 0;
            // 
            // btnAEM
            // 
            this.btnAEM.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAEM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAEM.Location = new System.Drawing.Point(0, 148);
            this.btnAEM.Name = "btnAEM";
            this.btnAEM.Size = new System.Drawing.Size(200, 50);
            this.btnAEM.TabIndex = 0;
            this.btnAEM.Text = "Agregar - Eliminar - Modificar";
            this.btnAEM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAEM.UseVisualStyleBackColor = false;
            this.btnAEM.Click += new System.EventHandler(this.btnAEM_Click);
            // 
            // btnContactos
            // 
            this.btnContactos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnContactos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContactos.Location = new System.Drawing.Point(0, 248);
            this.btnContactos.Name = "btnContactos";
            this.btnContactos.Size = new System.Drawing.Size(200, 50);
            this.btnContactos.TabIndex = 2;
            this.btnContactos.Text = "Contactos";
            this.btnContactos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContactos.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(0, 298);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusqueda.Location = new System.Drawing.Point(0, 198);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(200, 50);
            this.btnBusqueda.TabIndex = 4;
            this.btnBusqueda.Text = "Búsqueda";
            this.btnBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBusqueda.UseVisualStyleBackColor = false;
            // 
            // panelForms
            // 
            this.panelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForms.Location = new System.Drawing.Point(200, 24);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(734, 537);
            this.panelForms.TabIndex = 13;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelForms);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(950, 600);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarEliminarModificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactosToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnContactos;
        private System.Windows.Forms.Button btnAEM;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Panel panelForms;
    }
}

