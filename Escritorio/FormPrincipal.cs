using System;
using System.Windows.Forms;
using Interfaz.Escritorio.Forms_Login;
using Negocio.Entidades;
using Interfaz.Escritorio.Forms_Vehiculo.ABMC_Vehiculo;
using Interfaz.Escritorio.Forms_Persona;
using Interfaz.Escritorio.Forms_Comision;
using Interfaz.Escritorio.Forms_Vehiculo.AB_Marca;
using Interfaz.Escritorio.Forms_Vehiculo.AB_Modelo;
using Interfaz.Escritorio.Forms_Vehiculo.AB_Version;
using Interfaz.Escritorio.Forms_Vehiculo.AB_Color;


namespace Interfaz.Escritorio
{
    public partial class FormPrincipal : Form
    {
        #region Propiedades

        public Persona PersonaActual { get; set; }

        #endregion


        #region Constructores y Cargadores

        public FormPrincipal()
        {
            InitializeComponent();
        }


        private void formPrincipal_Shown(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            if (login.ShowDialog() != DialogResult.OK)
            {
                Dispose();
            }
            else
            {
                PersonaActual = login.PersonaActual;
                login.Dispose();

                switch (PersonaActual.Perfil)
                {
                    case Persona.ePerfil.Administrador:
                        break;
                    case Persona.ePerfil.General:
                        SetearOpcionesGeneral();
                        break;
                    case Persona.ePerfil.Consultor:
                        SetearOpcionesConsultor();
                        break;
                }
            }
        }

        #endregion


        #region Funciones internas: SetearOpcionesGeneral y SetearOpcionesConsultor

        private void SetearOpcionesGeneral()
        {
            empleadoToolStripMenuItem.Visible = false;
            comisiónToolStripMenuItem.Visible = false;

        }
        

        private void SetearOpcionesConsultor()
        {
            SetearOpcionesGeneral();

            clienteToolStripMenuItem.Visible = false;
            venderVehiculoToolStripMenuItem.Visible = false;
            registrarVehiculoToolStripMenuItem.Visible = false;
            modificarFichaDeUnVehiculoToolStripMenuItem.Visible = false;
            caracteristicasDeUnVehículoToolStripMenuItem.Visible = false;
            eliminarVehiculoToolStripMenuItem.Visible = false;
        }

        #endregion


        #region ToolStrip Empleado
        private void registrarNuevoEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrarPersona registrarEmpleado = new FormRegistrarPersona(Persona.eRol.Empleado);
            registrarEmpleado.MdiParent = this;
            registrarEmpleado.Show();
        }


        private void consultarPerfilEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultarPersona consultarEmpleado = new FormConsultarPersona(Persona.eRol.Empleado);
            consultarEmpleado.MdiParent = this;
            consultarEmpleado.Show();
        }


        private void modificarPerfilEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModificarPersona modificarEmpleado = new FormModificarPersona(Persona.eRol.Empleado);
            modificarEmpleado.MdiParent = this;
            modificarEmpleado.Show();
        }


        private void eliminarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEliminarPersona eliminarEmpleado = new FormEliminarPersona(Persona.eRol.Empleado);
            eliminarEmpleado.MdiParent = this;
            eliminarEmpleado.Show();
        }
        #endregion


        #region ToolStrip Cliente
        private void registrarNuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrarPersona registrarCliente = new FormRegistrarPersona(Persona.eRol.Cliente);
            registrarCliente.MdiParent = this;
            registrarCliente.Show();
        }


        private void consultarPerfilClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultarPersona consultarCliente = new FormConsultarPersona(Persona.eRol.Cliente);
            consultarCliente.MdiParent = this;
            consultarCliente.Show();
        }


        private void modificarPerfilClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModificarPersona modificarCliente = new FormModificarPersona(Persona.eRol.Cliente);
            modificarCliente.MdiParent = this;
            modificarCliente.Show();
        }


        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEliminarPersona eliminarCliente = new FormEliminarPersona(Persona.eRol.Cliente);
            eliminarCliente.MdiParent = this;
            eliminarCliente.Show();
        }

        #endregion


        #region ToolStrip Mi perfil
        private void consultarMiPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultarPersona consultarMiPerfil = new FormConsultarPersona(PersonaActual.Rol, PersonaActual.NroDoc);
            consultarMiPerfil.MdiParent = this;
            consultarMiPerfil.Show();
        }

        private void modificarMiPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModificarPersona modificarMiPerfil = new FormModificarPersona(PersonaActual.Rol, PersonaActual.NroDoc);
            modificarMiPerfil.MdiParent = this;
            modificarMiPerfil.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        #endregion


        #region ToolStrip Vehiculo

        private void venderVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venta ventaActual = new Venta();
            ventaActual.Empleado = PersonaActual;

            FormSeleccionarPersona seleccionarPersona = new FormSeleccionarPersona(ventaActual);
            seleccionarPersona.MdiParent = this;
            seleccionarPersona.Show();
        }

        private void registrarVehículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrarVehiculo registrarVehiculo = new FormRegistrarVehiculo();
            registrarVehiculo.MdiParent = this;
            registrarVehiculo.Show();
        }


        private void consultarFichaDeUnVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultarVehiculo consultarVehiculo = new FormConsultarVehiculo();
            consultarVehiculo.MdiParent = this;
            consultarVehiculo.Show();
        }


        private void modificarFichaDeUnVehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModificarVehiculo modificarVehiculo = new FormModificarVehiculo();
            modificarVehiculo.MdiParent = this;
            modificarVehiculo.Show();
        }


        private void eliminarVehículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEliminarVehiculo eliminarVehiculo = new FormEliminarVehiculo();
            eliminarVehiculo.MdiParent = this;
            eliminarVehiculo.Show();
        }

        #endregion


        #region Submenú Marca

        private void eliminarMarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEliminarMarca eliminarMarca = new FormEliminarMarca();
            eliminarMarca.MdiParent = this;
            eliminarMarca.Show();
        }

        #endregion


        #region Submenú Modelo
        
        private void eliminarModeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEliminarModelo eliminarModelo = new FormEliminarModelo();
            eliminarModelo.MdiParent = this;
            eliminarModelo.Show();
        }

        #endregion


        #region Submenú Version

        private void eliminarVersiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEliminarVersion eliminarVersion = new FormEliminarVersion();
            eliminarVersion.MdiParent = this;
            eliminarVersion.Show();
        }

        #endregion


        #region Submenú Color
        
        private void eliminarColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEliminarColor eliminarColor = new FormEliminarColor();
            eliminarColor.MdiParent = this;
            eliminarColor.Show();
        }

        #endregion


        #region ToolStrip Comision

        private void registrarComisiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistrarComision registrarComision = new FormRegistrarComision();
            registrarComision.MdiParent = this;
            registrarComision.Show();
        }


        private void consultarComisiónActualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultarComision consultarComision = new FormConsultarComision();
            consultarComision.MdiParent = this;
            consultarComision.Show();
        }


        #endregion

        
    }
}
