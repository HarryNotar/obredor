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

namespace Interfaz.Escritorio.Forms_Login
{
    public partial class FormRecuperarContraseña : Form
    {
        private LogicaPersona logicaPersona;


        public FormRecuperarContraseña()
        {
            InitializeComponent();

            logicaPersona = new LogicaPersona();
        }



        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }


        // CORROBORADO
        private void btn_recuperar_Click(object sender, EventArgs e)
        {
            bool opCorrecta = false;

            if(ValidarCampos())
            {
                try
                {
                   opCorrecta = logicaPersona.RecuperarContraseña(mtxt_dni.Text, txt_email.Text);
                }
                catch (Exception ex)
                {
                    Notificador.NotificarErrorInesperado(ex);
                }
                finally
                {
                    if (opCorrecta)
                    {
                        Notificador.NotificarOperacionRealizada();
                        Dispose();
                    }
                    else
                    {
                        Notificador.NotificarAdvertencia(Notificador.TipoDato.ClienteNoValido);
                    }
                }
            }
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
                if (txt_email.Text == String.Empty)
                {
                    Notificador.NotificarAdvertencia(Notificador.TipoDato.Email);
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
