using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Interfaz.Web
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            switch (Session["perfil"].ToString())
            {
                case "Administrador":
                    break;
                case "General":
                    SetearOpcionesGeneral();
                    break;
                case "Consultor":
                    SetearOpcionesConsultor();
                    break;
            }
        }

        private void SetearOpcionesGeneral()
        {
            a_empleados.Visible = false;
            a_comisiones.Visible = false;
        }


        private void SetearOpcionesConsultor()
        {
            SetearOpcionesGeneral();

            a_clientes.Visible = false;
            
            a_vender.Visible = false;
            a_registrar.Visible = false;
            a_modificar.Visible = false;
            a_eliminar.Visible = false;

            a_marcas.Visible = false;
            a_modelos.Visible = false;
            a_versiones.Visible = false;
            a_colores.Visible = false;
        }

        protected void btn_logout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();

            Response.Redirect("/Login/Login");
        }
    }
}