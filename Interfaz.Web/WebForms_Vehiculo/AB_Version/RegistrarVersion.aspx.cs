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

namespace Web.WebForms_Vehiculo.AB_Version
{
    public partial class RegistrarVersion : System.Web.UI.Page
    {

        private LogicaVersion logicaVersion = new LogicaVersion();
        private LogicaModelo logicaModelo = new LogicaModelo();
        private LogicaMarca logicaMarca = new LogicaMarca();

              

        protected void Page_Load(object sender, EventArgs e)
        {   

            //No permite tocar el menu mientras se registra
            Menu menuPrincipal = (Menu)Page.Master.FindControl("MenuPrincipal");
            foreach (MenuItem m in menuPrincipal.Items)
            {
                m.Enabled = false;
            }
                     
           
            this.cargarDropDownListMarcas();
            Marca marca = new Marca();
            marca.IdMarca = Convert.ToInt32(DrDoListMarca.SelectedValue);
            this.cargarDropDownListModelos(marca);
           
                        
        }

       
        
        
        
        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Home.aspx");
        }

        
        
        
        
        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            
            Negocio.Entidades.Version versionNueva = new Negocio.Entidades.Version();

            versionNueva.Nombre = this.TxtBoxVersion.Text;            
            if (this.TxtBoxVersion.Text.Trim() != "")
            {
                try
                {
                    logicaVersion.RegistrarVersion(versionNueva);
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




        private void cargarDropDownListMarcas()
        {

            try
            {
                List<Marca> listaMarcas = logicaMarca.GetTodasMarcas();
                if (listaMarcas.Count > 0)
                {
                    this.DrDoListMarca.DataSource = listaMarcas;
                    this.DrDoListMarca.DataTextField = "Nombre";
                    this.DrDoListMarca.DataValueField = "IdMarca";
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


        private void cargarDropDownListModelos(Marca m)
        {
            try
            {
                List<Modelo> listaModelos = logicaModelo.GetTodosModelos(m);
                if (listaModelos.Count > 0)
                {
                    this.DrDoListModelo.DataSource = listaModelos;
                    this.DrDoListModelo.DataTextField = "Nombre";
                    this.DrDoListModelo.DataValueField = "IdModelo";
                    this.DrDoListModelo.DataBind();
                }
                else
                {
                    Page.Response.Write("No hay modelos cargadas");
                }
            }
            catch (Exception ex)
            {
                Page.Response.Write("Error inesperado");
            }

        }




       
    }
}