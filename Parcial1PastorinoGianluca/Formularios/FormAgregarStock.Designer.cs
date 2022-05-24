
namespace Formularios
{
    partial class FormAgregarStock
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
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblAgregar = new System.Windows.Forms.Label();
            this.txbUnidades = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombreProducto.Location = new System.Drawing.Point(58, 9);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(198, 65);
            this.lblNombreProducto.TabIndex = 0;
            this.lblNombreProducto.Text = "Nombre Producto";
            this.lblNombreProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(171, 164);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(69, 164);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblAgregar
            // 
            this.lblAgregar.Location = new System.Drawing.Point(83, 74);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(148, 30);
            this.lblAgregar.TabIndex = 4;
            this.lblAgregar.Text = "Cantidad de unidades a agregar:";
            this.lblAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbUnidades
            // 
            this.txbUnidades.Location = new System.Drawing.Point(97, 112);
            this.txbUnidades.Name = "txbUnidades";
            this.txbUnidades.Size = new System.Drawing.Size(120, 23);
            this.txbUnidades.TabIndex = 5;
            // 
            // FormAgregarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 209);
            this.Controls.Add(this.txbUnidades);
            this.Controls.Add(this.lblAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblNombreProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAgregarStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAgregarStock";
            this.Load += new System.EventHandler(this.FormAgregarStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblAgregar;
        private System.Windows.Forms.TextBox txbUnidades;
    }
}