using System;
using System.Windows.Forms;
using Negocio.Entidades;
using Interfaz.Escritorio.Mensajes;
using Negocio.Logica;

namespace Interfaz.Escritorio.Forms_MedioAbono
{
    public partial class FormDatosPago : Form
    {

        #region Propiedades y Atributos

        private LogicaVenta logicaVenta;

        private double montoSinAsignar;
        private double montoVenta;
        private double montoCuota;

        public Venta VentaActual { get; set; }

        #endregion


        #region Constructores

        public FormDatosPago()
        {
            InitializeComponent();
        }


        public FormDatosPago(Venta venta):this()
        {
            logicaVenta = new LogicaVenta();

            VentaActual = venta;

            lbl_total_editable.Text = Convert.ToString(VentaActual.Vehiculo.ValorVenta);

            lbl_montoRestante_editable.Text = Convert.ToString(VentaActual.Vehiculo.ValorVenta);
            montoVenta = VentaActual.Vehiculo.ValorVenta;

            // Inicialimente el monto sin asignar es igual al monto total de la venta
            montoSinAsignar = montoVenta;

            montoCuota = 0;
            lbl_montoCuota_editable.Text = "0";

            nud_tasaInteresAnual.Enabled = false;
            nud_cantCuotas.Enabled = false;
        }

        #endregion


        #region Comportamiento de controles

        private void nud_montoEfectivo_ValueChanged(object sender, EventArgs e)
        {
            ActualizarMontorSinAsignar();
        }


        private void nud_montoFinanciado_ValueChanged(object sender, EventArgs e)
        {
            ActualizarMontorSinAsignar();

            if(nud_montoFinanciado.Value != 0)
            {
                nud_tasaInteresAnual.Enabled = true;
                nud_cantCuotas.Enabled = true;

                ActualizarMontoCuota();
            }
            else
            {
                nud_cantCuotas.Value = 0;
                nud_tasaInteresAnual.Value = 0;
                montoCuota = 0;

                nud_tasaInteresAnual.Enabled = false;
                nud_cantCuotas.Enabled = false;
            }
        }


        private void ActualizarMontorSinAsignar()
        {
            double montoSinAsignarActual = montoVenta - (double)nud_montoEfectivo.Value - (double)nud_montoFinanciado.Value;

            if (montoSinAsignarActual < 0)
            {
                Notificador.NotificarAdvertencia(Notificador.TipoDato.MontoSobreAsignado);
            }
            else
            {
                montoSinAsignar = montoSinAsignarActual;
                lbl_montoRestante_editable.Text = Convert.ToString(montoSinAsignar);
                ActualizarMontoCuota();
            }
        }


        private void nud_tasaInteresAnual_ValueChanged(object sender, EventArgs e)
        {
            ActualizarMontoCuota();
        }


        private void nud_cantCuotas_ValueChanged(object sender, EventArgs e)
        {
            ActualizarMontoCuota();
        }

        #endregion


        public void ActualizarMontoCuota()
        {
            decimal montoCuotaMostrable;

            if(nud_cantCuotas.Value != 0)
            {
                montoCuota = Convert.ToDouble(nud_montoFinanciado.Value / nud_cantCuotas.Value * (nud_tasaInteresAnual.Value / 1200 + 1));

                montoCuotaMostrable = decimal.Round((decimal)montoCuota, 2);
            }
            else
            {
                montoCuotaMostrable = 0;
            }

            lbl_montoCuota_editable.Text = montoCuotaMostrable.ToString();
        }


        #region Comportamiento de botones

        private void btn_realizarVenta_Click(object sender, EventArgs e)
        {
            if(ValidarCampos())
            {
                VentaActual.MontoEfectivo = (double)nud_montoEfectivo.Value;
                VentaActual.MontoFinanciado = (double)nud_montoFinanciado.Value;
                VentaActual.TasaInteresAnual = (double)nud_tasaInteresAnual.Value;
                VentaActual.CantCuotas = (int)nud_cantCuotas.Value;
                VentaActual.MontoCuota = montoCuota;

                try
                {
                    logicaVenta.RegistrarVenta(VentaActual);

                    Notificador.NotificarOperacionRealizada();

                    DialogResult = DialogResult.OK;

                    Dispose();
                }
                catch (Exception ex)
                {
                    Notificador.NotificarErrorInesperado(ex);
                }
            }
        }


        private void btn_atras_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        #endregion


        #region Funcionalidades internas
        
        private bool ValidarCampos()
        {
            bool camposValidos = false;

            if (montoSinAsignar == 0)
            {
                if (nud_montoFinanciado.Value != 0 && nud_cantCuotas.Value == 0)
                {
                    Notificador.NotificarAdvertencia(Notificador.TipoDato.CantCuotas);
                }
                else
                {
                    camposValidos = true;
                }
            }
            else
            {
                Notificador.NotificarAdvertencia(Notificador.TipoDato.MontoSinAsignar);
            }

            return camposValidos;
        }

        #endregion


    }
}
