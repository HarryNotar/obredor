namespace Interfaz.Escritorio.Forms_MedioAbono
{
    partial class FormDatosPago
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
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_montoSinAsignar = new System.Windows.Forms.Label();
            this.lbl_montoEfectivo = new System.Windows.Forms.Label();
            this.lbl_cantCuotas = new System.Windows.Forms.Label();
            this.lbl_montoCuota = new System.Windows.Forms.Label();
            this.lbl_montoFinanciado = new System.Windows.Forms.Label();
            this.lbl_tasaInteresAnual = new System.Windows.Forms.Label();
            this.nud_cantCuotas = new System.Windows.Forms.NumericUpDown();
            this.nud_tasaInteresAnual = new System.Windows.Forms.NumericUpDown();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_realizarVenta = new System.Windows.Forms.Button();
            this.nud_montoEfectivo = new System.Windows.Forms.NumericUpDown();
            this.nud_montoFinanciado = new System.Windows.Forms.NumericUpDown();
            this.tl_datosPago = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_total_editable = new System.Windows.Forms.Label();
            this.lbl_montoRestante_editable = new System.Windows.Forms.Label();
            this.lbl_montoCuota_editable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantCuotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tasaInteresAnual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_montoEfectivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_montoFinanciado)).BeginInit();
            this.tl_datosPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_total
            // 
            this.lbl_total.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(3, 9);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(79, 13);
            this.lbl_total.TabIndex = 0;
            this.lbl_total.Text = "Total a abonar:";
            // 
            // lbl_montoSinAsignar
            // 
            this.lbl_montoSinAsignar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_montoSinAsignar.AutoSize = true;
            this.lbl_montoSinAsignar.Location = new System.Drawing.Point(3, 41);
            this.lbl_montoSinAsignar.Name = "lbl_montoSinAsignar";
            this.lbl_montoSinAsignar.Size = new System.Drawing.Size(134, 13);
            this.lbl_montoSinAsignar.TabIndex = 1;
            this.lbl_montoSinAsignar.Text = "Monto restante sin asignar:";
            // 
            // lbl_montoEfectivo
            // 
            this.lbl_montoEfectivo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_montoEfectivo.AutoSize = true;
            this.lbl_montoEfectivo.Location = new System.Drawing.Point(3, 73);
            this.lbl_montoEfectivo.Name = "lbl_montoEfectivo";
            this.lbl_montoEfectivo.Size = new System.Drawing.Size(96, 13);
            this.lbl_montoEfectivo.TabIndex = 2;
            this.lbl_montoEfectivo.Text = "Monto en efectivo:";
            // 
            // lbl_cantCuotas
            // 
            this.lbl_cantCuotas.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_cantCuotas.AutoSize = true;
            this.lbl_cantCuotas.Location = new System.Drawing.Point(3, 169);
            this.lbl_cantCuotas.Name = "lbl_cantCuotas";
            this.lbl_cantCuotas.Size = new System.Drawing.Size(102, 13);
            this.lbl_cantCuotas.TabIndex = 5;
            this.lbl_cantCuotas.Text = "Cantidad de cuotas:";
            // 
            // lbl_montoCuota
            // 
            this.lbl_montoCuota.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_montoCuota.AutoSize = true;
            this.lbl_montoCuota.Location = new System.Drawing.Point(3, 201);
            this.lbl_montoCuota.Name = "lbl_montoCuota";
            this.lbl_montoCuota.Size = new System.Drawing.Size(88, 13);
            this.lbl_montoCuota.TabIndex = 6;
            this.lbl_montoCuota.Text = "Monto por cuota:";
            // 
            // lbl_montoFinanciado
            // 
            this.lbl_montoFinanciado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_montoFinanciado.AutoSize = true;
            this.lbl_montoFinanciado.Location = new System.Drawing.Point(3, 105);
            this.lbl_montoFinanciado.Name = "lbl_montoFinanciado";
            this.lbl_montoFinanciado.Size = new System.Drawing.Size(92, 13);
            this.lbl_montoFinanciado.TabIndex = 3;
            this.lbl_montoFinanciado.Text = "Monto financiado:";
            // 
            // lbl_tasaInteresAnual
            // 
            this.lbl_tasaInteresAnual.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_tasaInteresAnual.AutoSize = true;
            this.lbl_tasaInteresAnual.Location = new System.Drawing.Point(3, 137);
            this.lbl_tasaInteresAnual.Name = "lbl_tasaInteresAnual";
            this.lbl_tasaInteresAnual.Size = new System.Drawing.Size(112, 13);
            this.lbl_tasaInteresAnual.TabIndex = 4;
            this.lbl_tasaInteresAnual.Text = "Tasa de interés anual:";
            // 
            // nud_cantCuotas
            // 
            this.nud_cantCuotas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nud_cantCuotas.Location = new System.Drawing.Point(233, 166);
            this.nud_cantCuotas.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_cantCuotas.Name = "nud_cantCuotas";
            this.nud_cantCuotas.Size = new System.Drawing.Size(50, 20);
            this.nud_cantCuotas.TabIndex = 12;
            this.nud_cantCuotas.ValueChanged += new System.EventHandler(this.nud_cantCuotas_ValueChanged);
            // 
            // nud_tasaInteresAnual
            // 
            this.nud_tasaInteresAnual.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nud_tasaInteresAnual.DecimalPlaces = 2;
            this.nud_tasaInteresAnual.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_tasaInteresAnual.Location = new System.Drawing.Point(233, 134);
            this.nud_tasaInteresAnual.Name = "nud_tasaInteresAnual";
            this.nud_tasaInteresAnual.Size = new System.Drawing.Size(50, 20);
            this.nud_tasaInteresAnual.TabIndex = 11;
            this.nud_tasaInteresAnual.ValueChanged += new System.EventHandler(this.nud_tasaInteresAnual_ValueChanged);
            // 
            // btn_atras
            // 
            this.btn_atras.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_atras.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_atras.Location = new System.Drawing.Point(34, 235);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(75, 23);
            this.btn_atras.TabIndex = 14;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_realizarVenta
            // 
            this.btn_realizarVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_realizarVenta.Location = new System.Drawing.Point(164, 235);
            this.btn_realizarVenta.Name = "btn_realizarVenta";
            this.btn_realizarVenta.Size = new System.Drawing.Size(100, 23);
            this.btn_realizarVenta.TabIndex = 15;
            this.btn_realizarVenta.Text = "Realizar venta";
            this.btn_realizarVenta.UseVisualStyleBackColor = true;
            this.btn_realizarVenta.Click += new System.EventHandler(this.btn_realizarVenta_Click);
            // 
            // nud_montoEfectivo
            // 
            this.nud_montoEfectivo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nud_montoEfectivo.DecimalPlaces = 2;
            this.nud_montoEfectivo.Location = new System.Drawing.Point(182, 70);
            this.nud_montoEfectivo.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nud_montoEfectivo.Name = "nud_montoEfectivo";
            this.nud_montoEfectivo.Size = new System.Drawing.Size(101, 20);
            this.nud_montoEfectivo.TabIndex = 16;
            this.nud_montoEfectivo.ThousandsSeparator = true;
            this.nud_montoEfectivo.ValueChanged += new System.EventHandler(this.nud_montoEfectivo_ValueChanged);
            // 
            // nud_montoFinanciado
            // 
            this.nud_montoFinanciado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nud_montoFinanciado.DecimalPlaces = 2;
            this.nud_montoFinanciado.Location = new System.Drawing.Point(182, 102);
            this.nud_montoFinanciado.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nud_montoFinanciado.Name = "nud_montoFinanciado";
            this.nud_montoFinanciado.Size = new System.Drawing.Size(101, 20);
            this.nud_montoFinanciado.TabIndex = 17;
            this.nud_montoFinanciado.ThousandsSeparator = true;
            this.nud_montoFinanciado.ValueChanged += new System.EventHandler(this.nud_montoFinanciado_ValueChanged);
            // 
            // tl_datosPago
            // 
            this.tl_datosPago.ColumnCount = 2;
            this.tl_datosPago.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tl_datosPago.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tl_datosPago.Controls.Add(this.lbl_montoCuota_editable, 1, 6);
            this.tl_datosPago.Controls.Add(this.lbl_montoRestante_editable, 1, 1);
            this.tl_datosPago.Controls.Add(this.lbl_total, 0, 0);
            this.tl_datosPago.Controls.Add(this.nud_montoEfectivo, 1, 2);
            this.tl_datosPago.Controls.Add(this.lbl_montoSinAsignar, 0, 1);
            this.tl_datosPago.Controls.Add(this.nud_montoFinanciado, 1, 3);
            this.tl_datosPago.Controls.Add(this.lbl_montoEfectivo, 0, 2);
            this.tl_datosPago.Controls.Add(this.nud_tasaInteresAnual, 1, 4);
            this.tl_datosPago.Controls.Add(this.btn_realizarVenta, 1, 7);
            this.tl_datosPago.Controls.Add(this.nud_cantCuotas, 1, 5);
            this.tl_datosPago.Controls.Add(this.lbl_montoFinanciado, 0, 3);
            this.tl_datosPago.Controls.Add(this.btn_atras, 0, 7);
            this.tl_datosPago.Controls.Add(this.lbl_tasaInteresAnual, 0, 4);
            this.tl_datosPago.Controls.Add(this.lbl_cantCuotas, 0, 5);
            this.tl_datosPago.Controls.Add(this.lbl_montoCuota, 0, 6);
            this.tl_datosPago.Controls.Add(this.lbl_total_editable, 1, 0);
            this.tl_datosPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tl_datosPago.Location = new System.Drawing.Point(0, 0);
            this.tl_datosPago.Name = "tl_datosPago";
            this.tl_datosPago.RowCount = 8;
            this.tl_datosPago.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.21747F));
            this.tl_datosPago.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.21747F));
            this.tl_datosPago.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.21747F));
            this.tl_datosPago.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.21747F));
            this.tl_datosPago.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.21747F));
            this.tl_datosPago.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.21747F));
            this.tl_datosPago.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.21747F));
            this.tl_datosPago.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.4777F));
            this.tl_datosPago.Size = new System.Drawing.Size(286, 269);
            this.tl_datosPago.TabIndex = 18;
            // 
            // lbl_total_editable
            // 
            this.lbl_total_editable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_total_editable.AutoSize = true;
            this.lbl_total_editable.Location = new System.Drawing.Point(214, 9);
            this.lbl_total_editable.Name = "lbl_total_editable";
            this.lbl_total_editable.Size = new System.Drawing.Size(0, 13);
            this.lbl_total_editable.TabIndex = 18;
            this.lbl_total_editable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_montoRestante_editable
            // 
            this.lbl_montoRestante_editable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_montoRestante_editable.AutoSize = true;
            this.lbl_montoRestante_editable.Location = new System.Drawing.Point(214, 41);
            this.lbl_montoRestante_editable.Name = "lbl_montoRestante_editable";
            this.lbl_montoRestante_editable.Size = new System.Drawing.Size(0, 13);
            this.lbl_montoRestante_editable.TabIndex = 19;
            this.lbl_montoRestante_editable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_montoCuota_editable
            // 
            this.lbl_montoCuota_editable.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_montoCuota_editable.AutoSize = true;
            this.lbl_montoCuota_editable.Location = new System.Drawing.Point(214, 201);
            this.lbl_montoCuota_editable.Name = "lbl_montoCuota_editable";
            this.lbl_montoCuota_editable.Size = new System.Drawing.Size(0, 13);
            this.lbl_montoCuota_editable.TabIndex = 20;
            this.lbl_montoCuota_editable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormDatosPago
            // 
            this.AcceptButton = this.btn_realizarVenta;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_atras;
            this.ClientSize = new System.Drawing.Size(286, 269);
            this.Controls.Add(this.tl_datosPago);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormDatosPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del pago";
            ((System.ComponentModel.ISupportInitialize)(this.nud_cantCuotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tasaInteresAnual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_montoEfectivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_montoFinanciado)).EndInit();
            this.tl_datosPago.ResumeLayout(false);
            this.tl_datosPago.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_montoSinAsignar;
        private System.Windows.Forms.Label lbl_montoEfectivo;
        private System.Windows.Forms.Label lbl_cantCuotas;
        private System.Windows.Forms.Label lbl_montoCuota;
        private System.Windows.Forms.Label lbl_montoFinanciado;
        private System.Windows.Forms.Label lbl_tasaInteresAnual;
        private System.Windows.Forms.NumericUpDown nud_cantCuotas;
        private System.Windows.Forms.NumericUpDown nud_tasaInteresAnual;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_realizarVenta;
        private System.Windows.Forms.NumericUpDown nud_montoEfectivo;
        private System.Windows.Forms.NumericUpDown nud_montoFinanciado;
        private System.Windows.Forms.TableLayoutPanel tl_datosPago;
        private System.Windows.Forms.Label lbl_montoCuota_editable;
        private System.Windows.Forms.Label lbl_montoRestante_editable;
        private System.Windows.Forms.Label lbl_total_editable;
    }
}