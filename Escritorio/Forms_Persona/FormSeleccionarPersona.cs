using Interfaz.Escritorio.Mensajes;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Interfaz.Escritorio.Forms_Vehiculo.ABMC_Vehiculo;

namespace Interfaz.Escritorio.Forms_Persona
{
    public partial class FormSeleccionarPersona : Interfaz.Escritorio.Forms_Persona.FormBasePersona
    {
        #region Propiedades y Enumeraciones

        public Venta VentaActual { get; set; }

        #endregion


        #region Constructores

        public FormSeleccionarPersona()
        {
            InitializeComponent();
        }


        public FormSeleccionarPersona(Venta ventaActual):base(Persona.eRol.Cliente)
        {
            VentaActual = ventaActual;

            Text = "Selección de Cliente";

            btn_aceptar.Text = "Seleccionar";
            btn_aceptar.Enabled = false;

            DeshabilitarEscrituraControles();
        }
        
        #endregion


        #region Comportamiento de botones

        // Modificar una persona
        protected override void btn_aceptar_Click(object sender, EventArgs e)
        {
            VentaActual.Cliente = PersonaActual;

            FormSeleccionarVehiculo seleccionarVehiculo = new FormSeleccionarVehiculo(VentaActual);

            Visible = false;

            if (seleccionarVehiculo.ShowDialog() == DialogResult.OK)
            {
                Dispose();
                DialogResult = DialogResult.OK;
            }
            else
            {
                Visible = true;
            }
        }


        // Buscar un persona
        protected override void btn_buscar_Click(object sender, EventArgs e)
        {
            if (mtxt_dni.MaskFull)
            {
                ConsultarPersona();

                if (PersonaActual != null)
                {
                    btn_aceptar.Enabled = true;
                }
                else
                {
                    btn_aceptar.Enabled = false;
                }
            }
            else
            {
                Notificador.NotificarAdvertencia(Notificador.TipoDato.NroDoc);
            }
        }


        private void mtxt_dni_TextChanged(object sender, EventArgs e)
        {
            btn_aceptar.Enabled = false;
        }

        #endregion
    }
}
