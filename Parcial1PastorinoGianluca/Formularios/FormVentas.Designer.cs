
namespace Formularios
{
    partial class FormVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estacionamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediodepago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblVentas = new System.Windows.Forms.Label();
            this.panelMenuLateral = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSumaTotal = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txbBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.panelMenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToAddRows = false;
            this.dgvVentas.AllowUserToDeleteRows = false;
            this.dgvVentas.AllowUserToResizeColumns = false;
            this.dgvVentas.AllowUserToResizeRows = false;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVentas.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.vendedor,
            this.detalle,
            this.estacionamiento,
            this.mediodepago,
            this.total});
            this.dgvVentas.Location = new System.Drawing.Point(294, 76);
            this.dgvVentas.MultiSelect = false;
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvVentas.RowHeadersVisible = false;
            this.dgvVentas.RowTemplate.Height = 25;
            this.dgvVentas.Size = new System.Drawing.Size(704, 535);
            this.dgvVentas.TabIndex = 27;
            // 
            // fecha
            // 
            this.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fecha.DefaultCellStyle = dataGridViewCellStyle2;
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 64;
            // 
            // vendedor
            // 
            this.vendedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.vendedor.DefaultCellStyle = dataGridViewCellStyle3;
            this.vendedor.HeaderText = "Vendedor";
            this.vendedor.Name = "vendedor";
            this.vendedor.ReadOnly = true;
            this.vendedor.Width = 86;
            // 
            // detalle
            // 
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detalle.DefaultCellStyle = dataGridViewCellStyle4;
            this.detalle.HeaderText = "Detalle";
            this.detalle.Name = "detalle";
            this.detalle.ReadOnly = true;
            // 
            // estacionamiento
            // 
            this.estacionamiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.estacionamiento.DefaultCellStyle = dataGridViewCellStyle5;
            this.estacionamiento.HeaderText = "Estacionamiento";
            this.estacionamiento.Name = "estacionamiento";
            this.estacionamiento.ReadOnly = true;
            this.estacionamiento.Width = 123;
            // 
            // mediodepago
            // 
            this.mediodepago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.mediodepago.DefaultCellStyle = dataGridViewCellStyle6;
            this.mediodepago.HeaderText = "Medio de pago";
            this.mediodepago.Name = "mediodepago";
            this.mediodepago.ReadOnly = true;
            this.mediodepago.Width = 114;
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "C0";
            dataGridViewCellStyle7.NullValue = null;
            this.total.DefaultCellStyle = dataGridViewCellStyle7;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 59;
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVentas.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblVentas.Location = new System.Drawing.Point(294, 42);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(69, 28);
            this.lblVentas.TabIndex = 26;
            this.lblVentas.Text = "Ventas";
            // 
            // panelMenuLateral
            // 
            this.panelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelMenuLateral.Controls.Add(this.pictureBox2);
            this.panelMenuLateral.Controls.Add(this.btnVolver);
            this.panelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.panelMenuLateral.Name = "panelMenuLateral";
            this.panelMenuLateral.Size = new System.Drawing.Size(231, 681);
            this.panelMenuLateral.TabIndex = 25;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Formularios.Properties.Resources.Les_UTN_logo;
            this.pictureBox2.Location = new System.Drawing.Point(8, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(216, 125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVolver.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnVolver.Location = new System.Drawing.Point(0, 133);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(231, 33);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMinimizar.Location = new System.Drawing.Point(1008, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(26, 23);
            this.btnMinimizar.TabIndex = 38;
            this.btnMinimizar.Text = "_";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCerrar.Location = new System.Drawing.Point(1034, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(26, 23);
            this.btnCerrar.TabIndex = 37;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTotal.Location = new System.Drawing.Point(844, 634);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 25);
            this.lblTotal.TabIndex = 39;
            this.lblTotal.Text = "Total:";
            // 
            // lblSumaTotal
            // 
            this.lblSumaTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSumaTotal.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSumaTotal.Location = new System.Drawing.Point(906, 635);
            this.lblSumaTotal.Name = "lblSumaTotal";
            this.lblSumaTotal.Size = new System.Drawing.Size(92, 23);
            this.lblSumaTotal.TabIndex = 40;
            this.lblSumaTotal.Text = "$";
            this.lblSumaTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNombre.Location = new System.Drawing.Point(850, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(42, 15);
            this.lblNombre.TabIndex = 42;
            this.lblNombre.Text = "Buscar";
            // 
            // txbBuscar
            // 
            this.txbBuscar.Location = new System.Drawing.Point(898, 47);
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.PlaceholderText = "Vendedor";
            this.txbBuscar.Size = new System.Drawing.Size(100, 23);
            this.txbBuscar.TabIndex = 41;
            this.txbBuscar.TextChanged += new System.EventHandler(this.txbBuscar_TextChanged);
            this.txbBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbBuscar_KeyPress);
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1060, 681);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txbBuscar);
            this.Controls.Add(this.lblSumaTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvVentas);
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.panelMenuLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVentas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.panelMenuLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Panel panelMenuLateral;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn estacionamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediodepago;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSumaTotal;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txbBuscar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}