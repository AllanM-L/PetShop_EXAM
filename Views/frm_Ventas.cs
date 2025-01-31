using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShop.Controller;
using PetShop.Models;

namespace PetShop.View
{
    public partial class frm_Ventas : Form
    {
        public frm_Ventas()
        {
            InitializeComponent();
            CargarClientes();
            CargarProductos();
            CargarVentas();
        }

        private void CargarClientes()
        {
            cmbClientes.Items.Clear();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT Id_cliente, Nombre + ' ' + Apellido AS Nombre FROM Clientes";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbClientes.Items.Add(new KeyValuePair<int, string>(
                        (int)reader["Id_cliente"], reader["Nombre"].ToString()));
                }
                cmbClientes.DisplayMember = "Value";
                cmbClientes.ValueMember = "Key";
            }
        }

        private void CargarProductos()
        {
            cmbProductos.Items.Clear();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT Id_Producto, Nombre FROM Productos";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbProductos.Items.Add(new KeyValuePair<int, string>(
                        (int)reader["Id_Producto"], reader["Nombre"].ToString()));
                }
                cmbProductos.DisplayMember = "Value";
                cmbProductos.ValueMember = "Key";
            }
        }

        private void CargarVentas()
        {
            listViewVentas.Items.Clear();
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT v.Id, c.Nombre + ' ' + c.Apellido AS Cliente, p.Nombre AS Producto, 
                           v.Cantidad, v.Total, v.Fecha
                    FROM Ventas v
                    JOIN Clientes c ON v.IdCliente = c.Id_cliente
                    JOIN Productos p ON v.IdProducto = p.Id_Producto";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["Id"].ToString());
                    item.SubItems.Add(reader["Cliente"].ToString());
                    item.SubItems.Add(reader["Producto"].ToString());
                    item.SubItems.Add(reader["Cantidad"].ToString());
                    item.SubItems.Add(reader["Total"].ToString());
                    item.SubItems.Add(Convert.ToDateTime(reader["Fecha"]).ToString("dd/MM/yyyy"));
                    listViewVentas.Items.Add(item);
                }
            }
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (cmbClientes.SelectedItem == null || cmbProductos.SelectedItem == null || string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Debe completar todos los campos.");
                return;
            }

            int idCliente = ((KeyValuePair<int, string>)cmbClientes.SelectedItem).Key;
            int idProducto = ((KeyValuePair<int, string>)cmbProductos.SelectedItem).Key;
            int cantidad = int.Parse(txtCantidad.Text);

            decimal precioUnitario = ObtenerPrecioProducto(idProducto);
            decimal total = cantidad * precioUnitario;

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Ventas (IdCliente, IdProducto, Cantidad, Total, Fecha) VALUES (@IdCliente, @IdProducto, @Cantidad, @Total, GETDATE())";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                cmd.Parameters.AddWithValue("@IdProducto", idProducto);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                cmd.Parameters.AddWithValue("@Total", total);
                cmd.ExecuteNonQuery();
            }

            CargarVentas();
            MessageBox.Show("Venta registrada correctamente.");
        }

        private decimal ObtenerPrecioProducto(int idProducto)
        {
            decimal precio = 0;
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string query = "SELECT Precio FROM Productos WHERE Id_Producto = @IdProducto";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdProducto", idProducto);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    precio = (decimal)reader["Precio"];
                }
            }
            return precio;
        }
    }
}


