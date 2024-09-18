namespace pryAgendaContactos
{
    partial class frmContactos
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Familia");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Amigos");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Trabajo");
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.trvAgenda = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // lstDatos
            // 
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.Location = new System.Drawing.Point(259, 12);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(274, 316);
            this.lstDatos.TabIndex = 1;
            // 
            // trvAgenda
            // 
            this.trvAgenda.Location = new System.Drawing.Point(36, 12);
            this.trvAgenda.Name = "trvAgenda";
            treeNode1.Name = "Familia";
            treeNode1.Text = "Familia";
            treeNode2.Name = "Amigos";
            treeNode2.Text = "Amigos";
            treeNode3.Name = "Trabajo";
            treeNode3.Text = "Trabajo";
            this.trvAgenda.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.trvAgenda.Size = new System.Drawing.Size(191, 316);
            this.trvAgenda.TabIndex = 2;
            this.trvAgenda.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvAgenda_AfterSelect);
            // 
            // frmContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 349);
            this.Controls.Add(this.trvAgenda);
            this.Controls.Add(this.lstDatos);
            this.Name = "frmContactos";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.frmContactos_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstDatos;
        private System.Windows.Forms.TreeView trvAgenda;
    }
}