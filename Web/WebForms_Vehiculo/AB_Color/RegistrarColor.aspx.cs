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

namespace Web.WebForms_Vehiculo.AB_Color
{
    public partial class RegistrarColor : System.Web.UI.Page
    {
        private LogicaColor logicaColor;
        public Color ColorNuevo { get; set; }


        protected void Page_Load(object sender, EventArgs e)
        {
            //No permite tocar el menu mientras se registra
            Menu menuPrincipal = (Menu)Page.Master.FindControl("MenuPrincipal");
            foreach (MenuItem m in menuPrincipal.Items)
            {
                m.Enabled = false;
            }

            logicaColor = new LogicaColor();
            ColorNuevo = new Color();
        }



        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Home.aspx");
        }



        protected void BtnEliminar_Click(object sender, EventArgs e)
        {

            ColorNuevo.Nombre = this.TxtBoxRegistrarColor.Text;

            if (this.TxtBoxRegistrarColor.Text.Trim() != "")
            {
                try
                {
                    logicaColor.RegistrarColor(ColorNuevo);
                    Page.Response.Write("La operación ha sido realizada satisfactoriamente");
                    
                }
                catch (Exception ex)
                {
                    Page.Response.Write("Error inesperado");
                }
            }
            else
            {
                Page.Response.Write("El campo Nombre es obligatorio.");
            }

        }
    }
}