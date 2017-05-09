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
    public partial class EliminarColor : System.Web.UI.Page
    {        
        private LogicaColor logicaColor = new LogicaColor();

        protected void Page_Load(object sender, EventArgs e)
        {
            //No permite tocar el menu mientras se elimina
            Menu menuPrincipal = (Menu)Page.Master.FindControl("MenuPrincipal");
            foreach (MenuItem m in menuPrincipal.Items)
            {
                m.Enabled = false;
            }
            
            this.cargarDropDownListColores();
                        
        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Home.aspx");
        }



        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (this.DrDoListColor.SelectedItem != null)
            {          

                try
                {
                    Color c = new Color();
                    c.IdColor = Convert.ToInt32(DrDoListColor.SelectedValue);
                    logicaColor.EliminarColor(c);

                    //logicaColor.EliminarColor((Color)this.DrDoListColor.SelectedItem);  //VER XQ NO SE PUEDE SI EL DROPDOWNLIST TIENE COMO DATA SOURCE UNA LISTA DE COLORES
                    Page.Response.Write("La operación ha sido realizada satisfactoriamente");
                    this.cargarDropDownListColores();
                                        
                }
                catch (Exception ex)
                {
                    Page.Response.Write("Error inesperado");
                }
            }
            else
            {
                Page.Response.Write("Debe seleccionar un color para continuar.");
                
            }
        

        }


        private void cargarDropDownListColores() 
        {
            
            try
            {
                List<Color> listaColores = logicaColor.GetTodosColores();
                if (listaColores.Count > 0)
                {
                    this.DrDoListColor.DataSource = listaColores;
                    this.DrDoListColor.DataTextField = "Nombre"; //IdColor
                    this.DrDoListColor.DataValueField = "IdColor"; //Nombre
                    this.DrDoListColor.DataBind();
                }
                else
                {
                    Page.Response.Write("No hay colores cargados");
                }
            }
            catch (Exception ex)
            {
                Page.Response.Write("Error inesperado");
            }
            
            
                       
        }
    }
}