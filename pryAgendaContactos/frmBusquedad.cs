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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
