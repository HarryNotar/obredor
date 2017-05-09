namespace Interfaz.Escritorio.Forms_Vehiculo.AB_Version
{
    partial class FormRegistrarVersion
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
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.cmb_modelo = new System.Windows.Forms.ComboBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.cmb_marca = new System.Windows.Forms.ComboBox();
            this.tl_registroVersion = new System.Windows.Forms.TableLayoutPanel();
            this.tl_registroVersion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.Location = new System.Drawing.Point(34, 38);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(45, 13);
            this.lbl_modelo.TabIndex = 0;
            this.lbl_modelo.Text = "Modelo:";
            this.lbl_modelo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_modelo
            // 
            this.cmb_modelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_modelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_modelo.FormattingEnabled = true;
            this.cmb_modelo.Location = new System.Drawing.Point(132, 34);
            this.cmb_modelo.Name = "cmb_modelo";
            this.cmb_modelo.Size = new System.Drawing.Size(132, 21);
            this.cmb_modelo.TabIndex = 1;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_guardar.Location = new System.Drawing.Point(161, 94);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 5;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Location = new System.Drawing.Point(19, 94);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nombre.Location = new System.Drawing.Point(132, 65);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(132, 20);
            this.txt_nombre.TabIndex = 3;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(33, 68);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "Nombre:";
            this.lbl_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_marca
            // 
            this.lbl_marca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Location = new System.Drawing.Point(36, 8);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(40, 13);
            this.lbl_marca.TabIndex = 6;
            this.lbl_marca.Text = "Marca:";
            this.lbl_marca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_marca
            // 
            this.cmb_marca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_marca.FormattingEnabled = true;
            this.cmb_marca.Location = new System.Drawing.Point(132, 4);
            this.cmb_marca.Name = "cmb_marca";
            this.cmb_marca.Size = new System.Drawing.Size(132, 21);
            this.cmb_marca.TabIndex = 7;
            this.cmb_marca.SelectedIndexChanged += new System.EventHandler(this.cmb_marca_SelectedIndexChanged);
            // 
            // tl_registroVersion
            // 
            this.tl_registroVersion.ColumnCount = 2;
            this.tl_registroVersion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tl_registroVersion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tl_registroVersion.Controls.Add(this.lbl_marca, 0, 0);
            this.tl_registroVersion.Controls.Add(this.btn_guardar, 1, 3);
            this.tl_registroVersion.Controls.Add(this.cmb_modelo, 1, 1);
            this.tl_registroVersion.Controls.Add(this.txt_nombre, 1, 2);
            this.tl_registroVersion.Controls.Add(this.cmb_marca, 1, 0);
            this.tl_registroVersion.Controls.Add(this.lbl_modelo, 0, 1);
            this.tl_registroVersion.Controls.Add(this.lbl_nombre, 0, 2);
            this.tl_registroVersion.Controls.Add(this.btn_cancelar, 0, 3);
            this.tl_registroVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tl_registroVersion.Location = new System.Drawing.Point(0, 0);
            this.tl_registroVersion.Name = "tl_registroVersion";
            this.tl_registroVersion.RowCount = 4;
            this.tl_registroVersion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tl_registroVersion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tl_registroVersion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tl_registroVersion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tl_registroVersion.Size = new System.Drawing.Size(284, 121);
            this.tl_registroVersion.TabIndex = 8;
            // 
            // FormRegistrarVersion
            // 
            this.AcceptButton = this.btn_guardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(284, 121);
            this.Controls.Add(this.tl_registroVersion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormRegistrarVersion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Versión";
            this.Load += new System.EventHandler(this.frm_registrarVersion_Load);
            this.tl_registroVersion.ResumeLayout(false);
            this.tl_registroVersion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.ComboBox cmb_modelo;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.ComboBox cmb_marca;
        private System.Windows.Forms.TableLayoutPanel tl_registroVersion;
    }
}