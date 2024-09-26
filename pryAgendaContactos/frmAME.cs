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
        

        public void LlenarCombo()
        {
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.Add("Amigos");
            cmbCategoria.Items.Add("Familia");
            cmbCategoria.Items.Add("Trabajo");
        }

        public void Limpiar()
        {
            dgvContactos.ClearSelection();
            txtID.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            cmbCategoria.Text = "";
        }
        private void frmAME_Load(object sender, EventArgs e)
        {
            ObjConexion.Listar(dgvContactos);
            LlenarCombo();
            Limpiar();
        }

        private void dgvContactos_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvContactos.CurrentRow != null)
            { 
                txtID.Text = Convert.ToString(dgvContactos.CurrentRow.Cells["ID"].Value); ;
                txtNombre.Text = Convert.ToString(dgvContactos.CurrentRow.Cells["Nombre"].Value);
                txtApellido.Text = Convert.ToString(dgvContactos.CurrentRow.Cells["Apellido"].Value);
                txtTelefono.Text = Convert.ToString(dgvContactos.CurrentRow.Cells["Telefono"].Value);
                txtCorreo.Text = Convert.ToString(dgvContactos.CurrentRow.Cells["Correo"].Value);
                cmbCategoria.SelectedItem = Convert.ToString(dgvContactos.CurrentRow.Cells["Categoria"].Value);
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" & txtApellido.Text != "" & txtTelefono.Text != "" & txtCorreo.Text != "" & cmbCategoria.Text != "")
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
                        DialogResult l = MessageBox.Show("¿Seguro que desea modificar el contacto seleccionado?", "Modificar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (l == DialogResult.Yes)
                        {
                            Contacto.ID = id;
                            ObjConexion.actualizarProducto(Contacto);
                            ObjConexion.Listar(dgvContactos);
                        }
                    }
                }
                else
                {
                    DialogResult l = MessageBox.Show("¿Seguro que desea agregar este contacto?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (l == DialogResult.Yes)
                    {
                        ObjConexion.insertarProducto(Contacto);
                        ObjConexion.Listar(dgvContactos);
                    }
                }
                dgvContactos.ClearSelection();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Algun campo no está lleno, verifique porfavor", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (dgvContactos.SelectedRows.Count == 1)
            {
                DialogResult l = MessageBox.Show("¿Seguro que desea eliminar el contacto seleccionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (l == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvContactos.CurrentRow.Cells["ID"].Value);
                    ObjConexion.eliminarProducto(id);
                    ObjConexion.Listar(dgvContactos);
                }
            }
        }
    }
}
