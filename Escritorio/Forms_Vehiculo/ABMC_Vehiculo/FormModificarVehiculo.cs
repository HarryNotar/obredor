using Interfaz.Escritorio.Mensajes;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Interfaz.Escritorio.Forms_Vehiculo.ABMC_Vehiculo
{
    public partial class FormModificarVehiculo : FormBaseVehiculo
    {

        #region Constructores y Cargadores

        public FormModificarVehiculo()
        {
            InitializeComponent();

            Text = "Modificación de ficha de Vehículo";

            btn_aceptar.Text = "Modificar";
            btn_aceptar.Enabled = false;
        }
        
        #endregion


        #region Comportamiento de botones

        protected override void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarMarcaModeloVersion())
                {
                    ListaVehiculos = logicaVehiculo.BuscarVehiculosPorMarcaModeloVersion((Marca)cmb_marca.SelectedItem, (Modelo)cmb_modelo.SelectedItem, (Negocio.Entidades.Version)cmb_version.SelectedItem);

                    if (ListaVehiculos.Count != 0)
                    {
                        CargarDgv_vehiculos();

                        HabilitarControles();

                        btn_aceptar.Enabled = true;
                    }
                    else
                    {
                        Notificador.NotificarAdvertencia(Notificador.TipoDato.NoExistenVehiculos);

                        VaciarControles();

                        DeshabilitarControles();
                    }
                }
                else
                {
                    ListaVehiculos = new List<Vehiculo>();

                    VaciarControles();

                    DeshabilitarControles();
                }
            }
            catch (Exception ex)
            {
                Notificador.NotificarErrorInesperado(ex);
            }
        }


        protected override void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (ValidarTodosCampos())
            {
                MapearADatos();

                try
                {
                    logicaVehiculo.ModificarVehiculo(VehiculoActual);
                    Notificador.NotificarOperacionRealizada();

                    BuscarVehiculos();
                    DeshabilitarControles();
                }
                catch (Exception ex)
                {
                    Notificador.NotificarErrorInesperado(ex);
                }
            }
        }

        #endregion



        protected void MapearADatos()
        {
            // Asignacion de valores a vehiculoActual
            VehiculoActual.Version = (Negocio.Entidades.Version)cmb_version.SelectedItem;
            VehiculoActual.AñoPatentamiento = (int)nud_añoPatentamiento.Value;
            VehiculoActual.Color = (Color)cmb_color.SelectedItem;
            VehiculoActual.Dominio = mtxt_dominio.Text;
            VehiculoActual.ValorAdquisicion = (double)nud_valorAdquisicion.Value;
            VehiculoActual.ValorVenta = (double)nud_valorVenta.Value;
            VehiculoActual.NroChasis = mtxt_nroChasis.Text;
            VehiculoActual.NroMotor = txt_nroMotor.Text;

            if (cmb_uso.SelectedItem.ToString() == "Usado")
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
        }



        #region Comportamiento de controles

        // Cuando cambia el uso del vehículo, habilita o deshabilita el control para ingresar el kilometraje.
        protected override void cmb_uso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_uso.SelectedIndex == 1) // Si el Vehículo es 0 KM
            {
                nud_kilometraje.Value = 0;
                nud_kilometraje.Enabled = false;
            }
            else
            {
                nud_kilometraje.Enabled = true;

                if(VehiculoActual.Kilometraje != 0)
                {
                    nud_kilometraje.Value = VehiculoActual.Kilometraje;
                }
                else
                {
                    nud_kilometraje.Value = 1;
                }
            }
        }


        protected override void dgv_vehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            base.dgv_vehiculos_CellContentClick(sender, e);

            if (ListaVehiculos.Count != 0)
            {
                HabilitarControles();
            }
        }


        // Habilita la escritura en los botones
        protected void HabilitarControles()
        {
            cmb_marca.Enabled = true;
            cmb_modelo.Enabled = true;
            cmb_version.Enabled = true;
            cmb_uso.Enabled = true;
            nud_añoPatentamiento.Enabled = true;
            cmb_color.Enabled = true;
            txt_observaciones.Enabled = true;
            mtxt_dominio.Enabled = true;
            nud_valorVenta.Enabled = true;

            if (cmb_uso.SelectedIndex == 0) // Si el vehiculo es Usado
            {
                nud_kilometraje.Enabled = true;
            }
            else
            {
                nud_kilometraje.Enabled = false;
            }
        }

        #endregion

    }
}
