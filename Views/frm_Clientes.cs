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
using PetShop.Models;

namespace PetShop.View
{
    public partial class frm_Clientes : Form
    {
        private string connectionString = "Server=DESKTOP-6IIB0IE\\SQLEXPRESS;Database=PetShopDB;Trusted_Connection=True;";

        public frm_Clientes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string telefono = txtTelefono.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(telefono))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            Cliente nuevoCliente = new Cliente
            {
                Nombre = nombre,
                Apellido = apellido,
                Telefono = telefono
            };

            
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO Clientes (Nombre, Apellido, Telefono) VALUES (@Nombre, @Apellido, @Telefono)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nombre", nuevoCliente.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", nuevoCliente.Apellido);
                cmd.Parameters.AddWithValue("@Telefono", nuevoCliente.Telefono);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Cliente guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); 
        }

        private void frm_Clientes_Load(object sender, EventArgs e)
        {
            
        }
    }
}


