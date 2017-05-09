using Interfaz.Escritorio.Mensajes;
using Negocio.Entidades;
using Negocio.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz.Escritorio.Forms_Comision
{
    public partial class FormRegistrarComision : Form
    {
        private LogicaComision logicaComision;

        public Comision ComisionActual { get; set; }

        public FormRegistrarComision()
        {
            InitializeComponent();

            logicaComision = new LogicaComision();
            ComisionActual = new Comision();
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            ComisionActual.Porcentaje = (double)nud_porcentaje.Value;

            try
            {
                logicaComision.RegistrarComision(ComisionActual);

                Notificador.NotificarOperacionRealizada();

                Dispose();
            }
            catch (Exception ex)
            {
                Notificador.NotificarErrorInesperado(ex);
            }
        }
    }
}
