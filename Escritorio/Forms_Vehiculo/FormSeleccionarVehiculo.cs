using Interfaz.Escritorio.Forms_MedioAbono;
using Interfaz.Escritorio.Mensajes;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Interfaz.Escritorio.Forms_Vehiculo.ABMC_Vehiculo
{
    public partial class FormSeleccionarVehiculo : FormBaseVehiculo
    {
        public Venta VentaActual { get; set; }


        #region Constructores

        public FormSeleccionarVehiculo()
        {
            InitializeComponent();
        }


        public FormSeleccionarVehiculo(Venta ventaActual) : this()
        {
            VentaActual = ventaActual;

            btn_aceptar.Text = "Seleccionar";
            btn_aceptar.Enabled = false;

            btn_cancelar.Text = "Atrás";

            Text = "Selección de Vehículo";

            btn_registrarColor.Visible = false;
            btn_registrarMarca.Visible = false;
            btn_registrarModelo.Visible = false;
            btn_registrarVersion.Visible = false;
        }

        #endregion



        #region Comportamiento de botones

        protected override void btn_buscar_Click(object sender, EventArgs e)
        {
            List<Vehiculo> listaVehiculosDisponibles = new List<Vehiculo>();

            bool existenVehiculos = false;

            try
            {
                if (ValidarMarcaModeloVersion())
                {
                    ListaVehiculos = logicaVehiculo.BuscarVehiculosPorMarcaModeloVersion((Marca)cmb_marca.SelectedItem, (Modelo)cmb_modelo.SelectedItem, (Negocio.Entidades.Version)cmb_version.SelectedItem);

                    if (ListaVehiculos.Count != 0)
                    {
                        foreach (Vehiculo vehiculoActual in ListaVehiculos)
                        {
                            // Seleccionar los vehiculos disponibles
                            if (vehiculoActual.Estado.TipoEstado == Estado.TiposEstado.Disponible)
                            {
                                listaVehiculosDisponibles.Add(vehiculoActual);
                            }
                        }

                        ListaVehiculos = listaVehiculosDisponibles;

                        if(ListaVehiculos.Count != 0)
                        {
                            CargarDgv_vehiculos();

                            btn_aceptar.Enabled = true;

                            existenVehiculos = true;
                        }
                    }
                }
                else
                {
                    ListaVehiculos = new List<Vehiculo>();

                    VaciarControles();
                }

                if(!existenVehiculos)
                {
                    Notificador.NotificarAdvertencia(Notificador.TipoDato.NoExistenVehiculosDisponibles);

                    VaciarControles();
                }
            }
            catch (Exception ex)
            {
                Notificador.NotificarErrorInesperado(ex);
            }
        }


        protected override void btn_aceptar_Click(object sender, EventArgs e)
        {
            VentaActual.Vehiculo = VehiculoActual;

            FormDatosPago datosPago = new FormDatosPago(VentaActual);

            Visible = false;

            if (datosPago.ShowDialog() == DialogResult.OK)
            {
                Dispose();

                DialogResult = DialogResult.OK;
            }
            else
            {
                Visible = true;
            }
        }

        #endregion

    }
}
