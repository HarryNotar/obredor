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
    public partial class Login : System.Web.UI.Page
    {
        private LogicaPersona logicaPersona;
        public Persona PersonaActual { get; set; }


        protected void Page_Load(object sender, EventArgs e)
        {
            logicaPersona = new LogicaPersona();

            //No permite tocar el menu mientras se hace el logueo
            Menu menuPrincipal = (Menu)Page.Master.FindControl("MenuPrincipal");
            foreach (MenuItem m in menuPrincipal.Items)
            {
                m.Enabled = false;
            }
        }

        protected void BtnRecuperarContraseña_Click(object sender, EventArgs e)
        {
            //lleva a webform recuperarcontraseña
            Page.Response.Redirect("~/WebForms_Login/RecuperarContraseña.aspx");

        }

        protected void BtnIngresar_Click(object sender, EventArgs e)
        {
            //codigo para iniciar sesion

            try
            {
                PersonaActual = logicaPersona.LoguearPersona(TxtBoxDNI.Text, TxtBoxContraseña.Text);

                if (PersonaActual == null)
                {
                    Page.Response.Write("Usuario no registrado");
                }
                else
                {
                    //guardo variables de sesion
                    Session["nroDoc"] = PersonaActual.NroDoc;
                    Session["rol"] = PersonaActual.Rol;
                    Session["perfil"] = PersonaActual.Perfil;

                    Page.Response.Redirect("~/Home.aspx");
                }
            }
            catch (Exception ex)
            {
                Page.Response.Write("Error inesperado");
            }
        }




        private bool ValidarCampos()
        {
            bool camposValidos = false;

            if (TxtBoxDNI.Text.Equals(""))
            {
                Page.Response.Write("El campo DNI es obligatorio");
            }
            else
            {
                if (TxtBoxContraseña.Text.Equals(""))
                {
                    Page.Response.Write("El campo contraseña es obligatorio");
                }

                else
                {
                    if (TxtBoxContraseña.Text.Length != 8)
                    {
                        Page.Response.Write("La contraseña debe tener 8 caracteres");
                    }
                    else
                    {
                        camposValidos = true;
                    }
                }
            }

            return camposValidos;
        }

    }
}
