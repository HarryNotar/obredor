using Interfaz.Escritorio.Forms_MedioAbono;
using Interfaz.Escritorio.Mensajes;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interfaz.Escritorio.Forms_Vehiculo
{
    public partial class frm_venderVehiculo : Interfaz.Escritorio.Forms_Vehiculo.frm_baseBuscarVenderVehiculo
    {
        public Venta VentaActual { get; set; }


        public frm_venderVehiculo()
        {
            InitializeComponent();
        }


        public frm_venderVehiculo(Venta ventaActual): this()
        {
            VentaActual = ventaActual;
        }

        
        private void btn_vender_Click(object sender, EventArgs e)
        {
            if (dgv_vehiculos.SelectedRows.Count != 0)
            {
                VentaActual.Vehiculo = (Vehiculo)dgv_vehiculos.SelectedRows[0].Cells[6].Value;

                Visible = false;

                FormDatosPago datosPago = new FormDatosPago(VentaActual);
                datosPago.Show();                
            }
            else
            {
                Notificador.NotificarAdvertencia(Notificador.TipoDato.Vehiculo);
            }
        }
    }
}
