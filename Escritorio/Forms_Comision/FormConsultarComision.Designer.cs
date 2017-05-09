namespace Interfaz.Escritorio.Forms_Comision
{
    partial class FormConsultarComision
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
            this.lbl_porcentaje = new System.Windows.Forms.Label();
            this.nud_porcentaje = new System.Windows.Forms.NumericUpDown();
            this.lbl_fecha_editable = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.tl_comision.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_porcentaje)).BeginInit();
            this.SuspendLayout();
            // 
            // tl_comision
            // 
            this.tl_comision.ColumnCount = 2;
            this.tl_comision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tl_comision.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tl_comision.Controls.Add(this.lbl_fecha, 0, 1);
            this.tl_comision.Controls.Add(this.lbl_fecha_editable, 0, 1);
            this.tl_comision.Controls.Add(this.lbl_porcentaje, 0, 0);
            this.tl_comision.Controls.Add(this.nud_porcentaje, 1, 0);
            this.tl_comision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tl_comision.Location = new System.Drawing.Point(0, 0);
            this.tl_comision.Name = "tl_comision";
            this.tl_comision.RowCount = 2;
            this.tl_comision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tl_comision.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tl_comision.Size = new System.Drawing.Size(284, 81);
            this.tl_comision.TabIndex = 1;
            // 
            // lbl_porcentaje
            // 
            this.lbl_porcentaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_porcentaje.Location = new System.Drawing.Point(8, 13);
            this.lbl_porcentaje.Name = "lbl_porcentaje";
            this.lbl_porcentaje.Size = new System.Drawing.Size(126, 13);
            this.lbl_porcentaje.TabIndex = 5;
            this.lbl_porcentaje.Text = "Porcentaje: (%)";
            this.lbl_porcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nud_porcentaje
            // 
            this.nud_porcentaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nud_porcentaje.Enabled = false;
            this.nud_porcentaje.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_porcentaje.Location = new System.Drawing.Point(180, 10);
            this.nud_porcentaje.Name = "nud_porcentaje";
            this.nud_porcentaje.Size = new System.Drawing.Size(65, 20);
            this.nud_porcentaje.TabIndex = 8;
            this.nud_porcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_fecha_editable
            // 
            this.lbl_fecha_editable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_fecha_editable.Location = new System.Drawing.Point(150, 54);
            this.lbl_fecha_editable.Name = "lbl_fecha_editable";
            this.lbl_fecha_editable.Size = new System.Drawing.Size(126, 13);
            this.lbl_fecha_editable.TabIndex = 9;
            this.lbl_fecha_editable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_fecha.Location = new System.Drawing.Point(8, 54);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(126, 13);
            this.lbl_fecha.TabIndex = 10;
            this.lbl_fecha.Text = "Fecha de registro:";
            this.lbl_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormConsultarComision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 81);
            this.Controls.Add(this.tl_comision);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormConsultarComision";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Comisión";
            this.Load += new System.EventHandler(this.FormConsultarComision_Load);
            this.tl_comision.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_porcentaje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tl_comision;
        private System.Windows.Forms.Label lbl_porcentaje;
        private System.Windows.Forms.NumericUpDown nud_porcentaje;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_fecha_editable;
    }
}