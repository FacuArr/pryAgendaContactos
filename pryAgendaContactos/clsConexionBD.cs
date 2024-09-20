using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAgendaContactos
{
    internal class clsConexionBD
    {
        // Definicion de comando, conexion y adaptador.

        OleDbCommand comando;
        OleDbConnection conexion;
        OleDbDataAdapter adaptador;
        string cadena;

        public clsConexionBD()
        {
            cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:../../BD/BDContactos.accdb;";
        }

        public void Listar(DataGridView dgvUsuarios)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Contactos";
                DataTable tablaProductos = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaProductos);

                dgvUsuarios.DataSource = tablaProductos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void insertarProducto(clsContactos contacto)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = $"INSERT INTO Contactos(Nombre, Apellido, Telefono, Correo, Categoria) VALUES('{contacto.Nombre}', '{contacto.Apellido}','{contacto.Telefono}','{contacto.Correo}','{contacto.Categoria}' )";
                conexion.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void actualizarProducto(clsContactos contacto)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = $"UPDATE Contactos SET Nombre='{contacto.Nombre}', Apellido='{contacto.Apellido}',Telefono='{contacto.Telefono}',Correo='{contacto.Correo}', Categoria='{contacto.Categoria}' WHERE Id = {contacto.ID}";

                conexion.Open();

                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void eliminarProducto(int id)
        {
            conexion = new OleDbConnection(cadena);
            comando = new OleDbCommand();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = $"DELETE from Contactos WHERE id={id}";
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();

        }

        public void buscarContacto(string nombre, DataGridView dgvProducto)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = $"SELECT * FROM Contactos WHERE Nombre LIKE '%{nombre}%'";
                DataTable tablaProductos = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaProductos);

                dgvProducto.DataSource = tablaProductos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void buscarContactoTel(string telefono, DataGridView dgvProducto)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = $"SELECT * FROM Contactos WHERE Telefono LIKE '%{telefono}%'";
                DataTable tablaProductos = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaProductos);

                dgvProducto.DataSource = tablaProductos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void buscarContactoCorreo(string correo, DataGridView dgvProducto)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = $"SELECT * FROM Contactos WHERE Correo LIKE '%{correo}%'";
                DataTable tablaProductos = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tablaProductos);

                dgvProducto.DataSource = tablaProductos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Recorrer(TreeNodeCollection nodos)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Contactos";
                DataTable dataTable = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(dataTable);
                foreach (DataRow row in dataTable.Rows)
                {
                    string categoria = row["Categoria"].ToString();
                    string nombre = row["Nombre"].ToString();
                    foreach (TreeNode nodo in nodos)
                    {
                        if (nodo.Text == categoria)
                        {
                            nodo.Nodes.Add(nombre);  
                        }             
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Recorrer(string nombre, ListBox lstDatos)
        {
            try
            {
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = $"SELECT * FROM Contactos WHERE Nombre LIKE '%{nombre}%'";
                DataTable dataTable = new DataTable();

                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    lstDatos.Items.Add("Nombre: " + row["Nombre"].ToString());
                    lstDatos.Items.Add("Apellido: " + row["Apellido"].ToString());
                    lstDatos.Items.Add("Telefeno: " + row["Telefono"].ToString());
                    lstDatos.Items.Add("Correo: " + row["Correo"].ToString());
                    lstDatos.Items.Add("Categoria: " + row["Categoria"].ToString());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

