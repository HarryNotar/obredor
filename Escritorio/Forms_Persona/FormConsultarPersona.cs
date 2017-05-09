using Interfaz.Escritorio.Mensajes;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interfaz.Escritorio.Forms_Persona
{
    public partial class FormConsultarPersona : FormBasePersona
    {
        public FormConsultarPersona()
        {
            InitializeComponent();
        }


        // Constructor para opción de Consultar Empleados y Clientes
        public FormConsultarPersona(Persona.eRol rol):base(rol)
        {
            btn_aceptar.Text = "Consultar";
            btn_buscar.Visible = false;

            DeshabilitarEscrituraControles();

            if (Rol == Persona.eRol.Cliente)
            {
                this.Text = "Consulta de perfil de Cliente";
            }
            else
            {
                this.Text = "Consulta de perfil de Empleado";
            }
        }

        // Constructor para opción de Consultar Mi Perfil
        public FormConsultarPersona(Persona.eRol rol, String nroDoc): base(rol)
        {
            mtxt_dni.Enabled = false;
            mtxt_dni.Text = nroDoc;

            btn_cancelar.Visible = false;
            btn_aceptar.Visible = false;
            btn_buscar.Visible = false;

            DeshabilitarEscrituraControles();

            Text = "Consulta de mi perfil";

            ConsultarPersona();
        }


        protected override void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (mtxt_dni.MaskFull)
            {
                ConsultarPersona();
            }
            else
            {
                Notificador.NotificarAdvertencia(Notificador.TipoDato.NroDoc);
            }
        }
    }
}
