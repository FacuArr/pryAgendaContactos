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
        clsConexionBD ObjConexion = new clsConexionBD();
        clsContactos Contacto = new clsContactos(); 
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            ObjConexion.Listar(dgvContactos);
            LlenarCombo();
            dgvContactos.ClearSelection();

        }

        private void dgvContactos_SelectionChanged(object sender, EventArgs e)
        { 
            txtNombre.Text = Convert.ToString(dgvContactos.CurrentRow.Cells["Nombre"].Value);
            txtApellido.Text = Convert.ToString(dgvContactos.CurrentRow.Cells["Apellido"].Value);
            txtTelefono.Text = Convert.ToString(dgvContactos.CurrentRow.Cells["Telefono"].Value);
            txtCorreo.Text = Convert.ToString(dgvContactos.CurrentRow.Cells["Correo"].Value);
            cmbCategoria.SelectedItem = Convert.ToString(dgvContactos.CurrentRow.Cells["Categoria"].Value);
            
            
        }
            
    

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Contacto.Nombre = txtNombre.Text; 
            Contacto.Apellido = txtApellido.Text; 
            Contacto.Telefono = txtTelefono.Text; 
            Contacto.Correo = txtCorreo.Text; 
            Contacto.Categoria = cmbCategoria.Text;
            
            if (txtNombre.Text != "" || txtApellido.Text != "" || txtTelefono.Text != "" || txtCorreo.Text != "" || cmbCategoria.Text != "")
            {
                if (dgvContactos.SelectedRows.Count == 1)
                {
                    int id = Convert.ToInt32(dgvContactos.CurrentRow.Cells["ID"].Value);
                    Contacto.ID = id;
                    ObjConexion.actualizarProducto(Contacto);
                    ObjConexion.Listar(dgvContactos);
                }
                else
                {
                    ObjConexion.insertarProducto(Contacto);
                    ObjConexion.Listar(dgvContactos);
                }
            }
            else
            {
                MessageBox.Show("Algun campo no está relleno, llenar todos", "PRECAUCIÓN");
            }
            dgvContactos.ClearSelection();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            cmbCategoria.Text = "";
            dgvContactos.ClearSelection();
        }
        public void LlenarCombo()
        {
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.Add("Amigos");
            cmbCategoria.Items.Add("Familia");
            cmbCategoria.Items.Add("Trabajo");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvContactos.CurrentRow.Cells["ID"].Value);
            ObjConexion.eliminarProducto(id);
            ObjConexion.Listar(dgvContactos);
        }
    }
}
