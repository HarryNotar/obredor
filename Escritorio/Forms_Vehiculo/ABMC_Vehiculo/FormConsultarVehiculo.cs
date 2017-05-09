
namespace Interfaz.Escritorio.Forms_Vehiculo.ABMC_Vehiculo
{
    public partial class FormConsultarVehiculo : FormBaseVehiculo
    {
        public FormConsultarVehiculo()
        {
            InitializeComponent();

            btn_aceptar.Visible = false;
            btn_cancelar.Visible = false;

            Text = "Consulta de ficha de Vehículo";

            btn_registrarColor.Visible = false;
            btn_registrarMarca.Visible = false;
            btn_registrarModelo.Visible = false;
            btn_registrarVersion.Visible = false;
        }
    }
}
