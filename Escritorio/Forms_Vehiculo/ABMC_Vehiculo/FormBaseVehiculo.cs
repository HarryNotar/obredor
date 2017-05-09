using System;
using System.Windows.Forms;
using Negocio.Logica;
using Negocio.Entidades;
using Interfaz.Escritorio.Mensajes;
using System.Collections.Generic;
using Interfaz.Escritorio.Forms_Vehiculo.AB_Color;
using Interfaz.Escritorio.Forms_Vehiculo.AB_Marca;
using Interfaz.Escritorio.Forms_Vehiculo.AB_Modelo;
using Interfaz.Escritorio.Forms_Vehiculo.AB_Version;

namespace Interfaz.Escritorio.Forms_Vehiculo.ABMC_Vehiculo
{
    public partial class FormBaseVehiculo : Form
    {
        #region Propiedades y Atributos

        protected LogicaVehiculo logicaVehiculo;
        protected LogicaColor logicaColor;
        protected LogicaMarca logicaMarca;
        protected LogicaModelo logicaModelo;
        protected LogicaVersion logicaVersion;

        public Vehiculo VehiculoActual { get; set; }
        public List<Vehiculo> ListaVehiculos { get; set; }

        #endregion



        #region Constructores

        public FormBaseVehiculo()
        {
            InitializeComponent();

            logicaVehiculo = new LogicaVehiculo();
            logicaColor = new LogicaColor();
            logicaMarca = new LogicaMarca();
            logicaModelo = new LogicaModelo();
            logicaVersion = new LogicaVersion();

            VehiculoActual = new Vehiculo();
            ListaVehiculos = new List<Vehiculo>();

            // Setea que atributo de los objetos se mostrará en el comboBox.
            cmb_modelo.DisplayMember = "Nombre";
            cmb_marca.DisplayMember = "Nombre";
            cmb_color.DisplayMember = "Nombre";
            cmb_version.DisplayMember = "Nombre";

            cmb_color.ValueMember = "idColor";

            // Carga los comboBox con valores
            CargarMarcasModelosVersiones();
            CargarColores();
            cmb_color.SelectedItem = null;

            // Dar formato a la grilla de vehículos
            FormatearDgv_vehiculos();

            // Deshabilitar la escritura o selección de los controles
            DeshabilitarControles();
        }

        #endregion



        #region Funciones internas


        protected void MapearDeDatos()
        {
            cmb_version.SelectedItem = VehiculoActual.Version;
            nud_añoPatentamiento.Value = VehiculoActual.AñoPatentamiento;
            cmb_color.SelectedValue = VehiculoActual.Color.IdColor;
            mtxt_dominio.Text = VehiculoActual.Dominio;
            nud_valorAdquisicion.Value = (decimal)VehiculoActual.ValorAdquisicion;
            nud_valorVenta.Value = (decimal)VehiculoActual.ValorVenta;
            mtxt_nroChasis.Text = VehiculoActual.NroChasis;
            txt_nroMotor.Text = VehiculoActual.NroMotor;
            txt_fechaRegistro.Text = Convert.ToString(VehiculoActual.FechaRegistro);
            nud_kilometraje.Value = VehiculoActual.Kilometraje;
            txt_observaciones.Text = VehiculoActual.Observaciones;
            txt_fechaEstado.Text = Convert.ToString(VehiculoActual.Estado.Fecha);
            txt_tipoEstado.Text = Convert.ToString(VehiculoActual.Estado.TipoEstado);

            if (VehiculoActual.EsUsado == true)
            {
                cmb_uso.SelectedItem = "Usado";
            }
            else
            {
                cmb_uso.SelectedItem = "0 KM";
                nud_kilometraje.Enabled = false;
            }
        }


        protected bool ValidarMarcaModeloVersion()
        {
            bool opCorrecta = false;
            
            if (cmb_marca.SelectedItem != null)
            {
                if (cmb_modelo.SelectedItem != null)
                {
                    if (cmb_version.SelectedItem != null)
                    {
                        opCorrecta = true;
                    }
                    else
                    {
                        Notificador.NotificarAdvertencia(Notificador.TipoDato.Version);
                    }
                }
                else
                {
                    Notificador.NotificarAdvertencia(Notificador.TipoDato.Modelo);
                }
            }
            else
            {
                Notificador.NotificarAdvertencia(Notificador.TipoDato.Marca);
            }

            return opCorrecta;
        }


        protected bool ValidarTodosCampos()
        {
            bool camposValidos = false;

            if (ValidarMarcaModeloVersion())
            {
                if (!mtxt_nroChasis.MaskFull)
                {
                    Notificador.NotificarAdvertencia(Notificador.TipoDato.NroChasis);
                }
                else
                {
                    if (txt_nroMotor.Text.Trim() == "") // VALIDAR QUE NROMOTOR NO TENGA UNA MASCARA
                    {
                        Notificador.NotificarAdvertencia(Notificador.TipoDato.NroMotor);
                    }
                    else
                    {
                        if (cmb_marca.Items.Count == 0)
                        {
                            Notificador.NotificarAdvertencia(Notificador.TipoDato.Marca);
                        }
                        else
                        {
                            if (cmb_modelo.Items.Count == 0)
                            {
                                Notificador.NotificarAdvertencia(Notificador.TipoDato.Modelo);
                            }
                            else
                            {
                                if (cmb_version.Items.Count == 0)
                                {
                                    Notificador.NotificarAdvertencia(Notificador.TipoDato.Version);
                                }
                                else
                                {
                                    if (cmb_color.Items.Count == 0)
                                    {
                                        Notificador.NotificarAdvertencia(Notificador.TipoDato.Color);
                                    }
                                    else
                                    {
                                        camposValidos = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return camposValidos;
        }


        protected void BuscarVehiculos()
        {
            try
            {
                if (ValidarMarcaModeloVersion())
                {
                    ListaVehiculos = logicaVehiculo.BuscarVehiculosPorMarcaModeloVersion((Marca)cmb_marca.SelectedItem, (Modelo)cmb_modelo.SelectedItem, (Negocio.Entidades.Version)cmb_version.SelectedItem);

                    if (ListaVehiculos.Count != 0)
                    {
                        CargarDgv_vehiculos();

                        btn_aceptar.Enabled = true;
                    }
                    else
                    {
                        Notificador.NotificarAdvertencia(Notificador.TipoDato.NoExistenVehiculos);

                        VaciarControles();
                    }
                }
                else
                {
                    ListaVehiculos = new List<Vehiculo>();

                    VaciarControles();
                }
            }
            catch (Exception ex)
            {
                Notificador.NotificarErrorInesperado(ex);
            }
        }


        protected void VaciarControles()
        {
            dgv_vehiculos.DataSource = null; // Limpiar grilla dgv_vehiculos

            FormatearDgv_vehiculos();

            cmb_color.SelectedItem = null;
            nud_añoPatentamiento.Value = 0;
            cmb_uso.SelectedItem = null;
            txt_observaciones.Text = "";
            mtxt_dominio.Text = "";
            nud_kilometraje.Value = 0;
            nud_valorAdquisicion.Value = 0;
            nud_valorVenta.Value = 0;
            mtxt_nroChasis.Text = "";
            txt_nroMotor.Text = "";
            txt_fechaRegistro.Text = "";
            txt_tipoEstado.Text = "";
            txt_fechaEstado.Text = "";

            btn_aceptar.Enabled = false;
        }

        #endregion



        #region Métodos para el DataGridView dgv_vehiculos

        // Da formato a las columnas que muestra el dgv_vehiculos
        protected void FormatearDgv_vehiculos()
        {
            // Limipiar las columnas de dgv_vehiculos.
            dgv_vehiculos.Columns.Clear();

            // Agregar las columnas que mostrará el dgv_vehiculos.
            dgv_vehiculos.Columns.Add("Marca", "Marca");
            dgv_vehiculos.Columns.Add("Modelo", "Modelo");
            dgv_vehiculos.Columns.Add("Version", "Version");
            dgv_vehiculos.Columns.Add("Color", "Color");
            dgv_vehiculos.Columns.Add("AñoPatentamiento", "Año de patentamiento");
            dgv_vehiculos.Columns.Add("ValorVenta", "Valor de venta");
            dgv_vehiculos.Columns.Add("Vehiculo", "");

            // Setear que propiedad de los objetos de la lista que contiene el DataSource mostrará cada columna.
            dgv_vehiculos.Columns["Marca"].DataPropertyName = "NombreMarca";
            dgv_vehiculos.Columns["Modelo"].DataPropertyName = "NombreModelo";
            dgv_vehiculos.Columns["Version"].DataPropertyName = "NombreVersion";
            dgv_vehiculos.Columns["Color"].DataPropertyName = "NombreColor";
            dgv_vehiculos.Columns["AñoPatentamiento"].DataPropertyName = "AñoPatentamiento";
            dgv_vehiculos.Columns["ValorVenta"].DataPropertyName = "ValorVenta";
            dgv_vehiculos.Columns["Vehiculo"].DataPropertyName = "Vehiculo";
            dgv_vehiculos.Columns["Vehiculo"].Visible = false;
        }


        // Carga los vehículos en dgv_vehiculos
        protected void CargarDgv_vehiculos()
        {
            List<VisualizadorVehiculo> listaVisualizadores = new List<VisualizadorVehiculo>();

            // La clase Vehiculo tiene propiedades de segundo, tercer y hasta cuarto nivel (Ejemplo: nombre de la marca - Vehiculo.Version.Modelo.Marca.Nombre)
            // que no son accesibles por el dgv.
            // La clase VisualizadorVehiculo se utiliza para lograr el acceso requerido a dichas propiedades de un Vehiculo
            // y poder visualizarlas correctamente en el dgv_vehiculos.

            foreach (Vehiculo vehiculoActual in ListaVehiculos)
            {
                VisualizadorVehiculo visualizadorVehiculoActual = new VisualizadorVehiculo();

                visualizadorVehiculoActual.NombreMarca = vehiculoActual.Version.Modelo.Marca.Nombre;
                visualizadorVehiculoActual.NombreModelo = vehiculoActual.Version.Modelo.Nombre;
                visualizadorVehiculoActual.NombreVersion = vehiculoActual.Version.Nombre;
                visualizadorVehiculoActual.NombreColor = vehiculoActual.Color.Nombre;
                visualizadorVehiculoActual.AñoPatentamiento = vehiculoActual.AñoPatentamiento;
                visualizadorVehiculoActual.ValorVenta = vehiculoActual.ValorVenta;

                // Se setea el vehiculoActual porque se requiere para asignarlo a la venta cuando se 
                // seleccione el boton Vender. 
                visualizadorVehiculoActual.Vehiculo = vehiculoActual;

                listaVisualizadores.Add(visualizadorVehiculoActual);
            }

            dgv_vehiculos.DataSource = listaVisualizadores;

            VehiculoActual = (Vehiculo)dgv_vehiculos.Rows[0].Cells[6].Value;
            MapearDeDatos();
        }

        #endregion



        #region Comportamiento de botones

        protected virtual void btn_aceptar_Click(object sender, EventArgs e)
        {

        }


        protected virtual void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarVehiculos();
        }


        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        #endregion



        #region Cargadores de ComboBox: Marca, Modelo, Version y Color

        protected void CargarMarcasModelosVersiones()
        {
            List<Marca> listaMarcas = new List<Marca>();

            try
            {
                listaMarcas = logicaMarca.GetTodasMarcas();

                // Asignar la lista de marcas como DataSource del cmb_marca
                cmb_marca.DataSource = listaMarcas;

                // Si la lista de marcas no está vacia
                if (listaMarcas.Count != 0)
                {
                    // Obtener la marca seleccionada en el comboBox           
                    Marca marcaSeleccionada = (Marca)cmb_marca.SelectedItem;
                    // Asignar la lista de modelos de la marca seleccionada como DataSource del cmb_modelos
                    cmb_modelo.DataSource = marcaSeleccionada.ListaModelos;

                    // Si la lista de modelos no esta vacía
                    if (marcaSeleccionada.ListaModelos.Count != 0)
                    {
                        // Obtener el modelo seleccionado en el comboBox
                        Modelo modeloSeleccionado = (Modelo)cmb_modelo.SelectedItem;
                        // Asignar la lista de versiones del modelo seleccionado como DataSource del cmb_versiones
                        cmb_version.DataSource = modeloSeleccionado.ListaVersiones;
                    }
                }
            }
            catch (Exception ex)
            {
                Notificador.NotificarErrorInesperado(ex);
            }
        }


        protected void CargarColores()
        {
            try
            {
                cmb_color.DataSource = logicaColor.GetTodosColores();
            }
            catch (Exception ex)
            {
                Notificador.NotificarErrorInesperado(ex);
            }
        }

        #endregion



        #region Comportamiento de controles

        // Cuando se clickea alguna celda del dgv_vehiculos
        protected virtual void dgv_vehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Asinga el vehiculo seleccionado como VehiculoActual
            if(ListaVehiculos.Count != 0)
            {
                VehiculoActual = (Vehiculo)dgv_vehiculos.SelectedRows[0].Cells[6].Value;

                MapearDeDatos();

                btn_aceptar.Enabled = true;
            }
        }


        // Deshabilita la escritura en los controles
        protected void DeshabilitarControles()
        {
            cmb_uso.Enabled = false;
            nud_añoPatentamiento.Enabled = false;
            cmb_color.Enabled = false;
            mtxt_dominio.Enabled = false;
            nud_kilometraje.Enabled = false;
            nud_valorAdquisicion.Enabled = false;
            nud_valorVenta.Enabled = false;
            mtxt_nroChasis.Enabled = false;
            txt_nroMotor.Enabled = false;
            txt_fechaEstado.Enabled = false;
            txt_fechaRegistro.Enabled = false;
            txt_tipoEstado.Enabled = false;
            txt_fechaEstado.Enabled = false;
            txt_observaciones.Enabled = false;
        }


        // Cuando cambia la marca seleccionada carga nuevamente los modelos de dicha marca.
        protected void cmb_marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener la marca seleccionada en el comboBox           
            Marca marcaSeleccionada = (Marca)cmb_marca.SelectedItem;
            // Asignar la lista de modelos de la marca seleccionada como DataSource del cmb_modelos
            cmb_modelo.DataSource = marcaSeleccionada.ListaModelos;
            if (marcaSeleccionada.ListaModelos.Count == 0)
            {
                cmb_version.DataSource = new List<Negocio.Entidades.Version>();
            }
        }


        // Cuando cambia el modelo seleccionado carga nuevamente las versiones de dicho modelo.
        protected void cmb_modelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el modelo seleccionado en el comboBox
            Modelo modeloSeleccionado = (Modelo)cmb_modelo.SelectedItem;
            // Asignar la lista de versiones del modelo seleccionado como DataSource del cmb_versiones
            cmb_version.DataSource = modeloSeleccionado.ListaVersiones;
        }


        protected virtual void cmb_uso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion



        #region Eventos de botones para Registrar Marca, Modelo, Version y Color

        protected void btn_registrarMarca_Click(object sender, EventArgs e)
        {
            FormRegistrarMarca registrarMarca = new FormRegistrarMarca();

            if (registrarMarca.ShowDialog() == DialogResult.OK)
            {
                CargarMarcasModelosVersiones();
                registrarMarca.Dispose();
            }
        }


        protected void btn_registrarModelo_Click(object sender, EventArgs e)
        {
            FormRegistrarModelo registrarModelo = new FormRegistrarModelo();
            registrarModelo.SetListaMarcas((List<Marca>)cmb_marca.DataSource);
            registrarModelo.SetMarcaActual((Marca)cmb_marca.SelectedItem);

            if (registrarModelo.ShowDialog() == DialogResult.OK)
            {
                CargarMarcasModelosVersiones();
                registrarModelo.Dispose();
            }
        }


        protected void btn_registrarVersion_Click(object sender, EventArgs e)
        {
            FormRegistrarVersion registrarVersion = new FormRegistrarVersion();
            registrarVersion.SetListaModelos((List<Modelo>)cmb_modelo.DataSource);
            registrarVersion.SetListaMarcas((List<Marca>)cmb_marca.DataSource);
            registrarVersion.SetMarcaModeloActuales((Marca)cmb_marca.SelectedItem, (Modelo)cmb_modelo.SelectedItem);

            if (registrarVersion.ShowDialog() == DialogResult.OK)
            {
                CargarMarcasModelosVersiones();
                registrarVersion.Dispose();
            }
        }


        protected void btn_registrarColor_Click(object sender, EventArgs e)
        {
            FormRegistrarColor registrarColor = new FormRegistrarColor();

            if (registrarColor.ShowDialog() == DialogResult.OK)
            {
                CargarColores();
                registrarColor.Dispose();
            }
        }

        #endregion

        
    }
}
