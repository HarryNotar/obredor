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
    public partial class FormModificarPersona : Interfaz.Escritorio.Forms_Persona.FormBasePersona
    {
        #region Constructores

        public FormModificarPersona()
        {
            InitializeComponent();
        }

        // Constructor para opción de Modificar Empleados y Clientes
        public FormModificarPersona(Persona.eRol rol): base(rol)
        {
            btn_aceptar.Text = "Modificar";
            btn_aceptar.Enabled = false;

            if(PersonaActual.Perfil != Persona.ePerfil.Administrador)
            {
                cmb_perfil.Enabled = false;
            }

            if (Rol == Persona.eRol.Cliente)
            {
                Text = "Modificar Cliente";
            }
            else
            {
                Text = "Modificar Empleado";
            }

            DeshabilitarEscrituraControles();
        }


        // Constructor para opción de Modificar Mi Perfil
        public FormModificarPersona(Persona.eRol rol, String nroDoc):base(rol)
        {
            mtxt_dni.Enabled = false;
            mtxt_dni.Text = nroDoc;

            btn_aceptar.Text = "Modificar";
            btn_aceptar.Enabled = true;

            btn_buscar.Visible = false;

            Text = "Modificar mi perfil";

            if (PersonaActual.Perfil != Persona.ePerfil.Administrador)
            {
                cmb_perfil.Enabled = false;
            }

            ConsultarPersona();
        }

        #endregion


        #region Comportamiento de botones

        // Modificar una persona
        protected override void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                MapearADatos();

                try
                {
                    logicaPersona.ModificarPersona(PersonaActual);
                    Notificador.NotificarOperacionRealizada();

                    Dispose();
                }
                catch (Exception ex)
                {
                    Notificador.NotificarErrorInesperado(ex);
                }
            }
        }


        protected override void btn_buscar_Click(object sender, EventArgs e)
        {
            if (mtxt_dni.MaskFull)
            {
                ConsultarPersona();

                if (PersonaActual != null)
                {
                    btn_aceptar.Enabled = true;
                    HabilitarEscrituraControles();
                }
                else
                {
                    btn_aceptar.Enabled = false;
                    DeshabilitarEscrituraControles();
                }
            }
            else
            {
                Notificador.NotificarAdvertencia(Notificador.TipoDato.NroDoc);
            }
        }

        #endregion


        private void mtxt_dni_TextChanged(object sender, EventArgs e)
        {
            btn_aceptar.Enabled = false;
        }


        protected void HabilitarEscrituraControles()
        {
            txt_apellido.Enabled = true;
            txt_nombre.Enabled = true;
            mtxt_telefono1.Enabled = true;
            mtxt_telefono2.Enabled = true;
            mtxt_telefono3.Enabled = true;
            txt_email.Enabled = true;
            txt_observaciones.Enabled = true;
            if (Rol == Persona.eRol.Cliente)
            {
                txt_localidad.Enabled = true;
                txt_direccion.Enabled = true;
            }
            else
            {
                cmb_perfil.Enabled = true;
            }
        }
    }
}
