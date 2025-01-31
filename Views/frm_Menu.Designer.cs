namespace PetShop.View
{
    partial class frm_Menu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitulo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.pnl_Titulo = new System.Windows.Forms.Panel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnMascotas = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnl_img = new System.Windows.Forms.Panel();
            this.pnl_menu.SuspendLayout();
            this.pnl_Titulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(46, 32);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(508, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Menú Principal - Tienda de Mascotas";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(231)))), ((int)(((byte)(200)))));
            this.pnl_menu.Controls.Add(this.btnClientes);
            this.pnl_menu.Controls.Add(this.btnMascotas);
            this.pnl_menu.Controls.Add(this.btnProductos);
            this.pnl_menu.Controls.Add(this.btnVentas);
            this.pnl_menu.Controls.Add(this.btnReporte);
            this.pnl_menu.Controls.Add(this.btnSalir);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(190, 440);
            this.pnl_menu.TabIndex = 7;
            // 
            // pnl_Titulo
            // 
            this.pnl_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(194)))), ((int)(((byte)(158)))));
            this.pnl_Titulo.Controls.Add(this.lblTitulo);
            this.pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Titulo.Location = new System.Drawing.Point(190, 0);
            this.pnl_Titulo.Name = "pnl_Titulo";
            this.pnl_Titulo.Size = new System.Drawing.Size(599, 100);
            this.pnl_Titulo.TabIndex = 8;
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.White;
            this.btnClientes.Location = new System.Drawing.Point(12, 108);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(169, 30);
            this.btnClientes.TabIndex = 7;
            this.btnClientes.Text = "Gestionar Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click_1);
            // 
            // btnMascotas
            // 
            this.btnMascotas.BackColor = System.Drawing.Color.White;
            this.btnMascotas.Location = new System.Drawing.Point(12, 148);
            this.btnMascotas.Name = "btnMascotas";
            this.btnMascotas.Size = new System.Drawing.Size(169, 30);
            this.btnMascotas.TabIndex = 8;
            this.btnMascotas.Text = "Gestionar Mascotas";
            this.btnMascotas.UseVisualStyleBackColor = false;
            this.btnMascotas.Click += new System.EventHandler(this.btnMascotas_Click_1);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.White;
            this.btnProductos.Location = new System.Drawing.Point(12, 188);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(169, 30);
            this.btnProductos.TabIndex = 9;
            this.btnProductos.Text = "Gestionar Productos";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click_1);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.White;
            this.btnVentas.Location = new System.Drawing.Point(12, 228);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(169, 30);
            this.btnVentas.TabIndex = 10;
            this.btnVentas.Text = "Gestionar Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click_1);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.White;
            this.btnReporte.Location = new System.Drawing.Point(12, 268);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(169, 30);
            this.btnReporte.TabIndex = 11;
            this.btnReporte.Text = "Generar Reportes";
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(12, 308);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(169, 30);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // pnl_img
            // 
            this.pnl_img.BackColor = System.Drawing.Color.White;
            this.pnl_img.BackgroundImage = global::PetShop.Properties.Resources.veterinaria;
            this.pnl_img.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_img.Location = new System.Drawing.Point(190, 100);
            this.pnl_img.Name = "pnl_img";
            this.pnl_img.Size = new System.Drawing.Size(599, 340);
            this.pnl_img.TabIndex = 9;
            // 
            // frm_Menu
            // 
            this.ClientSize = new System.Drawing.Size(789, 440);
            this.Controls.Add(this.pnl_img);
            this.Controls.Add(this.pnl_Titulo);
            this.Controls.Add(this.pnl_menu);
            this.Name = "frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.pnl_menu.ResumeLayout(false);
            this.pnl_Titulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnMascotas;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel pnl_Titulo;
        private System.Windows.Forms.Panel pnl_img;
    }
}
