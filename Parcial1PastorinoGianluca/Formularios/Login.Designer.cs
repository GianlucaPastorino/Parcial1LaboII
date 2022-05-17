
namespace Formularios
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.txbContraseña = new System.Windows.Forms.TextBox();
            this.btnLoguear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(116, 143);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.PlaceholderText = "DNI";
            this.txbUsuario.Size = new System.Drawing.Size(188, 23);
            this.txbUsuario.TabIndex = 0;
            // 
            // txbContraseña
            // 
            this.txbContraseña.Location = new System.Drawing.Point(116, 192);
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.PasswordChar = '*';
            this.txbContraseña.PlaceholderText = "Contraseña";
            this.txbContraseña.Size = new System.Drawing.Size(188, 23);
            this.txbContraseña.TabIndex = 1;
            // 
            // btnLoguear
            // 
            this.btnLoguear.Location = new System.Drawing.Point(145, 265);
            this.btnLoguear.Name = "btnLoguear";
            this.btnLoguear.Size = new System.Drawing.Size(119, 38);
            this.btnLoguear.TabIndex = 2;
            this.btnLoguear.Text = "Iniciar sesión";
            this.btnLoguear.UseVisualStyleBackColor = true;
            this.btnLoguear.Click += new System.EventHandler(this.btnLoguear_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 450);
            this.Controls.Add(this.btnLoguear);
            this.Controls.Add(this.txbContraseña);
            this.Controls.Add(this.txbUsuario);
            this.Name = "Login";
            this.Text = "LES UTN - ¡Bienvenido!";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.TextBox txbContraseña;
        private System.Windows.Forms.Button btnLoguear;
    }
}

