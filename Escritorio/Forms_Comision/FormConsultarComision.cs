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
    public partial class FormConsultarComision : Form
    {
        private LogicaComision logicaComision;

        public Comision ComisionActual { get; set; }


        public FormConsultarComision()
        {
            InitializeComponent();

            logicaComision = new LogicaComision();
            ComisionActual = new Comision();
        }


        private void FormConsultarComision_Load(object sender, EventArgs e)
        {            
            try
            {
                ComisionActual = logicaComision.GetComisionActual();
                
                if(ComisionActual != null)
                {
                    nud_porcentaje.Value = Decimal.Round((decimal)ComisionActual.Porcentaje, 2);
                    lbl_fecha_editable.Text = ComisionActual.Fecha.ToString();
                }
                else
                {
                    Notificador.NotificarAdvertencia(Notificador.TipoDato.Comision);
                    lbl_fecha_editable.Text = "-";
                }
            }
            catch(Exception ex)
            {
                Notificador.NotificarErrorInesperado(ex);
            }
        }
    }
}
