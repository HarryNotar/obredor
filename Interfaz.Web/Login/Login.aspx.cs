using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio.Entidades;
using Negocio.Logica;

namespace Interfaz.Web.Login
{
    public partial class Login : System.Web.UI.Page
    {
        LogicaPersona logicaPersona;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nroDoc"] != null)
            {
                Response.Redirect("/");
            }
            else
            {
                logicaPersona = new LogicaPersona();

                div_advertencia.Visible = false;
                div_error.Visible = false;
            }
        }

        protected void btn_ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio.Entidades.Persona personaActual = logicaPersona.LoguearPersona(txt_nroDoc.Text, txt_contraseña.Text);

                if (personaActual == null)
                {
                    div_advertencia.Visible = true;
                    div_error.Visible = false;
                    lbl_mensaje_advertencia.Text = "El número de documento y la contraseña ingresadas no corresponden a un usuario válido. Si aún no se ha registrado, solicite el registro al Administrador.";
                }
                else
                {
                    Session["nroDoc"] = personaActual.NroDoc;
                    Session["rol"] = personaActual.Rol.ToString();
                    Session["perfil"] = personaActual.Perfil.ToString();

                    Response.Redirect("/");
                }
            }
            catch (Exception ex)
            {
                div_error.Visible = true;
                div_advertencia.Visible = false;
                lbl_mensaje_error.Text = ex.Message;
            }
        }
    }
}