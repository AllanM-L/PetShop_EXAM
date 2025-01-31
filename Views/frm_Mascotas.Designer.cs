namespace PetShop.View
{
    partial class frm_Mascotas
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblNombreDueño;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtNombreDueño;
        private System.Windows.Forms.ComboBox cmbDueños;
        private System.Windows.Forms.Button btnGuardar;

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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblNombreDueño = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtNombreDueño = new System.Windows.Forms.TextBox();
            this.cmbDueños = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(194)))), ((int)(((byte)(158)))));
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(7, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(144, 23);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre Mascota:";
            // 
            // lblTipo
            // 
            this.lblTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(194)))), ((int)(((byte)(158)))));
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(7, 60);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(87, 23);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblNombreDueño
            // 
            this.lblNombreDueño.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(194)))), ((int)(((byte)(158)))));
            this.lblNombreDueño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDueño.ForeColor = System.Drawing.Color.White;
            this.lblNombreDueño.Location = new System.Drawing.Point(7, 100);
            this.lblNombreDueño.Name = "lblNombreDueño";
            this.lblNombreDueño.Size = new System.Drawing.Size(129, 23);
            this.lblNombreDueño.TabIndex = 4;
            this.lblNombreDueño.Text = "Nombre Dueño:";
            this.lblNombreDueño.Click += new System.EventHandler(this.lblNombreDueño_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(174, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(174, 60);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(200, 20);
            this.txtTipo.TabIndex = 3;
            // 
            // txtNombreDueño
            // 
            this.txtNombreDueño.Location = new System.Drawing.Point(174, 100);
            this.txtNombreDueño.Name = "txtNombreDueño";
            this.txtNombreDueño.Size = new System.Drawing.Size(200, 20);
            this.txtNombreDueño.TabIndex = 5;
            // 
            // cmbDueños
            // 
            this.cmbDueños.FormattingEnabled = true;
            this.cmbDueños.Location = new System.Drawing.Point(174, 130);
            this.cmbDueños.Name = "cmbDueños";
            this.cmbDueños.Size = new System.Drawing.Size(200, 21);
            this.cmbDueños.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(174, 160);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frm_Mascotas
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(231)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(386, 200);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.lblNombreDueño);
            this.Controls.Add(this.txtNombreDueño);
            this.Controls.Add(this.cmbDueños);
            this.Controls.Add(this.btnGuardar);
            this.Name = "frm_Mascotas";
            this.Text = "Gestión de Mascotas";
            this.Load += new System.EventHandler(this.frm_Mascotas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

