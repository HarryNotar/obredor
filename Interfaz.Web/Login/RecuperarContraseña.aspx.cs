using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Configuration;
using Negocio.Entidades;
using Negocio.Logica;
using System.Web.SessionState;
using System.Web.UI.WebControls;

namespace Web.WebForms_Login
{
    public partial class RecuperarContraseña : System.Web.UI.Page
    {
        private LogicaPersona logicaPersona;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/WebForms_Login/Login.aspx");  
        }

        protected void BtnRecuperarContraseña_Click(object sender, EventArgs e)
        {
            bool opCorrecta = false;

            if (validarCampos())
            {
                try
                {
                    opCorrecta = logicaPersona.RecuperarContraseña(TxtBoxDNI.Text, TxtBoxEmail.Text);
                }
                catch (Exception ex)
                {
                    Page.Response.Write("Error inesperado");
                }
                finally
                {
                    if (opCorrecta)
                    {
                        Page.Response.Write("La operación ha sido realizada satisfactoriamente");
                        Page.Response.Redirect("~/Home.aspx");
                    }
                    else
                    {
                        Page.Response.Write("El número de documento y la dirección de e-mail ingresadas no corresponden a un usuario válido. Por favor, vuelva a intentarlo.");
                    }
                }
            }


        }


        private bool validarCampos()
        {
            bool camposValidos = false;

             if (TxtBoxDNI.Text.Equals(""))
            {
                Page.Response.Write("El campo DNI es obligatorio");
            }            
            else
            {
                if (TxtBoxEmail.Text.Equals(""))
                {
                    Page.Response.Write("El campo Dirección de e-mail es obligatorio.");
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