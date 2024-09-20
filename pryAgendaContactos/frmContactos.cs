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
    public partial class frmContactos : Form
    {
        public frmContactos()
        {
            InitializeComponent();
        }
        clsConexionBD ObjConexion = new clsConexionBD();   
        private void frmContactos_Load(object sender, EventArgs e)
        {
            ObjConexion.Recorrer(trvAgenda.Nodes);
            trvAgenda.ExpandAll();
        }

        private void trvAgenda_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode nodoSeleccionado = e.Node;
            string nombre = nodoSeleccionado.Text;  
            lstDatos.Items.Clear();
            ObjConexion.Recorrer(nombre, lstDatos); 
        }
    }
}
