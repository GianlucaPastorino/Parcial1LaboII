
namespace Formularios
{
    partial class FormLogin
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
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txbUsuario
            // 
            this.txbUsuario.Location = new System.Drawing.Point(113, 134);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.PlaceholderText = "DNI";
            this.txbUsuario.Size = new System.Drawing.Size(188, 23);
            this.txbUsuario.TabIndex = 0;
            // 
            // txbContraseña
            // 
            this.txbContraseña.Location = new System.Drawing.Point(113, 172);
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.PasswordChar = '*';
            this.txbContraseña.PlaceholderText = "Contraseña";
            this.txbContraseña.Size = new System.Drawing.Size(188, 23);
            this.txbContraseña.TabIndex = 1;
            // 
            // btnLoguear
            // 
            this.btnLoguear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLoguear.Location = new System.Drawing.Point(148, 214);
            this.btnLoguear.Name = "btnLoguear";
            this.btnLoguear.Size = new System.Drawing.Size(119, 38);
            this.btnLoguear.TabIndex = 2;
            this.btnLoguear.Text = "Iniciar sesión";
            this.btnLoguear.UseVisualStyleBackColor = true;
            this.btnLoguear.Click += new System.EventHandler(this.btnLoguear_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(328, 269);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Location = new System.Drawing.Point(328, 298);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(75, 23);
            this.btnEmpleado.TabIndex = 4;
            this.btnEmpleado.Text = "Empleado";
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::Formularios.Properties.Resources.Les_UTN_logo;
            this.pbxLogo.Location = new System.Drawing.Point(94, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(227, 117);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 5;
            this.pbxLogo.TabStop = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMinimizar.Location = new System.Drawing.Point(361, 2);
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
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCerrar.Location = new System.Drawing.Point(387, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(26, 23);
            this.btnCerrar.TabIndex = 37;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(415, 333);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.btnEmpleado);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnLoguear);
            this.Controls.Add(this.txbContraseña);
            this.Controls.Add(this.txbUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LES UTN - ¡Bienvenido!";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.TextBox txbContraseña;
        private System.Windows.Forms.Button btnLoguear;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
    }
}

