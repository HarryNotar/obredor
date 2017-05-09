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

namespace Web.WebForms_Comisión
{
    public partial class RegistrarComision : System.Web.UI.Page
    {
        private LogicaComision logicaComision = new LogicaComision();


        protected void Page_Load(object sender, EventArgs e)
        {
            
            //No permite tocar el menu mientras se registra
            Menu menuPrincipal = (Menu)Page.Master.FindControl("MenuPrincipal");
            foreach (MenuItem m in menuPrincipal.Items)
            {
                m.Enabled = false;
            }


        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Home.aspx");
        }

       
        
        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            Comision comisionNueva = new Comision();
            comisionNueva.Porcentaje = this.TxtBoxPorcentaje.Text;
            

            if (this.TxtBoxPorcentaje.Text.Trim() != "")
            {
                try
                {
                    logicaComision.RegistrarComision(comisionNueva);
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