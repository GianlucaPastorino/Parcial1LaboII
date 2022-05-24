
namespace Formularios
{
    partial class FormCobrar
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
            this.lblCobrarPedido = new System.Windows.Forms.Label();
            this.lblPrecioFinal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cboMedioDePago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEstacionamiento = new System.Windows.Forms.CheckBox();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCobrarPedido
            // 
            this.lblCobrarPedido.AutoSize = true;
            this.lblCobrarPedido.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCobrarPedido.Location = new System.Drawing.Point(90, 19);
            this.lblCobrarPedido.Name = "lblCobrarPedido";
            this.lblCobrarPedido.Size = new System.Drawing.Size(140, 28);
            this.lblCobrarPedido.TabIndex = 0;
            this.lblCobrarPedido.Text = "Cobrar pedido";
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecioFinal.Location = new System.Drawing.Point(135, 132);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(87, 21);
            this.lblPrecioFinal.TabIndex = 1;
            this.lblPrecioFinal.Text = "label2";
            this.lblPrecioFinal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(99, 132);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 21);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total:";
            // 
            // cboMedioDePago
            // 
            this.cboMedioDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMedioDePago.FormattingEnabled = true;
            this.cboMedioDePago.Location = new System.Drawing.Point(146, 92);
            this.cboMedioDePago.Name = "cboMedioDePago";
            this.cboMedioDePago.Size = new System.Drawing.Size(121, 23);
            this.cboMedioDePago.TabIndex = 3;
            this.cboMedioDePago.SelectedIndexChanged += new System.EventHandler(this.cboMedioDePago_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Medio de Pago";
            // 
            // cbEstacionamiento
            // 
            this.cbEstacionamiento.AutoSize = true;
            this.cbEstacionamiento.Location = new System.Drawing.Point(103, 67);
            this.cbEstacionamiento.Name = "cbEstacionamiento";
            this.cbEstacionamiento.Size = new System.Drawing.Size(114, 19);
            this.cbEstacionamiento.TabIndex = 5;
            this.cbEstacionamiento.Text = "Estacionamiento";
            this.cbEstacionamiento.UseVisualStyleBackColor = true;
            this.cbEstacionamiento.CheckedChanged += new System.EventHandler(this.cbEstacionamiento_CheckedChanged);
            // 
            // btnCobrar
            // 
            this.btnCobrar.Location = new System.Drawing.Point(164, 176);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(75, 23);
            this.btnCobrar.TabIndex = 6;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(74, 176);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormCobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 215);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.cbEstacionamiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMedioDePago);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPrecioFinal);
            this.Controls.Add(this.lblCobrarPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCobrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobrar Pedido";
            this.Load += new System.EventHandler(this.FormCobrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCobrarPedido;
        private System.Windows.Forms.Label lblPrecioFinal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cboMedioDePago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbEstacionamiento;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnCancelar;
    }
}