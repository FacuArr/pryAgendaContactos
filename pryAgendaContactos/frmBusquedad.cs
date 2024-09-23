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
    public partial class frmBusquedad : Form
    {
        public frmBusquedad()
        {
            InitializeComponent();
        }
        clsConexionBD ObjConexion = new clsConexionBD();   
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            String Nombre = txtNombre.Text;
            ObjConexion.buscarContacto(Nombre, dgvRegistro);
        }

        

        private void optTelefono_CheckedChanged(object sender, EventArgs e)
        {
            txtTelefono.Enabled = true;
            txtNombre.Enabled = false;
            txtCorreo.Enabled = false;
        }

        private void optCorreo_CheckedChanged(object sender, EventArgs e)
        {
            txtCorreo.Enabled = true;
            txtNombre.Enabled = false;
            txtTelefono.Enabled = false;
        }

        private void optNombre_CheckedChanged_1(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtTelefono.Enabled = false;
            txtCorreo.Enabled = false;
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            string telefono = txtTelefono.Text;
            ObjConexion.buscarContactoTel(telefono, dgvRegistro);
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text;
            ObjConexion.buscarContactoCorreo(correo, dgvRegistro);
        }

       
    }
}
