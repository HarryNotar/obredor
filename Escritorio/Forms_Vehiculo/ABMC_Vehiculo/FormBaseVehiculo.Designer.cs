namespace Interfaz.Escritorio.Forms_Vehiculo.ABMC_Vehiculo
{
    partial class FormBaseVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaseVehiculo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmb_marca = new System.Windows.Forms.ComboBox();
            this.lbl_marca = new System.Windows.Forms.Label();
            this.cmb_modelo = new System.Windows.Forms.ComboBox();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.cmb_version = new System.Windows.Forms.ComboBox();
            this.lbl_version = new System.Windows.Forms.Label();
            this.cmb_uso = new System.Windows.Forms.ComboBox();
            this.lbl_uso = new System.Windows.Forms.Label();
            this.lbl_añoPatentamiento = new System.Windows.Forms.Label();
            this.cmb_color = new System.Windows.Forms.ComboBox();
            this.lbl_color = new System.Windows.Forms.Label();
            this.lbl_dominio = new System.Windows.Forms.Label();
            this.lbl_kilometraje = new System.Windows.Forms.Label();
            this.lbl_valorAdquisicion = new System.Windows.Forms.Label();
            this.lbl_nroChasis = new System.Windows.Forms.Label();
            this.lbl_nroMotor = new System.Windows.Forms.Label();
            this.txt_nroMotor = new System.Windows.Forms.TextBox();
            this.lbl_observaciones = new System.Windows.Forms.Label();
            this.txt_observaciones = new System.Windows.Forms.TextBox();
            this.btn_registrarMarca = new System.Windows.Forms.Button();
            this.btn_registrarModelo = new System.Windows.Forms.Button();
            this.btn_registrarVersion = new System.Windows.Forms.Button();
            this.btn_registrarColor = new System.Windows.Forms.Button();
            this.nud_añoPatentamiento = new System.Windows.Forms.NumericUpDown();
            this.mtxt_dominio = new System.Windows.Forms.MaskedTextBox();
            this.nud_kilometraje = new System.Windows.Forms.NumericUpDown();
            this.lbl_valorVenta = new System.Windows.Forms.Label();
            this.nud_valorAdquisicion = new System.Windows.Forms.NumericUpDown();
            this.nud_valorVenta = new System.Windows.Forms.NumericUpDown();
            this.mtxt_nroChasis = new System.Windows.Forms.MaskedTextBox();
            this.tl_registrarVehiculo = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_vehiculos = new System.Windows.Forms.DataGridView();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_fechaRegistro = new System.Windows.Forms.Label();
            this.txt_fechaRegistro = new System.Windows.Forms.TextBox();
            this.lbl_tipoEstado = new System.Windows.Forms.Label();
            this.txt_tipoEstado = new System.Windows.Forms.TextBox();
            this.lbl_fechaEstado = new System.Windows.Forms.Label();
            this.txt_fechaEstado = new System.Windows.Forms.TextBox();
            this.lbl_vehiculos = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_aceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_añoPatentamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_kilometraje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_valorAdquisicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_valorVenta)).BeginInit();
            this.tl_registrarVehiculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_marca
            // 
            this.cmb_marca.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmb_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_marca.FormattingEnabled = true;
            this.cmb_marca.Location = new System.Drawing.Point(166, 3);
            this.cmb_marca.Name = "cmb_marca";
            this.cmb_marca.Size = new System.Drawing.Size(123, 21);
            this.cmb_marca.TabIndex = 0;
            this.cmb_marca.SelectedIndexChanged += new System.EventHandler(this.cmb_marca_SelectedIndexChanged);
            // 
            // lbl_marca
            // 
            this.lbl_marca.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_marca.AutoSize = true;
            this.lbl_marca.Location = new System.Drawing.Point(3, 7);
            this.lbl_marca.Name = "lbl_marca";
            this.lbl_marca.Size = new System.Drawing.Size(40, 13);
            this.lbl_marca.TabIndex = 0;
            this.lbl_marca.Text = "Marca:";
            // 
            // cmb_modelo
            // 
            this.cmb_modelo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmb_modelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_modelo.FormattingEnabled = true;
            this.cmb_modelo.Location = new System.Drawing.Point(166, 30);
            this.cmb_modelo.Name = "cmb_modelo";
            this.cmb_modelo.Size = new System.Drawing.Size(123, 21);
            this.cmb_modelo.TabIndex = 2;
            this.cmb_modelo.SelectedIndexChanged += new System.EventHandler(this.cmb_modelo_SelectedIndexChanged);
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.Location = new System.Drawing.Point(3, 34);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(45, 13);
            this.lbl_modelo.TabIndex = 1;
            this.lbl_modelo.Text = "Modelo:";
            // 
            // cmb_version
            // 
            this.cmb_version.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmb_version.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_version.FormattingEnabled = true;
            this.cmb_version.Location = new System.Drawing.Point(166, 57);
            this.cmb_version.Name = "cmb_version";
            this.cmb_version.Size = new System.Drawing.Size(123, 21);
            this.cmb_version.TabIndex = 4;
            // 
            // lbl_version
            // 
            this.lbl_version.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_version.AutoSize = true;
            this.lbl_version.Location = new System.Drawing.Point(3, 61);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(45, 13);
            this.lbl_version.TabIndex = 2;
            this.lbl_version.Text = "Versión:";
            // 
            // cmb_uso
            // 
            this.cmb_uso.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmb_uso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_uso.FormattingEnabled = true;
            this.cmb_uso.Items.AddRange(new object[] {
            "Usado",
            "0 KM"});
            this.cmb_uso.Location = new System.Drawing.Point(166, 84);
            this.cmb_uso.Name = "cmb_uso";
            this.cmb_uso.Size = new System.Drawing.Size(123, 21);
            this.cmb_uso.TabIndex = 6;
            this.cmb_uso.SelectedIndexChanged += new System.EventHandler(this.cmb_uso_SelectedIndexChanged);
            // 
            // lbl_uso
            // 
            this.lbl_uso.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_uso.AutoSize = true;
            this.lbl_uso.Location = new System.Drawing.Point(3, 88);
            this.lbl_uso.Name = "lbl_uso";
            this.lbl_uso.Size = new System.Drawing.Size(91, 13);
            this.lbl_uso.TabIndex = 3;
            this.lbl_uso.Text = "Uso del vehículo:";
            // 
            // lbl_añoPatentamiento
            // 
            this.lbl_añoPatentamiento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_añoPatentamiento.AutoSize = true;
            this.lbl_añoPatentamiento.Location = new System.Drawing.Point(3, 114);
            this.lbl_añoPatentamiento.Name = "lbl_añoPatentamiento";
            this.lbl_añoPatentamiento.Size = new System.Drawing.Size(114, 13);
            this.lbl_añoPatentamiento.TabIndex = 4;
            this.lbl_añoPatentamiento.Text = "Año de patentamiento:";
            // 
            // cmb_color
            // 
            this.cmb_color.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmb_color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_color.FormattingEnabled = true;
            this.cmb_color.Location = new System.Drawing.Point(166, 137);
            this.cmb_color.Name = "cmb_color";
            this.cmb_color.Size = new System.Drawing.Size(123, 21);
            this.cmb_color.TabIndex = 8;
            // 
            // lbl_color
            // 
            this.lbl_color.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_color.AutoSize = true;
            this.lbl_color.Location = new System.Drawing.Point(3, 141);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(34, 13);
            this.lbl_color.TabIndex = 5;
            this.lbl_color.Text = "Color:";
            // 
            // lbl_dominio
            // 
            this.lbl_dominio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_dominio.AutoSize = true;
            this.lbl_dominio.Location = new System.Drawing.Point(368, 7);
            this.lbl_dominio.Name = "lbl_dominio";
            this.lbl_dominio.Size = new System.Drawing.Size(48, 13);
            this.lbl_dominio.TabIndex = 6;
            this.lbl_dominio.Text = "Dominio:";
            // 
            // lbl_kilometraje
            // 
            this.lbl_kilometraje.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_kilometraje.AutoSize = true;
            this.lbl_kilometraje.Location = new System.Drawing.Point(368, 34);
            this.lbl_kilometraje.Name = "lbl_kilometraje";
            this.lbl_kilometraje.Size = new System.Drawing.Size(61, 13);
            this.lbl_kilometraje.TabIndex = 7;
            this.lbl_kilometraje.Text = "Kilometraje:";
            // 
            // lbl_valorAdquisicion
            // 
            this.lbl_valorAdquisicion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_valorAdquisicion.AutoSize = true;
            this.lbl_valorAdquisicion.Location = new System.Drawing.Point(368, 61);
            this.lbl_valorAdquisicion.Name = "lbl_valorAdquisicion";
            this.lbl_valorAdquisicion.Size = new System.Drawing.Size(105, 13);
            this.lbl_valorAdquisicion.TabIndex = 8;
            this.lbl_valorAdquisicion.Text = "Valor de adquisición:";
            // 
            // lbl_nroChasis
            // 
            this.lbl_nroChasis.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_nroChasis.AutoSize = true;
            this.lbl_nroChasis.Location = new System.Drawing.Point(368, 114);
            this.lbl_nroChasis.Name = "lbl_nroChasis";
            this.lbl_nroChasis.Size = new System.Drawing.Size(95, 13);
            this.lbl_nroChasis.TabIndex = 10;
            this.lbl_nroChasis.Text = "Número de chasis:";
            // 
            // lbl_nroMotor
            // 
            this.lbl_nroMotor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_nroMotor.AutoSize = true;
            this.lbl_nroMotor.Location = new System.Drawing.Point(368, 141);
            this.lbl_nroMotor.Name = "lbl_nroMotor";
            this.lbl_nroMotor.Size = new System.Drawing.Size(91, 13);
            this.lbl_nroMotor.TabIndex = 11;
            this.lbl_nroMotor.Text = "Número de motor:";
            // 
            // txt_nroMotor
            // 
            this.txt_nroMotor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_nroMotor.Location = new System.Drawing.Point(527, 137);
            this.txt_nroMotor.Name = "txt_nroMotor";
            this.txt_nroMotor.Size = new System.Drawing.Size(119, 20);
            this.txt_nroMotor.TabIndex = 15;
            this.txt_nroMotor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_observaciones
            // 
            this.lbl_observaciones.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_observaciones.AutoSize = true;
            this.lbl_observaciones.Location = new System.Drawing.Point(3, 167);
            this.lbl_observaciones.Name = "lbl_observaciones";
            this.lbl_observaciones.Size = new System.Drawing.Size(81, 13);
            this.lbl_observaciones.TabIndex = 12;
            this.lbl_observaciones.Text = "Observaciones:";
            // 
            // txt_observaciones
            // 
            this.tl_registrarVehiculo.SetColumnSpan(this.txt_observaciones, 3);
            this.txt_observaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_observaciones.Location = new System.Drawing.Point(5, 197);
            this.txt_observaciones.Margin = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.txt_observaciones.Multiline = true;
            this.txt_observaciones.Name = "txt_observaciones";
            this.tl_registrarVehiculo.SetRowSpan(this.txt_observaciones, 3);
            this.txt_observaciones.Size = new System.Drawing.Size(309, 85);
            this.txt_observaciones.TabIndex = 16;
            // 
            // btn_registrarMarca
            // 
            this.btn_registrarMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_registrarMarca.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_registrarMarca.BackgroundImage")));
            this.btn_registrarMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_registrarMarca.Location = new System.Drawing.Point(295, 3);
            this.btn_registrarMarca.Name = "btn_registrarMarca";
            this.btn_registrarMarca.Size = new System.Drawing.Size(21, 21);
            this.btn_registrarMarca.TabIndex = 1;
            this.btn_registrarMarca.UseVisualStyleBackColor = true;
            this.btn_registrarMarca.Click += new System.EventHandler(this.btn_registrarMarca_Click);
            // 
            // btn_registrarModelo
            // 
            this.btn_registrarModelo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_registrarModelo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_registrarModelo.BackgroundImage")));
            this.btn_registrarModelo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_registrarModelo.Location = new System.Drawing.Point(295, 30);
            this.btn_registrarModelo.Name = "btn_registrarModelo";
            this.btn_registrarModelo.Size = new System.Drawing.Size(21, 21);
            this.btn_registrarModelo.TabIndex = 3;
            this.btn_registrarModelo.UseVisualStyleBackColor = true;
            this.btn_registrarModelo.Click += new System.EventHandler(this.btn_registrarModelo_Click);
            // 
            // btn_registrarVersion
            // 
            this.btn_registrarVersion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_registrarVersion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_registrarVersion.BackgroundImage")));
            this.btn_registrarVersion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_registrarVersion.Location = new System.Drawing.Point(295, 57);
            this.btn_registrarVersion.Name = "btn_registrarVersion";
            this.btn_registrarVersion.Size = new System.Drawing.Size(21, 21);
            this.btn_registrarVersion.TabIndex = 5;
            this.btn_registrarVersion.UseVisualStyleBackColor = true;
            this.btn_registrarVersion.Click += new System.EventHandler(this.btn_registrarVersion_Click);
            // 
            // btn_registrarColor
            // 
            this.btn_registrarColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_registrarColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_registrarColor.BackgroundImage")));
            this.btn_registrarColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_registrarColor.Location = new System.Drawing.Point(295, 137);
            this.btn_registrarColor.Name = "btn_registrarColor";
            this.btn_registrarColor.Size = new System.Drawing.Size(21, 21);
            this.btn_registrarColor.TabIndex = 9;
            this.btn_registrarColor.UseVisualStyleBackColor = true;
            this.btn_registrarColor.Click += new System.EventHandler(this.btn_registrarColor_Click);
            // 
            // nud_añoPatentamiento
            // 
            this.nud_añoPatentamiento.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nud_añoPatentamiento.Location = new System.Drawing.Point(229, 111);
            this.nud_añoPatentamiento.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nud_añoPatentamiento.Name = "nud_añoPatentamiento";
            this.nud_añoPatentamiento.Size = new System.Drawing.Size(60, 20);
            this.nud_añoPatentamiento.TabIndex = 7;
            this.nud_añoPatentamiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_añoPatentamiento.ThousandsSeparator = true;
            // 
            // mtxt_dominio
            // 
            this.mtxt_dominio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mtxt_dominio.AsciiOnly = true;
            this.mtxt_dominio.Location = new System.Drawing.Point(580, 3);
            this.mtxt_dominio.Mask = ">LLL-000";
            this.mtxt_dominio.Name = "mtxt_dominio";
            this.mtxt_dominio.Size = new System.Drawing.Size(66, 20);
            this.mtxt_dominio.TabIndex = 10;
            this.mtxt_dominio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nud_kilometraje
            // 
            this.nud_kilometraje.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nud_kilometraje.Location = new System.Drawing.Point(555, 30);
            this.nud_kilometraje.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nud_kilometraje.Name = "nud_kilometraje";
            this.nud_kilometraje.Size = new System.Drawing.Size(91, 20);
            this.nud_kilometraje.TabIndex = 11;
            this.nud_kilometraje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_kilometraje.ThousandsSeparator = true;
            // 
            // lbl_valorVenta
            // 
            this.lbl_valorVenta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_valorVenta.AutoSize = true;
            this.lbl_valorVenta.Location = new System.Drawing.Point(368, 88);
            this.lbl_valorVenta.Name = "lbl_valorVenta";
            this.lbl_valorVenta.Size = new System.Drawing.Size(79, 13);
            this.lbl_valorVenta.TabIndex = 9;
            this.lbl_valorVenta.Text = "Valor de venta:";
            // 
            // nud_valorAdquisicion
            // 
            this.nud_valorAdquisicion.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nud_valorAdquisicion.DecimalPlaces = 2;
            this.nud_valorAdquisicion.Location = new System.Drawing.Point(555, 57);
            this.nud_valorAdquisicion.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nud_valorAdquisicion.Name = "nud_valorAdquisicion";
            this.nud_valorAdquisicion.Size = new System.Drawing.Size(91, 20);
            this.nud_valorAdquisicion.TabIndex = 12;
            this.nud_valorAdquisicion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_valorAdquisicion.ThousandsSeparator = true;
            // 
            // nud_valorVenta
            // 
            this.nud_valorVenta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nud_valorVenta.DecimalPlaces = 2;
            this.nud_valorVenta.Location = new System.Drawing.Point(555, 84);
            this.nud_valorVenta.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nud_valorVenta.Name = "nud_valorVenta";
            this.nud_valorVenta.Size = new System.Drawing.Size(91, 20);
            this.nud_valorVenta.TabIndex = 13;
            this.nud_valorVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_valorVenta.ThousandsSeparator = true;
            // 
            // mtxt_nroChasis
            // 
            this.mtxt_nroChasis.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.mtxt_nroChasis.AsciiOnly = true;
            this.mtxt_nroChasis.Location = new System.Drawing.Point(527, 111);
            this.mtxt_nroChasis.Mask = ">AAA-AAAAAAA-AAAAAAA";
            this.mtxt_nroChasis.Name = "mtxt_nroChasis";
            this.mtxt_nroChasis.Size = new System.Drawing.Size(119, 20);
            this.mtxt_nroChasis.TabIndex = 14;
            this.mtxt_nroChasis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tl_registrarVehiculo
            // 
            this.tl_registrarVehiculo.ColumnCount = 6;
            this.tl_registrarVehiculo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tl_registrarVehiculo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tl_registrarVehiculo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tl_registrarVehiculo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tl_registrarVehiculo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tl_registrarVehiculo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tl_registrarVehiculo.Controls.Add(this.dgv_vehiculos, 0, 11);
            this.tl_registrarVehiculo.Controls.Add(this.lbl_marca, 0, 0);
            this.tl_registrarVehiculo.Controls.Add(this.txt_nroMotor, 5, 5);
            this.tl_registrarVehiculo.Controls.Add(this.mtxt_nroChasis, 5, 4);
            this.tl_registrarVehiculo.Controls.Add(this.lbl_modelo, 0, 1);
            this.tl_registrarVehiculo.Controls.Add(this.nud_valorVenta, 5, 3);
            this.tl_registrarVehiculo.Controls.Add(this.lbl_version, 0, 2);
            this.tl_registrarVehiculo.Controls.Add(this.nud_valorAdquisicion, 5, 2);
            this.tl_registrarVehiculo.Controls.Add(this.lbl_uso, 0, 3);
            this.tl_registrarVehiculo.Controls.Add(this.nud_kilometraje, 5, 1);
            this.tl_registrarVehiculo.Controls.Add(this.lbl_valorVenta, 4, 3);
            this.tl_registrarVehiculo.Controls.Add(this.mtxt_dominio, 5, 0);
            this.tl_registrarVehiculo.Controls.Add(this.lbl_añoPatentamiento, 0, 4);
            this.tl_registrarVehiculo.Controls.Add(this.txt_observaciones, 0, 7);
            this.tl_registrarVehiculo.Controls.Add(this.lbl_color, 0, 5);
            this.tl_registrarVehiculo.Controls.Add(this.lbl_nroMotor, 4, 5);
            this.tl_registrarVehiculo.Controls.Add(this.btn_registrarModelo, 2, 1);
            this.tl_registrarVehiculo.Controls.Add(this.lbl_nroChasis, 4, 4);
            this.tl_registrarVehiculo.Controls.Add(this.nud_añoPatentamiento, 1, 4);
            this.tl_registrarVehiculo.Controls.Add(this.cmb_modelo, 1, 1);
            this.tl_registrarVehiculo.Controls.Add(this.lbl_valorAdquisicion, 4, 2);
            this.tl_registrarVehiculo.Controls.Add(this.lbl_kilometraje, 4, 1);
            this.tl_registrarVehiculo.Controls.Add(this.cmb_version, 1, 2);
            this.tl_registrarVehiculo.Controls.Add(this.lbl_dominio, 4, 0);
            this.tl_registrarVehiculo.Controls.Add(this.cmb_uso, 1, 3);
            this.tl_registrarVehiculo.Controls.Add(this.cmb_color, 1, 5);
            this.tl_registrarVehiculo.Controls.Add(this.btn_registrarVersion, 2, 2);
            this.tl_registrarVehiculo.Controls.Add(this.btn_registrarColor, 2, 5);
            this.tl_registrarVehiculo.Controls.Add(this.btn_cancelar, 0, 12);
            this.tl_registrarVehiculo.Controls.Add(this.btn_registrarMarca, 2, 0);
            this.tl_registrarVehiculo.Controls.Add(this.cmb_marca, 1, 0);
            this.tl_registrarVehiculo.Controls.Add(this.lbl_fechaRegistro, 4, 6);
            this.tl_registrarVehiculo.Controls.Add(this.txt_fechaRegistro, 5, 6);
            this.tl_registrarVehiculo.Controls.Add(this.lbl_tipoEstado, 4, 7);
            this.tl_registrarVehiculo.Controls.Add(this.txt_tipoEstado, 5, 7);
            this.tl_registrarVehiculo.Controls.Add(this.lbl_fechaEstado, 4, 8);
            this.tl_registrarVehiculo.Controls.Add(this.txt_fechaEstado, 5, 8);
            this.tl_registrarVehiculo.Controls.Add(this.lbl_observaciones, 0, 6);
            this.tl_registrarVehiculo.Controls.Add(this.lbl_vehiculos, 0, 10);
            this.tl_registrarVehiculo.Controls.Add(this.btn_buscar, 1, 10);
            this.tl_registrarVehiculo.Controls.Add(this.btn_aceptar, 4, 12);
            this.tl_registrarVehiculo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tl_registrarVehiculo.Location = new System.Drawing.Point(0, 0);
            this.tl_registrarVehiculo.Name = "tl_registrarVehiculo";
            this.tl_registrarVehiculo.RowCount = 13;
            this.tl_registrarVehiculo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tl_registrarVehiculo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tl_registrarVehiculo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tl_registrarVehiculo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tl_registrarVehiculo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tl_registrarVehiculo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tl_registrarVehiculo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tl_registrarVehiculo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tl_registrarVehiculo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tl_registrarVehiculo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tl_registrarVehiculo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tl_registrarVehiculo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tl_registrarVehiculo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tl_registrarVehiculo.Size = new System.Drawing.Size(649, 511);
            this.tl_registrarVehiculo.TabIndex = 19;
            // 
            // dgv_vehiculos
            // 
            this.dgv_vehiculos.AllowUserToAddRows = false;
            this.dgv_vehiculos.AllowUserToDeleteRows = false;
            this.dgv_vehiculos.AllowUserToOrderColumns = true;
            this.dgv_vehiculos.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            this.dgv_vehiculos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_vehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tl_registrarVehiculo.SetColumnSpan(this.dgv_vehiculos, 6);
            this.dgv_vehiculos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_vehiculos.Location = new System.Drawing.Point(3, 324);
            this.dgv_vehiculos.MultiSelect = false;
            this.dgv_vehiculos.Name = "dgv_vehiculos";
            this.dgv_vehiculos.ReadOnly = true;
            this.dgv_vehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_vehiculos.Size = new System.Drawing.Size(643, 154);
            this.dgv_vehiculos.TabIndex = 32;
            this.dgv_vehiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_vehiculos_CellContentClick);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tl_registrarVehiculo.SetColumnSpan(this.btn_cancelar, 2);
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Location = new System.Drawing.Point(106, 484);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(80, 23);
            this.btn_cancelar.TabIndex = 17;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // lbl_fechaRegistro
            // 
            this.lbl_fechaRegistro.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_fechaRegistro.AutoSize = true;
            this.lbl_fechaRegistro.Location = new System.Drawing.Point(368, 167);
            this.lbl_fechaRegistro.Name = "lbl_fechaRegistro";
            this.lbl_fechaRegistro.Size = new System.Drawing.Size(92, 13);
            this.lbl_fechaRegistro.TabIndex = 19;
            this.lbl_fechaRegistro.Text = "Fecha de registro:";
            // 
            // txt_fechaRegistro
            // 
            this.txt_fechaRegistro.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_fechaRegistro.Location = new System.Drawing.Point(527, 164);
            this.txt_fechaRegistro.Name = "txt_fechaRegistro";
            this.txt_fechaRegistro.Size = new System.Drawing.Size(119, 20);
            this.txt_fechaRegistro.TabIndex = 20;
            this.txt_fechaRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_tipoEstado
            // 
            this.lbl_tipoEstado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_tipoEstado.AutoSize = true;
            this.lbl_tipoEstado.Location = new System.Drawing.Point(368, 193);
            this.lbl_tipoEstado.Name = "lbl_tipoEstado";
            this.lbl_tipoEstado.Size = new System.Drawing.Size(43, 13);
            this.lbl_tipoEstado.TabIndex = 21;
            this.lbl_tipoEstado.Text = "Estado:";
            // 
            // txt_tipoEstado
            // 
            this.txt_tipoEstado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_tipoEstado.Location = new System.Drawing.Point(542, 190);
            this.txt_tipoEstado.Name = "txt_tipoEstado";
            this.txt_tipoEstado.Size = new System.Drawing.Size(104, 20);
            this.txt_tipoEstado.TabIndex = 22;
            this.txt_tipoEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_fechaEstado
            // 
            this.lbl_fechaEstado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_fechaEstado.AutoSize = true;
            this.lbl_fechaEstado.Location = new System.Drawing.Point(368, 219);
            this.lbl_fechaEstado.Name = "lbl_fechaEstado";
            this.lbl_fechaEstado.Size = new System.Drawing.Size(90, 13);
            this.lbl_fechaEstado.TabIndex = 23;
            this.lbl_fechaEstado.Text = "Fecha de estado:";
            // 
            // txt_fechaEstado
            // 
            this.txt_fechaEstado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_fechaEstado.Location = new System.Drawing.Point(527, 216);
            this.txt_fechaEstado.Name = "txt_fechaEstado";
            this.txt_fechaEstado.Size = new System.Drawing.Size(119, 20);
            this.txt_fechaEstado.TabIndex = 24;
            this.txt_fechaEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_vehiculos
            // 
            this.lbl_vehiculos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_vehiculos.AutoSize = true;
            this.lbl_vehiculos.Location = new System.Drawing.Point(3, 300);
            this.lbl_vehiculos.Name = "lbl_vehiculos";
            this.lbl_vehiculos.Size = new System.Drawing.Size(58, 13);
            this.lbl_vehiculos.TabIndex = 33;
            this.lbl_vehiculos.Text = "Vehículos:";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_buscar.Location = new System.Drawing.Point(214, 295);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 34;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tl_registrarVehiculo.SetColumnSpan(this.btn_aceptar, 2);
            this.btn_aceptar.Location = new System.Drawing.Point(467, 484);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(80, 23);
            this.btn_aceptar.TabIndex = 18;
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // FormBaseVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(649, 511);
            this.Controls.Add(this.tl_registrarVehiculo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(665, 800);
            this.MinimumSize = new System.Drawing.Size(665, 550);
            this.Name = "FormBaseVehiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.nud_añoPatentamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_kilometraje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_valorAdquisicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_valorVenta)).EndInit();
            this.tl_registrarVehiculo.ResumeLayout(false);
            this.tl_registrarVehiculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_vehiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.ComboBox cmb_marca;
        private System.Windows.Forms.Label lbl_marca;
        protected System.Windows.Forms.ComboBox cmb_modelo;
        private System.Windows.Forms.Label lbl_modelo;
        protected System.Windows.Forms.ComboBox cmb_version;
        private System.Windows.Forms.Label lbl_version;
        protected System.Windows.Forms.ComboBox cmb_uso;
        private System.Windows.Forms.Label lbl_uso;
        private System.Windows.Forms.Label lbl_añoPatentamiento;
        protected System.Windows.Forms.ComboBox cmb_color;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.Label lbl_dominio;
        private System.Windows.Forms.Label lbl_kilometraje;
        private System.Windows.Forms.Label lbl_valorAdquisicion;
        private System.Windows.Forms.Label lbl_nroChasis;
        private System.Windows.Forms.Label lbl_nroMotor;
        protected System.Windows.Forms.TextBox txt_nroMotor;
        private System.Windows.Forms.Label lbl_observaciones;
        protected System.Windows.Forms.TextBox txt_observaciones;
        protected System.Windows.Forms.Button btn_registrarMarca;
        protected System.Windows.Forms.Button btn_registrarModelo;
        protected System.Windows.Forms.Button btn_registrarVersion;
        protected System.Windows.Forms.Button btn_registrarColor;
        protected System.Windows.Forms.NumericUpDown nud_añoPatentamiento;
        protected System.Windows.Forms.MaskedTextBox mtxt_dominio;
        protected System.Windows.Forms.NumericUpDown nud_kilometraje;
        private System.Windows.Forms.Label lbl_valorVenta;
        protected System.Windows.Forms.NumericUpDown nud_valorAdquisicion;
        protected System.Windows.Forms.NumericUpDown nud_valorVenta;
        protected System.Windows.Forms.MaskedTextBox mtxt_nroChasis;
        private System.Windows.Forms.TableLayoutPanel tl_registrarVehiculo;
        private System.Windows.Forms.Label lbl_fechaRegistro;
        protected System.Windows.Forms.TextBox txt_fechaRegistro;
        private System.Windows.Forms.Label lbl_tipoEstado;
        protected System.Windows.Forms.TextBox txt_tipoEstado;
        private System.Windows.Forms.Label lbl_fechaEstado;
        protected System.Windows.Forms.TextBox txt_fechaEstado;
        protected System.Windows.Forms.DataGridView dgv_vehiculos;
        protected System.Windows.Forms.Button btn_cancelar;
        protected System.Windows.Forms.Button btn_aceptar;
        protected System.Windows.Forms.Label lbl_vehiculos;
        protected System.Windows.Forms.Button btn_buscar;
    }
}