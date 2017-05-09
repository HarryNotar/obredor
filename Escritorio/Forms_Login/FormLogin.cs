using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Logica;
using Interfaz.Escritorio.Mensajes;
using Negocio.Entidades;


namespace Interfaz.Escritorio.Forms_Login
{
    public partial class FormLogin : Form
    {
        private LogicaPersona logicaPersona;

        #region Propiedades
        public Persona PersonaActual { get; set; }
        #endregion


        public FormLogin()
        {
            InitializeComponent();

            logicaPersona = new LogicaPersona();
        }


        // CORROBORADO
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                try
                {
                    PersonaActual = logicaPersona.LoguearPersona(mtxt_dni.Text, txt_contraseña.Text);

                    if (PersonaActual == null)
                    {
                        Notificador.NotificarAdvertencia(Notificador.TipoDato.UsuarioNoRegistrado);
                    }
                    else
                    {
                        DialogResult = DialogResult.OK;                       
                    }
                }
                catch (Exception ex)
                {
                    Notificador.NotificarErrorInesperado(ex);
                }
            }
        }


        // CORROBORADO
        private void btn_olvideContraseña_Click(object sender, EventArgs e)
        {
            FormRecuperarContraseña recuperarContraseña = new FormRecuperarContraseña();

            recuperarContraseña.ShowDialog();
        }


        /// <summary>
        /// Valida si se han ingresado todos los campos obligatorios.
        /// </summary>
        /// <returns></returns>
        private bool ValidarCampos()
        {
            bool camposValidos = false;

            if (!mtxt_dni.MaskFull)
            {
                Notificador.NotificarAdvertencia(Notificador.TipoDato.NroDoc);
            }
            else
            {
                if(txt_contraseña.Text.Length != 8)
                {
                    Notificador.NotificarAdvertencia(Notificador.TipoDato.Contraseña);
                }
                else
                {
                    camposValidos = true;
                }
            }

            return camposValidos;
        }
    }
}
