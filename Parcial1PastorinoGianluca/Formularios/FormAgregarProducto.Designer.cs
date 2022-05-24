
namespace Formularios
{
    partial class FormAgregarProducto
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
            this.lblNuevo = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.cboSubTipo = new System.Windows.Forms.ComboBox();
            this.cboTamaño = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblSubTipo = new System.Windows.Forms.Label();
            this.lblTamaño = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.nudPrecio = new System.Windows.Forms.NumericUpDown();
            this.lblAclaración = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNuevo
            // 
            this.lblNuevo.AutoSize = true;
            this.lblNuevo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNuevo.Location = new System.Drawing.Point(121, 16);
            this.lblNuevo.Name = "lblNuevo";
            this.lblNuevo.Size = new System.Drawing.Size(157, 28);
            this.lblNuevo.TabIndex = 0;
            this.lblNuevo.Text = "Nuevo producto";
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(110, 59);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(238, 23);
            this.txbNombre.TabIndex = 1;
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "Comida",
            "Bebida"});
            this.cboTipo.Location = new System.Drawing.Point(110, 88);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(238, 23);
            this.cboTipo.TabIndex = 5;
            this.cboTipo.SelectedIndexChanged += new System.EventHandler(this.cboTipo_SelectedIndexChanged);
            // 
            // cboSubTipo
            // 
            this.cboSubTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubTipo.FormattingEnabled = true;
            this.cboSubTipo.Location = new System.Drawing.Point(110, 117);
            this.cboSubTipo.Name = "cboSubTipo";
            this.cboSubTipo.Size = new System.Drawing.Size(238, 23);
            this.cboSubTipo.TabIndex = 6;
            this.cboSubTipo.SelectedIndexChanged += new System.EventHandler(this.cboSubTipo_SelectedIndexChanged);
            // 
            // cboTamaño
            // 
            this.cboTamaño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTamaño.FormattingEnabled = true;
            this.cboTamaño.Location = new System.Drawing.Point(110, 146);
            this.cboTamaño.Name = "cboTamaño";
            this.cboTamaño.Size = new System.Drawing.Size(238, 23);
            this.cboTamaño.TabIndex = 7;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(53, 62);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "Nombre";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(74, 91);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(30, 15);
            this.lblTipo.TabIndex = 9;
            this.lblTipo.Text = "Tipo";
            // 
            // lblSubTipo
            // 
            this.lblSubTipo.AutoSize = true;
            this.lblSubTipo.Location = new System.Drawing.Point(51, 120);
            this.lblSubTipo.Name = "lblSubTipo";
            this.lblSubTipo.Size = new System.Drawing.Size(53, 15);
            this.lblSubTipo.TabIndex = 10;
            this.lblSubTipo.Text = "Sub-tipo";
            // 
            // lblTamaño
            // 
            this.lblTamaño.AutoSize = true;
            this.lblTamaño.Location = new System.Drawing.Point(55, 149);
            this.lblTamaño.Name = "lblTamaño";
            this.lblTamaño.Size = new System.Drawing.Size(49, 15);
            this.lblTamaño.TabIndex = 11;
            this.lblTamaño.Text = "Tamaño";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(64, 178);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 15);
            this.lblPrecio.TabIndex = 12;
            this.lblPrecio.Text = "Precio";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(204, 233);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(120, 233);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // nudPrecio
            // 
            this.nudPrecio.DecimalPlaces = 2;
            this.nudPrecio.Location = new System.Drawing.Point(110, 175);
            this.nudPrecio.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPrecio.Name = "nudPrecio";
            this.nudPrecio.Size = new System.Drawing.Size(238, 23);
            this.nudPrecio.TabIndex = 15;
            // 
            // lblAclaración
            // 
            this.lblAclaración.AutoSize = true;
            this.lblAclaración.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblAclaración.Location = new System.Drawing.Point(54, 202);
            this.lblAclaración.Name = "lblAclaración";
            this.lblAclaración.Size = new System.Drawing.Size(291, 13);
            this.lblAclaración.TabIndex = 16;
            this.lblAclaración.Text = "En caso de que el tamaño sea \"Otro\", agreguelo en el nombre.";
            // 
            // FormAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 275);
            this.Controls.Add(this.lblAclaración);
            this.Controls.Add(this.nudPrecio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblTamaño);
            this.Controls.Add(this.lblSubTipo);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cboTamaño);
            this.Controls.Add(this.cboSubTipo);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.lblNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAgregarProducto";
            this.Load += new System.EventHandler(this.FormAgregarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevo;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.ComboBox cboSubTipo;
        private System.Windows.Forms.ComboBox cboTamaño;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblSubTipo;
        private System.Windows.Forms.Label lblTamaño;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown nudPrecio;
        private System.Windows.Forms.Label lblAclaración;
    }
}