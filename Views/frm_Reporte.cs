using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShop.Controller;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace PetShop.Views
{
    public partial class frm_Reporte : Form
    {
        public frm_Reporte()
        {
            InitializeComponent();
        }

        private void frm_Reporte_Load(object sender, EventArgs e)
        {
            CargarReporte();
        }

        private void CargarReporte()
        {
            try
            {
                string connectionString = "Server=DESKTOP-6IIB0IE\\SQLEXPRESS;Database=PetShopDB;Trusted_Connection=True;";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"
                SELECT Id_Producto, Nombre, Categoria, Precio, Stock
                FROM Productos
                ORDER BY Categoria";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    ReportDataSource rds = new ReportDataSource("Report_ProductosVendidos", dt);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rds);
                    reportViewer1.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte: " + ex.Message);
            }
        }








    }
}



