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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstDatos
            // 
            this.lstDatos.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lstDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstDatos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDatos.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstDatos.FormattingEnabled = true;
            this.lstDatos.ItemHeight = 19;
            this.lstDatos.Location = new System.Drawing.Point(271, 187);
            this.lstDatos.Name = "lstDatos";
            this.lstDatos.Size = new System.Drawing.Size(329, 173);
            this.lstDatos.TabIndex = 1;
            // 
            // trvAgenda
            // 
            this.trvAgenda.BackColor = System.Drawing.Color.CornflowerBlue;
            this.trvAgenda.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvAgenda.Location = new System.Drawing.Point(30, 12);
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
            this.trvAgenda.Size = new System.Drawing.Size(201, 348);
            this.trvAgenda.TabIndex = 2;
            this.trvAgenda.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvAgenda_AfterSelect);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryAgendaContactos.Properties.Resources.Google_Contacts_logo;
            this.pictureBox1.Location = new System.Drawing.Point(332, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(626, 378);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.trvAgenda);
            this.Controls.Add(this.lstDatos);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmContactos";
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.frmContactos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lstDatos;
        private System.Windows.Forms.TreeView trvAgenda;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}