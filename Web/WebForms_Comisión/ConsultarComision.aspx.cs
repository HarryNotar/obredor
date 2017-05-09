using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Configuration;
using Negocio.Entidades;
using Negocio.Logica;
using Datos;
using System.Web.SessionState;
using System.Web.UI.WebControls;

namespace Web.WebForms_Comisión
{
    public partial class ConsultarComision : System.Web.UI.Page
    {        
        private LogicaComision logicaComision = new LogicaComision();

        protected void Page_Load(object sender, EventArgs e)
        {
            //No permite tocar el menu mientras se consulta
            Menu menuPrincipal = (Menu)Page.Master.FindControl("MenuPrincipal");
            foreach (MenuItem m in menuPrincipal.Items)
            {
                m.Enabled = false;
            }
            
            
            Comision comisionActual = new Comision();
            comisionActual = logicaComision.GetComisionActual();
            this.TxtBoxPorcentaje.Text = comisionActual.Porcentaje.ToString("00.00"); //string.Format("{0:f2}", comisionActual.Porcentaje);
            this.TxtBoxFechaDesde.Text = comisionActual.Fecha.ToString("dd/MM/yyyy");          
        }



        protected void BtnSalir_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Home.aspx");
        }

       
        
    }
}