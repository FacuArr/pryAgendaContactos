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
    public partial class frmAME : Form
    {
        public frmAME()
        {
            InitializeComponent();
        }
        clsConexionBD ObjConexion = new clsConexionBD();
        clsContactos Contacto = new clsContactos();
       

        private void dgvContactos_SelectionChanged(object sender, EventArgs e)
        {
            txtID.Text = Convert.ToString(dgvContactos.CurrentRow.Cells["ID"].Value); ;
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

            if (dgvContactos.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(txtID.Text);
                if (id != null)
                {
                    Contacto.ID = id;
                    ObjConexion.actualizarProducto(Contacto);
                    ObjConexion.Listar(dgvContactos);
                }
            }
            else
            {
                ObjConexion.insertarProducto(Contacto);
                ObjConexion.Listar(dgvContactos);
            }
            dgvContactos.ClearSelection();
            Limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        public void LlenarCombo()
        {
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.Add("Amigos");
            cmbCategoria.Items.Add("Familia");
            cmbCategoria.Items.Add("Trabajo");
        }

        public void Limpiar()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            cmbCategoria.Text = "";
            dgvContactos.ClearSelection();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvContactos.CurrentRow.Cells["ID"].Value);
            ObjConexion.eliminarProducto(id);
            ObjConexion.Listar(dgvContactos);
        }

        private void frmAME_Load(object sender, EventArgs e)
        {
            ObjConexion.Listar(dgvContactos);
            LlenarCombo();
            dgvContactos.ClearSelection();
            Limpiar();
        }
    }
}
