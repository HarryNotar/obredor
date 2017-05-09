namespace Interfaz.Escritorio.Forms_Vehiculo.AB_Modelo
{
    partial class FormRegistrarModelo
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
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.cmb_marca = new System.Windows.Forms.ComboBox();
            this.tl_registrarModelo = new System.Windows.Forms.TableLayoutPanel();
            this.tl_registrarModelo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_guardar.Location = new System.Drawing.Point(161, 70);
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
            this.btn_cancelar.Location = new System.Drawing.Point(19, 70);
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
            this.txt_nombre.Location = new System.Drawing.Point(132, 38);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(132, 20);
            this.txt_nombre.TabIndex = 3;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(33, 41);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "Nombre:";
            this.lbl_nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_marca
            // 
            this.lbl_marca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Location = new System.Drawing.Point(36, 9);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(40, 13);
            this.lbl_marca.TabIndex = 0;
            this.lbl_marca.Text = "Marca:";
            this.lbl_marca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_marca
            // 
            this.cmb_marca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_marca.FormattingEnabled = true;
            this.cmb_marca.Location = new System.Drawing.Point(132, 5);
            this.cmb_marca.Name = "cmb_marca";
            this.cmb_marca.Size = new System.Drawing.Size(132, 21);
            this.cmb_marca.TabIndex = 1;
            // 
            // tl_registrarModelo
            // 
            this.tl_registrarModelo.ColumnCount = 2;
            this.tl_registrarModelo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tl_registrarModelo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tl_registrarModelo.Controls.Add(this.lbl_marca, 0, 0);
            this.tl_registrarModelo.Controls.Add(this.btn_guardar, 1, 2);
            this.tl_registrarModelo.Controls.Add(this.cmb_marca, 1, 0);
            this.tl_registrarModelo.Controls.Add(this.btn_cancelar, 0, 2);
            this.tl_registrarModelo.Controls.Add(this.lbl_nombre, 0, 1);
            this.tl_registrarModelo.Controls.Add(this.txt_nombre, 1, 1);
            this.tl_registrarModelo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tl_registrarModelo.Location = new System.Drawing.Point(0, 0);
            this.tl_registrarModelo.Name = "tl_registrarModelo";
            this.tl_registrarModelo.RowCount = 3;
            this.tl_registrarModelo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tl_registrarModelo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tl_registrarModelo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tl_registrarModelo.Size = new System.Drawing.Size(284, 99);
            this.tl_registrarModelo.TabIndex = 6;
            // 
            // FormRegistrarModelo
            // 
            this.AcceptButton = this.btn_guardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(284, 99);
            this.Controls.Add(this.tl_registrarModelo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormRegistrarModelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registo de Modelo";
            this.Load += new System.EventHandler(this.frm_registrarModelo_Load);
            this.tl_registrarModelo.ResumeLayout(false);
            this.tl_registrarModelo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_marca;
        private System.Windows.Forms.ComboBox cmb_marca;
        private System.Windows.Forms.TableLayoutPanel tl_registrarModelo;
    }
}