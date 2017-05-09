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
    public partial class EliminarVersion : System.Web.UI.Page
    {
        private LogicaModelo logicaModelo = new LogicaModelo();
        private LogicaMarca logicaMarca = new LogicaMarca();
        private LogicaVersion logicaVersion = new LogicaVersion();
        List<Marca> listaMarcas;
        List<Modelo> listaModelos;
        List<Negocio.Entidades.Version> listaVersiones; 



        protected void Page_Load(object sender, EventArgs e)
        {
            
            listaMarcas = logicaMarca.GetTodasMarcas();
            this.cargarDropDownListMarcas();
                                
            
        }


        protected void DrDoListMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            Marca marca = new Marca();

            //busco el objeto marca q coincida con el idMarca seleccionado en el drop down list de marcas
            marca = listaMarcas.Find(m=> m.IdMarca == Convert.ToInt32(DrDoListMarca.SelectedValue));
            
           
            this.cargarDropDownListModelos(marca);

           
        }


        protected void DrDoListModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Modelo modelo = new Modelo();
            //busco el objeto modelo q coincida con el idModelo seleccionado en el drop down list de modelos
            modelo = listaModelos.Find(m => m.IdModelo == Convert.ToInt32(DrDoListModelo.SelectedValue));
                                   
            this.cargarDropDownListVersiones(modelo);
        }


        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/");
        }



        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (this.DrDoListVersion.SelectedItem != null)
            {

                try
                {
                    Negocio.Entidades.Version version = new Negocio.Entidades.Version();
                    version.IdVersion = Convert.ToInt32(DrDoListVersion.SelectedValue);
                    logicaVersion.EliminarVersion(version);
                    Page.Response.Write("La operación ha sido realizada satisfactoriamente");
                    Modelo modelo = new Modelo();
                    modelo.IdModelo = Convert.ToInt32(DrDoListModelo.SelectedValue);
                    this.cargarDropDownListVersiones(modelo);

                }
                catch (Exception ex)
                {
                    Page.Response.Write("Error inesperado");
                }
            }
            else
            {
                Page.Response.Write("Debe seleccionar una version para continuar.");

            }


        }






        private void cargarDropDownListMarcas()
        {

            try
            {
                //List<Marca> listaMarcas = logicaMarca.GetTodasMarcas();
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
                listaModelos = m.ListaModelos;
                if (m.ListaModelos.Count > 0)
                {
                    this.DrDoListModelo.DataSource = m.ListaModelos;
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


        private void cargarDropDownListVersiones(Modelo m)
        {
            try
            {
                listaVersiones = m.ListaVersiones;                
                if (listaVersiones.Count > 0)
                {
                    this.DrDoListVersion.DataSource = listaVersiones;
                    this.DrDoListVersion.DataTextField = "Nombre";
                    this.DrDoListVersion.DataValueField = "IdVersion";
                    this.DrDoListVersion.DataBind();
                }
                else
                {
                    Page.Response.Write("No hay Versiones cargadas");
                }
            }
            catch (Exception ex)
            {
                Page.Response.Write("Error inesperado");
            }

        }

       

       

    }
}