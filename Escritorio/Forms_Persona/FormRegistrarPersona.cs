using Interfaz.Escritorio.Mensajes;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utilidades;

namespace Interfaz.Escritorio.Forms_Persona
{
    public partial class FormRegistrarPersona : FormBasePersona
    {
        #region Constructores

        public FormRegistrarPersona(Persona.eRol rol) : base(rol)
        {
            InitializeComponent();
        }


        private void FormRegistrarPersona_Load(object sender, EventArgs e)
        {
            btn_aceptar.Text = "Registrar";
            btn_buscar.Visible = false;

            if (Rol == Persona.eRol.Cliente)
            {
                Text = "Registro de Cliente";
            }
            else
            {
                Text = "Registro de Empleado";
                cmb_perfil.SelectedIndex = 0;
            }
        }

        #endregion


        protected override void MapearADatos()
        {
            base.MapearADatos();

            PersonaActual.NroDoc = mtxt_dni.Text;
        }
        

        // Registrar una persona
        protected override void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                MapearADatos();

                PersonaActual.Contraseña = GeneradorContraseñas.GenerarContraseña();

                try
                {
                    logicaPersona.RegistrarPersona(PersonaActual);
                    Notificador.NotificarOperacionRealizada();
                    // AGREGAR CODIGO PARA ENVIAR UN EMAIL CON LA CONTRASEÑA AL EMPLEADO

                    Dispose();
                }
                catch (Exception ex)
                {
                    Notificador.NotificarErrorInesperado(ex);
                }
            }
        }
    }
}
