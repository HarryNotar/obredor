namespace Interfaz.Escritorio.Forms_Login
{
    partial class FormRecuperarContraseña
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
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.btn_recuperar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.mtxt_dni = new System.Windows.Forms.MaskedTextBox();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(11, 39);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(107, 13);
            this.lbl_email.TabIndex = 1;
            this.lbl_email.Text = "Dirección de e-mail: *";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(182, 36);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(98, 20);
            this.txt_email.TabIndex = 3;
            // 
            // btn_recuperar
            // 
            this.btn_recuperar.Location = new System.Drawing.Point(162, 78);
            this.btn_recuperar.Name = "btn_recuperar";
            this.btn_recuperar.Size = new System.Drawing.Size(122, 23);
            this.btn_recuperar.TabIndex = 5;
            this.btn_recuperar.Text = "Recuperar contraseña";
            this.btn_recuperar.UseVisualStyleBackColor = true;
            this.btn_recuperar.Click += new System.EventHandler(this.btn_recuperar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Location = new System.Drawing.Point(14, 78);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(60, 23);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // mtxt_dni
            // 
            this.mtxt_dni.Location = new System.Drawing.Point(182, 9);
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
            this.lbl_dni.Location = new System.Drawing.Point(11, 12);
            this.lbl_dni.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(36, 13);
            this.lbl_dni.TabIndex = 0;
            this.lbl_dni.Text = "DNI: *";
            // 
            // frm_recuperarContraseña
            // 
            this.AcceptButton = this.btn_recuperar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(294, 111);
            this.Controls.Add(this.mtxt_dni);
            this.Controls.Add(this.lbl_dni);
            this.Controls.Add(this.btn_recuperar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_recuperarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Recuperar contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_recuperar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.MaskedTextBox mtxt_dni;
        private System.Windows.Forms.Label lbl_dni;
    }
}