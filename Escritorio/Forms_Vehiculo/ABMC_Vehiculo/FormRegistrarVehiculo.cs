using Interfaz.Escritorio.Forms_Vehiculo.AB_Color;
using Interfaz.Escritorio.Forms_Vehiculo.AB_Marca;
using Interfaz.Escritorio.Forms_Vehiculo.AB_Modelo;
using Interfaz.Escritorio.Forms_Vehiculo.AB_Version;
using Interfaz.Escritorio.Mensajes;
using Negocio.Entidades;
using Negocio.Logica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Interfaz.Escritorio.Forms_Vehiculo.ABMC_Vehiculo
{
    public partial class FormRegistrarVehiculo : Form
    {
        #region Propiedades y Atributos

        private LogicaVehiculo logicaVehiculo;
        private LogicaColor logicaColor;
        private LogicaMarca logicaMarca;
        private LogicaModelo logicaModelo;
        private LogicaVersion logicaVersion;

        public Vehiculo VehiculoActual { get; set; }

        #endregion


        #region Constructores

        public FormRegistrarVehiculo()
        {
            InitializeComponent();

            logicaVehiculo = new LogicaVehiculo();
            logicaColor = new LogicaColor();
            logicaMarca = new LogicaMarca();
            logicaModelo = new LogicaModelo();
            logicaVersion = new LogicaVersion();

            VehiculoActual = new Vehiculo();

            // Setea que atributo de los objetos se mostrará en el comboBox.
            cmb_modelo.DisplayMember = "Nombre";
            cmb_marca.DisplayMember = "Nombre";
            cmb_color.DisplayMember = "Nombre";
            cmb_version.DisplayMember = "Nombre";

            // Setea el Uso a "Usado".
            cmb_uso.SelectedIndex = 0;

            // Setea el kilometraje con valor 1 km y el minimo del nud en 1 (si es usado no puede tener 0 km).
            nud_kilometraje.Minimum = 1;
            nud_kilometraje.Value = 1;

            cb_estaPatentado.Checked = true;
            nud_añoPatentamiento.Value = 2000;

            // Carga los comboBox con valores
            CargarMarcasModelosVersiones();
            CargarColores();
        }

        #endregion


        #region Funciones internas


        private void MapearDeDatos()
        {
            cmb_version.SelectedItem = VehiculoActual.Version;
            nud_añoPatentamiento.Value = VehiculoActual.AñoPatentamiento;
            cmb_color.SelectedValue = VehiculoActual.Color.IdColor;
            mtxt_dominio.Text = VehiculoActual.Dominio;
            nud_valorAdquisicion.Value = (decimal)VehiculoActual.ValorAdquisicion;
            nud_valorVenta.Value = (decimal)VehiculoActual.ValorVenta;
            mtxt_nroChasis.Text = VehiculoActual.NroChasis;
            txt_nroMotor.Text = VehiculoActual.NroMotor;
            nud_kilometraje.Value = VehiculoActual.Kilometraje;
            txt_observaciones.Text = VehiculoActual.Observaciones;

            if (VehiculoActual.EsUsado == true)
            {
                cmb_uso.SelectedItem = "Usado";
            }
            else
            {
                cmb_uso.SelectedItem = "0 KM";
            }
        }


        private bool ValidarTodosCampos()
        {
            bool camposValidos = false;

            if (cmb_marca.SelectedItem == null)
            {
                Notificador.NotificarAdvertencia(Notificador.TipoDato.Marca);
            }
            else
            {
                if (cmb_modelo.SelectedItem == null)
                {
                    Notificador.NotificarAdvertencia(Notificador.TipoDato.Modelo);
                }
                else
                {
                    if (cmb_version.SelectedItem == null)
                    {
                        Notificador.NotificarAdvertencia(Notificador.TipoDato.Version);
                    }
                    else
                    {
                        if (nud_añoPatentamiento.Value != 0 && !mtxt_dominio.MaskFull)
                        {
                            // Si el vehículo está patentado y el dominio no fue completado. Pedir el ingreso del dominio.
                            Notificador.NotificarAdvertencia(Notificador.TipoDato.Dominio);
                        }
                        else
                        {
                            if (cmb_uso.SelectedIndex == 0 && nud_kilometraje.Value == 0)
                            {
                                // Si el vehículo es Usado y el kilometraje es 0. Pedir el ingreso del kilometraje.
                                Notificador.NotificarAdvertencia(Notificador.TipoDato.Kilometraje);
                            }
                            else
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
                        }
                    }
                }
            }

            return camposValidos;
        }


        private void MapearADatos()
        {
            // Asignacion de valores a vehiculoActual
            VehiculoActual.Version = (Negocio.Entidades.Version)cmb_version.SelectedItem;
            VehiculoActual.AñoPatentamiento = (int)nud_añoPatentamiento.Value;
            VehiculoActual.Color = (Color)cmb_color.SelectedItem;
            VehiculoActual.ValorAdquisicion = (double)nud_valorAdquisicion.Value;
            VehiculoActual.ValorVenta = (double)nud_valorVenta.Value;
            VehiculoActual.NroChasis = mtxt_nroChasis.Text;
            VehiculoActual.NroMotor = txt_nroMotor.Text;

            if(nud_añoPatentamiento.Value != 0)
            {
                VehiculoActual.Dominio = mtxt_dominio.Text;
            }
            else
            {
                VehiculoActual.Dominio = "";
            }

            if (cmb_uso.SelectedIndex == 0) // Si el Vehículo es Usado
            {
                VehiculoActual.EsUsado = true;
            }
            else
            {
                VehiculoActual.EsUsado = false;
            }

            if (nud_kilometraje.Enabled)
            {
                VehiculoActual.Kilometraje = (int)nud_kilometraje.Value;
            }
            else
            {
                VehiculoActual.Kilometraje = 0;
            }

            if (txt_observaciones.Text.ToString() != "")
            {
                VehiculoActual.Observaciones = txt_observaciones.Text;
            }
            else
            {
                VehiculoActual.Observaciones = "-";
            }

            Estado estadoActual = new Estado();

            VehiculoActual.Estado = estadoActual;
        }


        #endregion



        #region Cargadores de ComboBox: Marca, Modelo, Version y Color

        private void CargarMarcasModelosVersiones()
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


        private void CargarColores()
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
        private void cmb_modelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el modelo seleccionado en el comboBox
            Modelo modeloSeleccionado = (Modelo)cmb_modelo.SelectedItem;
            // Asignar la lista de versiones del modelo seleccionado como DataSource del cmb_versiones
            cmb_version.DataSource = modeloSeleccionado.ListaVersiones;
        }


        private void mtxt_dominio_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ToolTip tt_dominio = new ToolTip();
            tt_dominio.ToolTipTitle = "Ingreso inválido";
            tt_dominio.Show("El caracter no corresponde al formato válido del número de dominio.", mtxt_dominio, 10, 30, 3000);
        }


        private void mtxt_nroChasis_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            ToolTip tt_dominio = new ToolTip();
            tt_dominio.ToolTipTitle = "Ingreso inválido";
            tt_dominio.Show("El caracter no corresponde al formato válido del número de chasis.", mtxt_nroChasis, 10, 30, 3000);
        }


        // Cuando cambia el uso del vehículo, habilita o deshabilita el control para ingresar el kilometraje.
        private void cmb_uso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_uso.SelectedIndex == 1) // Si el Vehículo es 0 KM
            {
                nud_kilometraje.Minimum = 0;
                nud_kilometraje.Value = 0;
                nud_kilometraje.Enabled = false;
            }
            else
            {
                nud_kilometraje.Enabled = true;
                nud_kilometraje.Minimum = 1;
                nud_kilometraje.Value = 1;
            }
        }


        private void cb_estaPatentado_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_estaPatentado.Checked) // Si el Vehículo está patentado
            {
                nud_añoPatentamiento.Enabled = true;
                nud_añoPatentamiento.Value = 2000;

                mtxt_dominio.Enabled = true;
            }
            else
            {
                nud_añoPatentamiento.Enabled = false;
                nud_añoPatentamiento.Value = 0;

                mtxt_dominio.Enabled = false;
                mtxt_dominio.Text = "";
            }
        }

        #endregion



        #region Comportamiento de botones

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }


        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (ValidarTodosCampos())
            {
                MapearADatos();

                try
                {
                    logicaVehiculo.RegistrarVehiculo(VehiculoActual);

                    Notificador.NotificarOperacionRealizada();

                    Dispose();
                }
                catch (Exception ex)
                {
                    Notificador.NotificarErrorInesperado(ex);
                }
            }
        }

        #endregion



        #region Eventos de botones para Registrar Marca, Modelo, Version y Color

        private void btn_registrarMarca_Click(object sender, EventArgs e)
        {
            FormRegistrarMarca registrarMarca = new FormRegistrarMarca();

            if (registrarMarca.ShowDialog() == DialogResult.OK)
            {
                CargarMarcasModelosVersiones();
                registrarMarca.Dispose();
            }
        }


        private void btn_registrarModelo_Click(object sender, EventArgs e)
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


        private void btn_registrarVersion_Click(object sender, EventArgs e)
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


        private void btn_registrarColor_Click(object sender, EventArgs e)
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
