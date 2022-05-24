
namespace Formularios
{
    partial class FormInventario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_menuLateral = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.idProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInventario = new System.Windows.Forms.Label();
            this.btnEditarStock = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txbBuscar = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panel_menuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_menuLateral
            // 
            this.panel_menuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel_menuLateral.Controls.Add(this.pictureBox2);
            this.panel_menuLateral.Controls.Add(this.btnVolver);
            this.panel_menuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menuLateral.Location = new System.Drawing.Point(0, 0);
            this.panel_menuLateral.Name = "panel_menuLateral";
            this.panel_menuLateral.Size = new System.Drawing.Size(231, 681);
            this.panel_menuLateral.TabIndex = 21;
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
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            this.dgvInventario.AllowUserToResizeColumns = false;
            this.dgvInventario.AllowUserToResizeRows = false;
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgvInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProd,
            this.nombreProd,
            this.tipo,
            this.stockProd});
            this.dgvInventario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvInventario.Location = new System.Drawing.Point(294, 76);
            this.dgvInventario.MultiSelect = false;
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowHeadersVisible = false;
            this.dgvInventario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvInventario.RowTemplate.Height = 25;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(704, 535);
            this.dgvInventario.TabIndex = 2;
            this.dgvInventario.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvInventario_CellBeginEdit);
            this.dgvInventario.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellEndEdit);
            this.dgvInventario.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellValueChanged);
            // 
            // idProd
            // 
            this.idProd.FillWeight = 30.45685F;
            this.idProd.HeaderText = "ID";
            this.idProd.Name = "idProd";
            this.idProd.ReadOnly = true;
            this.idProd.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // nombreProd
            // 
            this.nombreProd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreProd.FillWeight = 217.0347F;
            this.nombreProd.HeaderText = "Nombre";
            this.nombreProd.Name = "nombreProd";
            this.nombreProd.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // stockProd
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.stockProd.DefaultCellStyle = dataGridViewCellStyle8;
            this.stockProd.FillWeight = 52.50841F;
            this.stockProd.HeaderText = "Stock";
            this.stockProd.Name = "stockProd";
            // 
            // lblInventario
            // 
            this.lblInventario.AutoSize = true;
            this.lblInventario.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInventario.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblInventario.Location = new System.Drawing.Point(294, 42);
            this.lblInventario.Name = "lblInventario";
            this.lblInventario.Size = new System.Drawing.Size(100, 28);
            this.lblInventario.TabIndex = 23;
            this.lblInventario.Text = "Inventario";
            // 
            // btnEditarStock
            // 
            this.btnEditarStock.Location = new System.Drawing.Point(883, 627);
            this.btnEditarStock.Name = "btnEditarStock";
            this.btnEditarStock.Size = new System.Drawing.Size(115, 40);
            this.btnEditarStock.TabIndex = 24;
            this.btnEditarStock.Text = "Agregar stock";
            this.btnEditarStock.UseVisualStyleBackColor = true;
            this.btnEditarStock.Click += new System.EventHandler(this.btnEditarStock_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(294, 627);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 40);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "Agregar nuevo producto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            // txbBuscar
            // 
            this.txbBuscar.Location = new System.Drawing.Point(898, 47);
            this.txbBuscar.Name = "txbBuscar";
            this.txbBuscar.PlaceholderText = "Nombre Prod.";
            this.txbBuscar.Size = new System.Drawing.Size(100, 23);
            this.txbBuscar.TabIndex = 39;
            this.txbBuscar.TextChanged += new System.EventHandler(this.txbBuscar_TextChanged);
            this.txbBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbBuscar_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNombre.Location = new System.Drawing.Point(850, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(42, 15);
            this.lblNombre.TabIndex = 40;
            this.lblNombre.Text = "Buscar";
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1060, 681);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txbBuscar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEditarStock);
            this.Controls.Add(this.lblInventario);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.panel_menuLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LES UTN - Inventario";
            this.Load += new System.EventHandler(this.FormInventario_Load);
            this.panel_menuLateral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_menuLateral;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Label lblInventario;
        private System.Windows.Forms.Button btnEditarStock;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockProd;
        private System.Windows.Forms.TextBox txbBuscar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}