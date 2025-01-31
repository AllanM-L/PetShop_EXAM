using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PetShop.Views;


namespace PetShop.View
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click_1(object sender, EventArgs e)
        {
            frm_Reporte reporteForm = new frm_Reporte();
            reporteForm.ShowDialog();
        }

        private void btnClientes_Click_1(object sender, EventArgs e)
        {
            frm_Clientes clientesForm = new frm_Clientes();
            clientesForm.ShowDialog();
        }

        private void btnMascotas_Click_1(object sender, EventArgs e)
        {
            frm_Mascotas mascotasForm = new frm_Mascotas();
            mascotasForm.ShowDialog();
        }

        private void btnProductos_Click_1(object sender, EventArgs e)
        {
            frm_Productos productosForm = new frm_Productos();
            productosForm.ShowDialog();
        }

        private void btnVentas_Click_1(object sender, EventArgs e)
        {
            frm_Ventas ventasForm = new frm_Ventas();
            ventasForm.ShowDialog();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

