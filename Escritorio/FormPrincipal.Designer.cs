namespace Interfaz.Escritorio
{
    partial class FormPrincipal
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
            this.ms_principal = new System.Windows.Forms.MenuStrip();
            this.miPerfilStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarMiPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarMiPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNuevoEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPerfilDeUnEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPerfilDeUnEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarDatosPerfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarDatosDeUnVehículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPerfilDeUnClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venderVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarFichaDeUnVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarFichaDeUnVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarVehiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caracteristicasDeUnVehículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarModeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarVersiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comisiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarComisiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarComisiónActualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_principal
            // 
            this.ms_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPerfilStripMenuItem,
            this.empleadoToolStripMenuItem,
            this.clienteToolStripMenuItem,
            this.vehiculoToolStripMenuItem,
            this.comisiónToolStripMenuItem});
            this.ms_principal.Location = new System.Drawing.Point(0, 0);
            this.ms_principal.Name = "ms_principal";
            this.ms_principal.Size = new System.Drawing.Size(703, 24);
            this.ms_principal.TabIndex = 1;
            // 
            // miPerfilStripMenuItem
            // 
            this.miPerfilStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarMiPerfilToolStripMenuItem,
            this.modificarMiPerfilToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.miPerfilStripMenuItem.Name = "miPerfilStripMenuItem";
            this.miPerfilStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.miPerfilStripMenuItem.Text = "Mi perfil";
            // 
            // consultarMiPerfilToolStripMenuItem
            // 
            this.consultarMiPerfilToolStripMenuItem.Name = "consultarMiPerfilToolStripMenuItem";
            this.consultarMiPerfilToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.consultarMiPerfilToolStripMenuItem.Text = "Consultar mi perfil";
            this.consultarMiPerfilToolStripMenuItem.Click += new System.EventHandler(this.consultarMiPerfilToolStripMenuItem_Click);
            // 
            // modificarMiPerfilToolStripMenuItem
            // 
            this.modificarMiPerfilToolStripMenuItem.Name = "modificarMiPerfilToolStripMenuItem";
            this.modificarMiPerfilToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.modificarMiPerfilToolStripMenuItem.Text = "Modificar mi perfil";
            this.modificarMiPerfilToolStripMenuItem.Click += new System.EventHandler(this.modificarMiPerfilToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarNuevoEmpleadoToolStripMenuItem,
            this.consultarPerfilDeUnEmpleadoToolStripMenuItem,
            this.modificarPerfilDeUnEmpleadoToolStripMenuItem,
            this.eliminarEmpleadoToolStripMenuItem});
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            // 
            // registrarNuevoEmpleadoToolStripMenuItem
            // 
            this.registrarNuevoEmpleadoToolStripMenuItem.Name = "registrarNuevoEmpleadoToolStripMenuItem";
            this.registrarNuevoEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.registrarNuevoEmpleadoToolStripMenuItem.Text = "Registrar nuevo Empleado";
            this.registrarNuevoEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.registrarNuevoEmpleadoToolStripMenuItem_Click);
            // 
            // consultarPerfilDeUnEmpleadoToolStripMenuItem
            // 
            this.consultarPerfilDeUnEmpleadoToolStripMenuItem.Name = "consultarPerfilDeUnEmpleadoToolStripMenuItem";
            this.consultarPerfilDeUnEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.consultarPerfilDeUnEmpleadoToolStripMenuItem.Text = "Consultar perfil de un Empleado";
            this.consultarPerfilDeUnEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.consultarPerfilEmpleadoToolStripMenuItem_Click);
            // 
            // modificarPerfilDeUnEmpleadoToolStripMenuItem
            // 
            this.modificarPerfilDeUnEmpleadoToolStripMenuItem.Name = "modificarPerfilDeUnEmpleadoToolStripMenuItem";
            this.modificarPerfilDeUnEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.modificarPerfilDeUnEmpleadoToolStripMenuItem.Text = "Modificar perfil de un Empleado";
            this.modificarPerfilDeUnEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.modificarPerfilEmpleadoToolStripMenuItem_Click);
            // 
            // eliminarEmpleadoToolStripMenuItem
            // 
            this.eliminarEmpleadoToolStripMenuItem.Name = "eliminarEmpleadoToolStripMenuItem";
            this.eliminarEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
            this.eliminarEmpleadoToolStripMenuItem.Text = "Eliminar Empleado";
            this.eliminarEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.eliminarEmpleadoToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarDatosPerfilToolStripMenuItem,
            this.consultarDatosDeUnVehículoToolStripMenuItem,
            this.modificarPerfilDeUnClienteToolStripMenuItem,
            this.eliminarClienteToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // consultarDatosPerfilToolStripMenuItem
            // 
            this.consultarDatosPerfilToolStripMenuItem.Name = "consultarDatosPerfilToolStripMenuItem";
            this.consultarDatosPerfilToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.consultarDatosPerfilToolStripMenuItem.Text = "Registrar nuevo Cliente";
            this.consultarDatosPerfilToolStripMenuItem.Click += new System.EventHandler(this.registrarNuevoClienteToolStripMenuItem_Click);
            // 
            // consultarDatosDeUnVehículoToolStripMenuItem
            // 
            this.consultarDatosDeUnVehículoToolStripMenuItem.Name = "consultarDatosDeUnVehículoToolStripMenuItem";
            this.consultarDatosDeUnVehículoToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.consultarDatosDeUnVehículoToolStripMenuItem.Text = "Consultar perfil de un Cliente";
            this.consultarDatosDeUnVehículoToolStripMenuItem.Click += new System.EventHandler(this.consultarPerfilClienteToolStripMenuItem_Click);
            // 
            // modificarPerfilDeUnClienteToolStripMenuItem
            // 
            this.modificarPerfilDeUnClienteToolStripMenuItem.Name = "modificarPerfilDeUnClienteToolStripMenuItem";
            this.modificarPerfilDeUnClienteToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.modificarPerfilDeUnClienteToolStripMenuItem.Text = "Modificar perfil de un Cliente";
            this.modificarPerfilDeUnClienteToolStripMenuItem.Click += new System.EventHandler(this.modificarPerfilClienteToolStripMenuItem_Click);
            // 
            // eliminarClienteToolStripMenuItem
            // 
            this.eliminarClienteToolStripMenuItem.Name = "eliminarClienteToolStripMenuItem";
            this.eliminarClienteToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.eliminarClienteToolStripMenuItem.Text = "Eliminar Cliente";
            this.eliminarClienteToolStripMenuItem.Click += new System.EventHandler(this.eliminarClienteToolStripMenuItem_Click);
            // 
            // vehiculoToolStripMenuItem
            // 
            this.vehiculoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.venderVehiculoToolStripMenuItem,
            this.registrarVehiculoToolStripMenuItem,
            this.consultarFichaDeUnVehiculoToolStripMenuItem,
            this.modificarFichaDeUnVehiculoToolStripMenuItem,
            this.eliminarVehiculoToolStripMenuItem,
            this.caracteristicasDeUnVehículoToolStripMenuItem});
            this.vehiculoToolStripMenuItem.Name = "vehiculoToolStripMenuItem";
            this.vehiculoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.vehiculoToolStripMenuItem.Text = "Vehiculo";
            // 
            // venderVehiculoToolStripMenuItem
            // 
            this.venderVehiculoToolStripMenuItem.Name = "venderVehiculoToolStripMenuItem";
            this.venderVehiculoToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.venderVehiculoToolStripMenuItem.Text = "Vender Vehículo";
            this.venderVehiculoToolStripMenuItem.Click += new System.EventHandler(this.venderVehiculoToolStripMenuItem_Click);
            // 
            // registrarVehiculoToolStripMenuItem
            // 
            this.registrarVehiculoToolStripMenuItem.Name = "registrarVehiculoToolStripMenuItem";
            this.registrarVehiculoToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.registrarVehiculoToolStripMenuItem.Text = "Registrar Vehículo";
            this.registrarVehiculoToolStripMenuItem.Click += new System.EventHandler(this.registrarVehículoToolStripMenuItem_Click);
            // 
            // consultarFichaDeUnVehiculoToolStripMenuItem
            // 
            this.consultarFichaDeUnVehiculoToolStripMenuItem.Name = "consultarFichaDeUnVehiculoToolStripMenuItem";
            this.consultarFichaDeUnVehiculoToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.consultarFichaDeUnVehiculoToolStripMenuItem.Text = "Consultar ficha de un Vehículo";
            this.consultarFichaDeUnVehiculoToolStripMenuItem.Click += new System.EventHandler(this.consultarFichaDeUnVehiculoToolStripMenuItem_Click);
            // 
            // modificarFichaDeUnVehiculoToolStripMenuItem
            // 
            this.modificarFichaDeUnVehiculoToolStripMenuItem.Name = "modificarFichaDeUnVehiculoToolStripMenuItem";
            this.modificarFichaDeUnVehiculoToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.modificarFichaDeUnVehiculoToolStripMenuItem.Text = "Modificar ficha de un Vehículo";
            this.modificarFichaDeUnVehiculoToolStripMenuItem.Click += new System.EventHandler(this.modificarFichaDeUnVehiculoToolStripMenuItem_Click);
            // 
            // eliminarVehiculoToolStripMenuItem
            // 
            this.eliminarVehiculoToolStripMenuItem.Name = "eliminarVehiculoToolStripMenuItem";
            this.eliminarVehiculoToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.eliminarVehiculoToolStripMenuItem.Text = "Eliminar Vehículo";
            this.eliminarVehiculoToolStripMenuItem.Click += new System.EventHandler(this.eliminarVehículoToolStripMenuItem_Click);
            // 
            // caracteristicasDeUnVehículoToolStripMenuItem
            // 
            this.caracteristicasDeUnVehículoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcaToolStripMenuItem,
            this.modeloToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.colorToolStripMenuItem1});
            this.caracteristicasDeUnVehículoToolStripMenuItem.Name = "caracteristicasDeUnVehículoToolStripMenuItem";
            this.caracteristicasDeUnVehículoToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.caracteristicasDeUnVehículoToolStripMenuItem.Text = "Características de un Vehículo";
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarMarcaToolStripMenuItem});
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.marcaToolStripMenuItem.Text = "Marca";
            // 
            // eliminarMarcaToolStripMenuItem
            // 
            this.eliminarMarcaToolStripMenuItem.Name = "eliminarMarcaToolStripMenuItem";
            this.eliminarMarcaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.eliminarMarcaToolStripMenuItem.Text = "Eliminar Marca";
            this.eliminarMarcaToolStripMenuItem.Click += new System.EventHandler(this.eliminarMarcaToolStripMenuItem_Click);
            // 
            // modeloToolStripMenuItem
            // 
            this.modeloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarModeloToolStripMenuItem});
            this.modeloToolStripMenuItem.Name = "modeloToolStripMenuItem";
            this.modeloToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.modeloToolStripMenuItem.Text = "Modelo";
            // 
            // eliminarModeloToolStripMenuItem
            // 
            this.eliminarModeloToolStripMenuItem.Name = "eliminarModeloToolStripMenuItem";
            this.eliminarModeloToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.eliminarModeloToolStripMenuItem.Text = "Eliminar Modelo";
            this.eliminarModeloToolStripMenuItem.Click += new System.EventHandler(this.eliminarModeloToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarVersiónToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.colorToolStripMenuItem.Text = "Versión";
            // 
            // eliminarVersiónToolStripMenuItem
            // 
            this.eliminarVersiónToolStripMenuItem.Name = "eliminarVersiónToolStripMenuItem";
            this.eliminarVersiónToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.eliminarVersiónToolStripMenuItem.Text = "Eliminar Versión";
            this.eliminarVersiónToolStripMenuItem.Click += new System.EventHandler(this.eliminarVersiónToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem1
            // 
            this.colorToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarColorToolStripMenuItem});
            this.colorToolStripMenuItem1.Name = "colorToolStripMenuItem1";
            this.colorToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.colorToolStripMenuItem1.Text = "Color";
            // 
            // eliminarColorToolStripMenuItem
            // 
            this.eliminarColorToolStripMenuItem.Name = "eliminarColorToolStripMenuItem";
            this.eliminarColorToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.eliminarColorToolStripMenuItem.Text = "Eliminar Color";
            this.eliminarColorToolStripMenuItem.Click += new System.EventHandler(this.eliminarColorToolStripMenuItem_Click);
            // 
            // comisiónToolStripMenuItem
            // 
            this.comisiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarComisiónToolStripMenuItem,
            this.consultarComisiónActualToolStripMenuItem});
            this.comisiónToolStripMenuItem.Name = "comisiónToolStripMenuItem";
            this.comisiónToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.comisiónToolStripMenuItem.Text = "Comisión";
            // 
            // registrarComisiónToolStripMenuItem
            // 
            this.registrarComisiónToolStripMenuItem.Name = "registrarComisiónToolStripMenuItem";
            this.registrarComisiónToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.registrarComisiónToolStripMenuItem.Text = "Registrar Comisión";
            this.registrarComisiónToolStripMenuItem.Click += new System.EventHandler(this.registrarComisiónToolStripMenuItem_Click);
            // 
            // consultarComisiónActualToolStripMenuItem
            // 
            this.consultarComisiónActualToolStripMenuItem.Name = "consultarComisiónActualToolStripMenuItem";
            this.consultarComisiónActualToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.consultarComisiónActualToolStripMenuItem.Text = "Consultar Comisión actual";
            this.consultarComisiónActualToolStripMenuItem.Click += new System.EventHandler(this.consultarComisiónActualToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 387);
            this.Controls.Add(this.ms_principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ms_principal;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Obredor Automotores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.formPrincipal_Shown);
            this.ms_principal.ResumeLayout(false);
            this.ms_principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_principal;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarNuevoEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarDatosPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarDatosDeUnVehículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venderVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarPerfilDeUnEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarPerfilDeUnEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarPerfilDeUnClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miPerfilStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarMiPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarMiPerfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarFichaDeUnVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarFichaDeUnVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caracteristicasDeUnVehículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarModeloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarVersiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comisiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarComisiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarComisiónActualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarVehiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarEmpleadoToolStripMenuItem;
    }
}