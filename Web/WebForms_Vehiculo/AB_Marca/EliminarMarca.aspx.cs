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

namespace Web.WebForms_Vehiculo.AB_Marca
{
    public partial class EliminarMarca : System.Web.UI.Page
    {
        private LogicaMarca logicaMarca = new LogicaMarca();

        protected void Page_Load(object sender, EventArgs e)
        {
            //No permite tocar el menu mientras se elimina
            Menu menuPrincipal = (Menu)Page.Master.FindControl("MenuPrincipal");
            foreach (MenuItem m in menuPrincipal.Items)
            {
                m.Enabled = false;
            }
            
            this.cargarDropDownListMarcas();

        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {

            if (this.DrDoListMarca.SelectedItem != null)
            {

                try
                {
                    Marca m = new Marca();
                    m.IdMarca = Convert.ToInt32(DrDoListMarca.SelectedValue);
                    logicaMarca.EliminarMarca(m);                                        
                    Page.Response.Write("La operación ha sido realizada satisfactoriamente");
                    this.cargarDropDownListMarcas();

                }
                catch (Exception ex)
                {
                    Page.Response.Write("Error inesperado");
                }
            }
            else
            {
                Page.Response.Write("Debe seleccionar una marca para continuar.");

            }

        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Home.aspx");
        }


        private void cargarDropDownListMarcas()
        {

            try
            {
                List<Marca> listaMarcas = logicaMarca.GetTodasMarcas();
                if (listaMarcas.Count > 0)
                {
                    this.DrDoListMarca.DataSource = listaMarcas;
                    this.DrDoListMarca.DataTextField = "Nombre"; //IdColor
                    this.DrDoListMarca.DataValueField = "IdMarca"; //Nombre
                    this.DrDoListMarca.DataBind();
                }
                else
                {
                    Page.Response.Write("No hay marcas cargadas");
                }
            }
            catch (Exception ex)
            {
                Page.Response.Write("Error inesperado");
            }



        }


    }
}