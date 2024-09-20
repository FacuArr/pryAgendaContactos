using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAgendaContactos
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void agregarEliminarModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAME frm = new frmAME(); 
            frm.ShowDialog();
        }

        private void busquedadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedad frmBusquedad = new frmBusquedad();
            frmBusquedad.ShowDialog();
        }

        private void contactosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContactos frmContactos = new frmContactos();
            frmContactos.ShowDialog();
        }

        private void AbrirFormulario<Miform>() where Miform : Form, new()
        {
            Form formulario;
            formulario = panelForms.Controls.OfType<Miform>().FirstOrDefault();

            if (formulario == null) {
                formulario = new Miform();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None; 
                formulario.Dock = DockStyle.Fill;
                panelForms.Controls.Add(formulario);
                panelForms.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        private void btnAEM_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmAME>();
        }
    }
}
