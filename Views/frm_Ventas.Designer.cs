using System;

namespace PetShop.View
{
    partial class frm_Ventas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpia los recursos que se están utilizando.
        /// </summary>
        /// <param name="disposing">Indica si los recursos administrados deben liberarse (true) o no (false).</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el diseñador de Windows Forms

        /// <summary>
        /// Método necesario para el diseño del formulario. No lo modifique 
        /// con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbClientes = new System.Windows.Forms.ComboBox();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.listViewVentas = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelProducto = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbClientes
            // 
            this.cmbClientes.FormattingEnabled = true;
            this.cmbClientes.Location = new System.Drawing.Point(108, 30);
            this.cmbClientes.Name = "cmbClientes";
            this.cmbClientes.Size = new System.Drawing.Size(200, 21);
            this.cmbClientes.TabIndex = 0;
            // 
            // cmbProductos
            // 
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(108, 70);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(200, 21);
            this.cmbProductos.TabIndex = 1;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(108, 110);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 2;
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Location = new System.Drawing.Point(108, 150);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(200, 23);
            this.btnRegistrarVenta.TabIndex = 3;
            this.btnRegistrarVenta.Text = "Registrar Venta";
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // listViewVentas
            // 
            this.listViewVentas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderCliente,
            this.columnHeaderProducto,
            this.columnHeaderCantidad,
            this.columnHeaderTotal,
            this.columnHeaderFecha});
            this.listViewVentas.FullRowSelect = true;
            this.listViewVentas.GridLines = true;
            this.listViewVentas.HideSelection = false;
            this.listViewVentas.Location = new System.Drawing.Point(12, 200);
            this.listViewVentas.Name = "listViewVentas";
            this.listViewVentas.Size = new System.Drawing.Size(600, 200);
            this.listViewVentas.TabIndex = 4;
            this.listViewVentas.UseCompatibleStateImageBehavior = false;
            this.listViewVentas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "ID";
            // 
            // columnHeaderCliente
            // 
            this.columnHeaderCliente.Text = "Cliente";
            // 
            // columnHeaderProducto
            // 
            this.columnHeaderProducto.Text = "Producto";
            // 
            // columnHeaderCantidad
            // 
            this.columnHeaderCantidad.Text = "Cantidad";
            // 
            // columnHeaderTotal
            // 
            this.columnHeaderTotal.Text = "Total";
            // 
            // columnHeaderFecha
            // 
            this.columnHeaderFecha.Text = "Fecha";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(194)))), ((int)(((byte)(158)))));
            this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.ForeColor = System.Drawing.Color.White;
            this.labelCliente.Location = new System.Drawing.Point(20, 33);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(65, 18);
            this.labelCliente.TabIndex = 5;
            this.labelCliente.Text = "Cliente:";
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(194)))), ((int)(((byte)(158)))));
            this.labelProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducto.ForeColor = System.Drawing.Color.White;
            this.labelProducto.Location = new System.Drawing.Point(20, 73);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(82, 18);
            this.labelProducto.TabIndex = 6;
            this.labelProducto.Text = "Producto:";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(194)))), ((int)(((byte)(158)))));
            this.labelCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.ForeColor = System.Drawing.Color.White;
            this.labelCantidad.Location = new System.Drawing.Point(20, 113);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(79, 18);
            this.labelCantidad.TabIndex = 7;
            this.labelCantidad.Text = "Cantidad:";
            // 
            // frm_Ventas
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(231)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(624, 411);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.labelProducto);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.listViewVentas);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cmbProductos);
            this.Controls.Add(this.cmbClientes);
            this.Name = "frm_Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frm_Ventas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void frm_Ventas_Load(object sender, EventArgs e)
        {
            
        }
        #endregion

        private System.Windows.Forms.ComboBox cmbClientes;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.ListView listViewVentas;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderCliente;
        private System.Windows.Forms.ColumnHeader columnHeaderProducto;
        private System.Windows.Forms.ColumnHeader columnHeaderCantidad;
        private System.Windows.Forms.ColumnHeader columnHeaderTotal;
        private System.Windows.Forms.ColumnHeader columnHeaderFecha;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.Label labelCantidad;
    }
}


