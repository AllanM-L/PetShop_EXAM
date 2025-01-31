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
    public partial class frm_Mascotas : Form
    {
        private string connectionString = "Server=DESKTOP-6IIB0IE\\SQLEXPRESS;Database=PetShopDB;Trusted_Connection=True;";

        public frm_Mascotas()
        {
            InitializeComponent();
        }

        private void frm_Mascotas_Load(object sender, EventArgs e)
        {
            CargarDueños();
        }

        private void CargarDueños()
        {
            cmbDueños.Items.Clear();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Id_cliente, Nombre + ' ' + Apellido AS Nombre FROM Clientes";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbDueños.Items.Add(new KeyValuePair<int, string>(
                        (int)reader["Id_cliente"], reader["Nombre"].ToString()));
                }
                cmbDueños.DisplayMember = "Value";
                cmbDueños.ValueMember = "Key";
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string tipo = txtTipo.Text;
            string nombreDueño = txtNombreDueño.Text;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(tipo) ||
                string.IsNullOrWhiteSpace(nombreDueño) || cmbDueños.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            int idDueño = ((KeyValuePair<int, string>)cmbDueños.SelectedItem).Key;

            Mascota nuevaMascota = new Mascota
            {
                Nombre = nombre,
                Tipo = tipo,
                IdCliente = idDueño
            };

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "INSERT INTO Mascotas (Nombre, Tipo, IdCliente) VALUES (@Nombre, @Tipo, @IdCliente)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Nombre", nuevaMascota.Nombre);
                cmd.Parameters.AddWithValue("@Tipo", nuevaMascota.Tipo);
                cmd.Parameters.AddWithValue("@IdCliente", nuevaMascota.IdCliente);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Mascota guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void lblNombreDueño_Click(object sender, EventArgs e)
        {

        }
    }
}



