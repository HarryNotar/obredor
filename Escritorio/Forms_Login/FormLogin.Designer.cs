namespace Interfaz.Escritorio.Forms_Login
{
    partial class FormLogin
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
            this.mtxt_dni = new System.Windows.Forms.MaskedTextBox();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.txt_contraseña = new System.Windows.Forms.TextBox();
            this.btn_olvideContraseña = new System.Windows.Forms.Button();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mtxt_dni
            // 
            this.mtxt_dni.Location = new System.Drawing.Point(153, 10);
            this.mtxt_dni.Margin = new System.Windows.Forms.Padding(5);
            this.mtxt_dni.Mask = "99.999.999";
            this.mtxt_dni.Name = "mtxt_dni";
            this.mtxt_dni.Size = new System.Drawing.Size(98, 20);
            this.mtxt_dni.TabIndex = 2;
            this.mtxt_dni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_dni
            // 
            this.lbl_dni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(13, 14);
            this.lbl_dni.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(36, 13);
            this.lbl_dni.TabIndex = 0;
            this.lbl_dni.Text = "DNI: *";
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.Location = new System.Drawing.Point(13, 41);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(71, 13);
            this.lbl_contraseña.TabIndex = 1;
            this.lbl_contraseña.Text = "Contraseña: *";
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.Location = new System.Drawing.Point(153, 38);
            this.txt_contraseña.MaxLength = 8;
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.PasswordChar = '*';
            this.txt_contraseña.Size = new System.Drawing.Size(98, 20);
            this.txt_contraseña.TabIndex = 3;
            // 
            // btn_olvideContraseña
            // 
            this.btn_olvideContraseña.Location = new System.Drawing.Point(16, 77);
            this.btn_olvideContraseña.Name = "btn_olvideContraseña";
            this.btn_olvideContraseña.Size = new System.Drawing.Size(131, 23);
            this.btn_olvideContraseña.TabIndex = 4;
            this.btn_olvideContraseña.Text = "Olvidé mi contraseña";
            this.btn_olvideContraseña.UseVisualStyleBackColor = true;
            this.btn_olvideContraseña.Click += new System.EventHandler(this.btn_olvideContraseña_Click);
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Location = new System.Drawing.Point(176, 77);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(75, 23);
            this.btn_ingresar.TabIndex = 5;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.btn_ingresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 111);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.btn_olvideContraseña);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.lbl_contraseña);
            this.Controls.Add(this.mtxt_dni);
            this.Controls.Add(this.lbl_dni);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso al sistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtxt_dni;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.Label lbl_contraseña;
        private System.Windows.Forms.TextBox txt_contraseña;
        private System.Windows.Forms.Button btn_olvideContraseña;
        private System.Windows.Forms.Button btn_ingresar;
    }
}