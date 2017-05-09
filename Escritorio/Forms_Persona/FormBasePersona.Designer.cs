namespace Interfaz.Escritorio.Forms_Persona
{
    partial class FormBasePersona
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
            this.tl_personas = new System.Windows.Forms.TableLayoutPanel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_localidad = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_observaciones = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_telefonos = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_localidad = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.mtxt_telefono1 = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_telefono2 = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_telefono3 = new System.Windows.Forms.MaskedTextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_observaciones = new System.Windows.Forms.TextBox();
            this.mtxt_dni = new System.Windows.Forms.MaskedTextBox();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.cmb_perfil = new System.Windows.Forms.ComboBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lbl_perfil = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.tl_personas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tl_personas
            // 
            this.tl_personas.ColumnCount = 3;
            this.tl_personas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tl_personas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tl_personas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tl_personas.Controls.Add(this.btn_cancelar, 0, 12);
            this.tl_personas.Controls.Add(this.lbl_apellido, 0, 2);
            this.tl_personas.Controls.Add(this.lbl_nombre, 0, 3);
            this.tl_personas.Controls.Add(this.lbl_localidad, 0, 4);
            this.tl_personas.Controls.Add(this.lbl_email, 0, 9);
            this.tl_personas.Controls.Add(this.lbl_observaciones, 0, 10);
            this.tl_personas.Controls.Add(this.lbl_direccion, 0, 5);
            this.tl_personas.Controls.Add(this.lbl_telefonos, 0, 6);
            this.tl_personas.Controls.Add(this.txt_nombre, 1, 3);
            this.tl_personas.Controls.Add(this.txt_localidad, 1, 4);
            this.tl_personas.Controls.Add(this.txt_direccion, 1, 5);
            this.tl_personas.Controls.Add(this.mtxt_telefono1, 1, 6);
            this.tl_personas.Controls.Add(this.mtxt_telefono2, 1, 7);
            this.tl_personas.Controls.Add(this.mtxt_telefono3, 1, 8);
            this.tl_personas.Controls.Add(this.txt_email, 1, 9);
            this.tl_personas.Controls.Add(this.txt_observaciones, 0, 11);
            this.tl_personas.Controls.Add(this.mtxt_dni, 1, 1);
            this.tl_personas.Controls.Add(this.lbl_dni, 0, 1);
            this.tl_personas.Controls.Add(this.cmb_perfil, 1, 0);
            this.tl_personas.Controls.Add(this.txt_apellido, 1, 2);
            this.tl_personas.Controls.Add(this.lbl_perfil, 0, 0);
            this.tl_personas.Controls.Add(this.btn_aceptar, 2, 12);
            this.tl_personas.Controls.Add(this.btn_buscar, 1, 12);
            this.tl_personas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tl_personas.Location = new System.Drawing.Point(0, 0);
            this.tl_personas.Name = "tl_personas";
            this.tl_personas.RowCount = 13;
            this.tl_personas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tl_personas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tl_personas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tl_personas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tl_personas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tl_personas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tl_personas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tl_personas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tl_personas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tl_personas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tl_personas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tl_personas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tl_personas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tl_personas.Size = new System.Drawing.Size(284, 391);
            this.tl_personas.TabIndex = 0;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Location = new System.Drawing.Point(28, 365);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(60, 23);
            this.btn_cancelar.TabIndex = 19;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Location = new System.Drawing.Point(5, 63);
            this.lbl_apellido.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(107, 13);
            this.lbl_apellido.TabIndex = 2;
            this.lbl_apellido.Text = "Apellido: *";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(5, 89);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(107, 13);
            this.lbl_nombre.TabIndex = 4;
            this.lbl_nombre.Text = "Nombre: *";
            // 
            // lbl_localidad
            // 
            this.lbl_localidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_localidad.AutoSize = true;
            this.lbl_localidad.Location = new System.Drawing.Point(5, 115);
            this.lbl_localidad.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_localidad.Name = "lbl_localidad";
            this.lbl_localidad.Size = new System.Drawing.Size(107, 13);
            this.lbl_localidad.TabIndex = 6;
            this.lbl_localidad.Text = "Localidad: *";
            // 
            // lbl_email
            // 
            this.lbl_email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(5, 245);
            this.lbl_email.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(107, 13);
            this.lbl_email.TabIndex = 14;
            this.lbl_email.Text = "Dirección de e-mail: *";
            // 
            // lbl_observaciones
            // 
            this.lbl_observaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_observaciones.AutoSize = true;
            this.lbl_observaciones.Location = new System.Drawing.Point(5, 270);
            this.lbl_observaciones.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_observaciones.Name = "lbl_observaciones";
            this.lbl_observaciones.Size = new System.Drawing.Size(107, 13);
            this.lbl_observaciones.TabIndex = 16;
            this.lbl_observaciones.Text = "Observaciones:";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(5, 141);
            this.lbl_direccion.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(107, 13);
            this.lbl_direccion.TabIndex = 8;
            this.lbl_direccion.Text = "Dirección: *";
            // 
            // lbl_telefonos
            // 
            this.lbl_telefonos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_telefonos.AutoSize = true;
            this.lbl_telefonos.Location = new System.Drawing.Point(5, 167);
            this.lbl_telefonos.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_telefonos.Name = "lbl_telefonos";
            this.lbl_telefonos.Size = new System.Drawing.Size(107, 13);
            this.lbl_telefonos.TabIndex = 10;
            this.lbl_telefonos.Text = "Teléfonos: *";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tl_personas.SetColumnSpan(this.txt_nombre, 2);
            this.txt_nombre.Location = new System.Drawing.Point(129, 86);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(143, 20);
            this.txt_nombre.TabIndex = 5;
            // 
            // txt_localidad
            // 
            this.txt_localidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tl_personas.SetColumnSpan(this.txt_localidad, 2);
            this.txt_localidad.Location = new System.Drawing.Point(129, 112);
            this.txt_localidad.Name = "txt_localidad";
            this.txt_localidad.Size = new System.Drawing.Size(143, 20);
            this.txt_localidad.TabIndex = 7;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tl_personas.SetColumnSpan(this.txt_direccion, 2);
            this.txt_direccion.Location = new System.Drawing.Point(129, 138);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(143, 20);
            this.txt_direccion.TabIndex = 9;
            // 
            // mtxt_telefono1
            // 
            this.mtxt_telefono1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tl_personas.SetColumnSpan(this.mtxt_telefono1, 2);
            this.mtxt_telefono1.Location = new System.Drawing.Point(129, 164);
            this.mtxt_telefono1.Mask = "9999-999999";
            this.mtxt_telefono1.Name = "mtxt_telefono1";
            this.mtxt_telefono1.Size = new System.Drawing.Size(142, 20);
            this.mtxt_telefono1.SkipLiterals = false;
            this.mtxt_telefono1.TabIndex = 11;
            this.mtxt_telefono1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxt_telefono2
            // 
            this.mtxt_telefono2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tl_personas.SetColumnSpan(this.mtxt_telefono2, 2);
            this.mtxt_telefono2.Location = new System.Drawing.Point(129, 190);
            this.mtxt_telefono2.Mask = "9999-999999";
            this.mtxt_telefono2.Name = "mtxt_telefono2";
            this.mtxt_telefono2.Size = new System.Drawing.Size(143, 20);
            this.mtxt_telefono2.SkipLiterals = false;
            this.mtxt_telefono2.TabIndex = 12;
            this.mtxt_telefono2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxt_telefono3
            // 
            this.mtxt_telefono3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tl_personas.SetColumnSpan(this.mtxt_telefono3, 2);
            this.mtxt_telefono3.Location = new System.Drawing.Point(129, 216);
            this.mtxt_telefono3.Mask = "9999-999999";
            this.mtxt_telefono3.Name = "mtxt_telefono3";
            this.mtxt_telefono3.Size = new System.Drawing.Size(143, 20);
            this.mtxt_telefono3.SkipLiterals = false;
            this.mtxt_telefono3.TabIndex = 13;
            this.mtxt_telefono3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_email
            // 
            this.txt_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tl_personas.SetColumnSpan(this.txt_email, 2);
            this.txt_email.Location = new System.Drawing.Point(129, 242);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(143, 20);
            this.txt_email.TabIndex = 15;
            // 
            // txt_observaciones
            // 
            this.txt_observaciones.AllowDrop = true;
            this.txt_observaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tl_personas.SetColumnSpan(this.txt_observaciones, 3);
            this.txt_observaciones.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_observaciones.Location = new System.Drawing.Point(3, 291);
            this.txt_observaciones.Multiline = true;
            this.txt_observaciones.Name = "txt_observaciones";
            this.txt_observaciones.Size = new System.Drawing.Size(278, 68);
            this.txt_observaciones.TabIndex = 17;
            // 
            // mtxt_dni
            // 
            this.mtxt_dni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tl_personas.SetColumnSpan(this.mtxt_dni, 2);
            this.mtxt_dni.Location = new System.Drawing.Point(129, 32);
            this.mtxt_dni.Margin = new System.Windows.Forms.Padding(5);
            this.mtxt_dni.Mask = "99.999.999";
            this.mtxt_dni.Name = "mtxt_dni";
            this.mtxt_dni.Size = new System.Drawing.Size(143, 20);
            this.mtxt_dni.TabIndex = 1;
            this.mtxt_dni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_dni
            // 
            this.lbl_dni.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.Location = new System.Drawing.Point(5, 35);
            this.lbl_dni.Margin = new System.Windows.Forms.Padding(5);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(107, 13);
            this.lbl_dni.TabIndex = 0;
            this.lbl_dni.Text = "DNI: *";
            // 
            // cmb_perfil
            // 
            this.cmb_perfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tl_personas.SetColumnSpan(this.cmb_perfil, 2);
            this.cmb_perfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_perfil.FormattingEnabled = true;
            this.cmb_perfil.Items.AddRange(new object[] {
            "Administrador",
            "General",
            "Consultor"});
            this.cmb_perfil.Location = new System.Drawing.Point(129, 3);
            this.cmb_perfil.Name = "cmb_perfil";
            this.cmb_perfil.Size = new System.Drawing.Size(143, 21);
            this.cmb_perfil.TabIndex = 72;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tl_personas.SetColumnSpan(this.txt_apellido, 2);
            this.txt_apellido.Location = new System.Drawing.Point(129, 60);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(143, 20);
            this.txt_apellido.TabIndex = 3;
            // 
            // lbl_perfil
            // 
            this.lbl_perfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_perfil.AutoSize = true;
            this.lbl_perfil.Location = new System.Drawing.Point(3, 7);
            this.lbl_perfil.Name = "lbl_perfil";
            this.lbl_perfil.Size = new System.Drawing.Size(111, 13);
            this.lbl_perfil.TabIndex = 73;
            this.lbl_perfil.Text = "Perfil: *";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_aceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_aceptar.Location = new System.Drawing.Point(201, 365);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(80, 23);
            this.btn_aceptar.TabIndex = 18;
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_buscar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_buscar.Location = new System.Drawing.Point(120, 365);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 74;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // FormBasePersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(284, 391);
            this.Controls.Add(this.tl_personas);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(340, 600);
            this.MinimumSize = new System.Drawing.Size(300, 430);
            this.Name = "FormBasePersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tl_personas.ResumeLayout(false);
            this.tl_personas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tl_personas;
        protected System.Windows.Forms.MaskedTextBox mtxt_dni;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_localidad;
        private System.Windows.Forms.Label lbl_observaciones;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_telefonos;
        private System.Windows.Forms.Label lbl_direccion;
        protected System.Windows.Forms.TextBox txt_apellido;
        protected System.Windows.Forms.TextBox txt_nombre;
        protected System.Windows.Forms.TextBox txt_localidad;
        protected System.Windows.Forms.TextBox txt_direccion;
        protected System.Windows.Forms.MaskedTextBox mtxt_telefono1;
        protected System.Windows.Forms.MaskedTextBox mtxt_telefono2;
        protected System.Windows.Forms.MaskedTextBox mtxt_telefono3;
        protected System.Windows.Forms.TextBox txt_email;
        protected System.Windows.Forms.TextBox txt_observaciones;
        protected System.Windows.Forms.Button btn_cancelar;
        protected System.Windows.Forms.Button btn_aceptar;
        protected System.Windows.Forms.ComboBox cmb_perfil;
        protected System.Windows.Forms.Label lbl_perfil;
        protected System.Windows.Forms.Button btn_buscar;
    }
}