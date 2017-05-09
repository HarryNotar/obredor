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

namespace Web.WebForms_MedioAbono
{
    public partial class DatosPago : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAtras_Click(object sender, EventArgs e)
        {
            /*MEDIANTE LA VARIABLE DE SESION QUE GUARDA LA VENTA ACTUAL 
            VOLVER A LA PAGINA CON LOS DATOS DE LA VENTA DEL VEHICULO CARGADOS*/
        }

        protected void BtnRealizarVenta_Click(object sender, EventArgs e)
        {
            //TRAER EL MONTO TOTAL MEDIANTE LA VARIABLE DE SESION QUE GUARDA LA VENTA ACTUAL 
          
        }

    }
}