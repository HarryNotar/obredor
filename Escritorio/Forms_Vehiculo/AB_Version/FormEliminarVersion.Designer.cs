namespace Interfaz.Escritorio.Forms_Vehiculo.AB_Version
{
    partial class FormEliminarVersion
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.cmb_marca = new System.Windows.Forms.ComboBox();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.cmb_modelo = new System.Windows.Forms.ComboBox();
            this.lbl_version = new System.Windows.Forms.Label();
            this.cmb_version = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_eliminar, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_cancelar, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_marca, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmb_marca, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_modelo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmb_modelo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_version, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmb_version, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 141);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_eliminar.Location = new System.Drawing.Point(175, 111);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 12;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Location = new System.Drawing.Point(33, 111);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 11;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_marca
            // 
            this.lbl_marca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Location = new System.Drawing.Point(51, 11);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(40, 13);
            this.lbl_marca.TabIndex = 13;
            this.lbl_marca.Text = "Marca:";
            // 
            // cmb_marca
            // 
            this.cmb_marca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_marca.FormattingEnabled = true;
            this.cmb_marca.Location = new System.Drawing.Point(151, 7);
            this.cmb_marca.Name = "cmb_marca";
            this.cmb_marca.Size = new System.Drawing.Size(123, 21);
            this.cmb_marca.TabIndex = 14;
            this.cmb_marca.SelectedIndexChanged += new System.EventHandler(this.cmb_marca_SelectedIndexChanged);
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.Location = new System.Drawing.Point(48, 46);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(45, 13);
            this.lbl_modelo.TabIndex = 15;
            this.lbl_modelo.Text = "Modelo:";
            // 
            // cmb_modelo
            // 
            this.cmb_modelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_modelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_modelo.FormattingEnabled = true;
            this.cmb_modelo.Location = new System.Drawing.Point(151, 42);
            this.cmb_modelo.Name = "cmb_modelo";
            this.cmb_modelo.Size = new System.Drawing.Size(123, 21);
            this.cmb_modelo.TabIndex = 16;
            this.cmb_modelo.SelectedIndexChanged += new System.EventHandler(this.cmb_modelo_SelectedIndexChanged);
            // 
            // lbl_version
            // 
            this.lbl_version.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_version.AutoSize = true;
            this.lbl_version.Location = new System.Drawing.Point(48, 81);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(45, 13);
            this.lbl_version.TabIndex = 17;
            this.lbl_version.Text = "Versión:";
            // 
            // cmb_version
            // 
            this.cmb_version.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmb_version.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_version.FormattingEnabled = true;
            this.cmb_version.Location = new System.Drawing.Point(151, 77);
            this.cmb_version.Name = "cmb_version";
            this.cmb_version.Size = new System.Drawing.Size(123, 21);
            this.cmb_version.TabIndex = 18;
            // 
            // FormEliminarVersion
            // 
            this.AcceptButton = this.btn_eliminar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(284, 141);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormEliminarVersion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminación de Versión";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_marca;
        protected System.Windows.Forms.ComboBox cmb_marca;
        private System.Windows.Forms.Label lbl_modelo;
        protected System.Windows.Forms.ComboBox cmb_modelo;
        private System.Windows.Forms.Label lbl_version;
        protected System.Windows.Forms.ComboBox cmb_version;
    }
}