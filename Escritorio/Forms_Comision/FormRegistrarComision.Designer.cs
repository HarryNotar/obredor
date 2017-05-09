namespace Interfaz.Escritorio.Forms_Comision
{
    partial class FormRegistrarComision
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
            this.tl_comision = new System.Windows.Forms.TableLayoutPanel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_porcentaje = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.nud_porcentaje = new System.Windows.Forms.NumericUpDown();
            this.tl_comision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_porcentaje)).BeginInit();
            this.SuspendLayout();
            // 
            // tl_comision
            // 
            this.tl_comision.ColumnCount = 2;
            this.tl_comision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tl_comision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tl_comision.Controls.Add(this.btn_cancelar, 0, 1);
            this.tl_comision.Controls.Add(this.lbl_porcentaje, 0, 0);
            this.tl_comision.Controls.Add(this.btn_guardar, 1, 1);
            this.tl_comision.Controls.Add(this.nud_porcentaje, 1, 0);
            this.tl_comision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tl_comision.Location = new System.Drawing.Point(0, 0);
            this.tl_comision.Name = "tl_comision";
            this.tl_comision.RowCount = 2;
            this.tl_comision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tl_comision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tl_comision.Size = new System.Drawing.Size(284, 81);
            this.tl_comision.TabIndex = 0;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Location = new System.Drawing.Point(33, 53);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_porcentaje
            // 
            this.lbl_porcentaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_porcentaje.Location = new System.Drawing.Point(8, 17);
            this.lbl_porcentaje.Name = "lbl_porcentaje";
            this.lbl_porcentaje.Size = new System.Drawing.Size(126, 13);
            this.lbl_porcentaje.TabIndex = 5;
            this.lbl_porcentaje.Text = "Porcentaje: (%)";
            this.lbl_porcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_guardar.Location = new System.Drawing.Point(175, 53);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 7;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // nud_porcentaje
            // 
            this.nud_porcentaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nud_porcentaje.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_porcentaje.Location = new System.Drawing.Point(180, 14);
            this.nud_porcentaje.Name = "nud_porcentaje";
            this.nud_porcentaje.Size = new System.Drawing.Size(65, 20);
            this.nud_porcentaje.TabIndex = 8;
            this.nud_porcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormRegistrarComision
            // 
            this.AcceptButton = this.btn_guardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(284, 81);
            this.Controls.Add(this.tl_comision);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormRegistrarComision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Comisión";
            this.tl_comision.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_porcentaje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tl_comision;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_porcentaje;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.NumericUpDown nud_porcentaje;
    }
}