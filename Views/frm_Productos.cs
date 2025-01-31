using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PetShop.Models;

namespace PetShop.View
{
    public partial class frm_Productos : Form
    {
        private string connectionString = "Server=DESKTOP-6IIB0IE\\SQLEXPRESS;Database=PetShopDB;Trusted_Connection=True;";

        public frm_Productos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string categoria = txtCategoria.Text;
            decimal precio;
            int stock;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(categoria) ||
                !decimal.TryParse(txtPrecio.Text, out precio) || !int.TryParse(txtStock.Text, out stock))
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Producto nuevoProducto = new Producto
            {
                Nombre = nombre,
                Categoria = categoria,
                Precio = precio,
                Stock = stock
            };

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO Productos (Nombre, Categoria, Precio, Stock) VALUES (@Nombre, @Categoria, @Precio, @Stock)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nombre", nuevoProducto.Nombre);
                cmd.Parameters.AddWithValue("@Categoria", nuevoProducto.Categoria);
                cmd.Parameters.AddWithValue("@Precio", nuevoProducto.Precio);
                cmd.Parameters.AddWithValue("@Stock", nuevoProducto.Stock);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Producto guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); 
        }

        private void frm_Productos_Load(object sender, EventArgs e)
        {
           
        }
    }
}


