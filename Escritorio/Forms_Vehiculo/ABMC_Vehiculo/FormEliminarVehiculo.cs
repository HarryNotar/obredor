using Interfaz.Escritorio.Mensajes;
using System;

namespace Interfaz.Escritorio.Forms_Vehiculo.ABMC_Vehiculo
{
    public partial class FormEliminarVehiculo : Interfaz.Escritorio.Forms_Vehiculo.ABMC_Vehiculo.FormBaseVehiculo
    {
        public FormEliminarVehiculo()
        {
            InitializeComponent();

            Text = "Eliminación de Vehículo";

            btn_aceptar.Text = "Eliminar";
            btn_aceptar.Enabled = false;
        }


        protected override void btn_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                logicaVehiculo.EliminarVehiculo(VehiculoActual);

                Notificador.NotificarOperacionRealizada();

                BuscarVehiculos();
            }
            catch(Exception ex)
            {
                Notificador.NotificarErrorInesperado(ex);
            }
        }
    }
}
