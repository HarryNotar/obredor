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

namespace Web.WebForms_Vehiculo.AB_Modelo
{
    public partial class RegistrarModelo : System.Web.UI.Page
    {
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

            logicaModelo = new LogicaModelo();
            this.cargarDropDownListMarcas();
        }


        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Home.aspx");
        }


        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            Modelo modeloNuevo = new Modelo();

            modeloNuevo.Nombre = this.TxtBoxNombre.Text;
           // modeloNuevo.Marca = (Marca)this.DrDoListMarca.SelectedItem; //VER XQ NO SE PUEDE SI EL DROPDOWNLIST TIENE COMO DATA SOURCE UNA LISTA DE MARCAS


            if (this.TxtBoxNombre.Text.Trim() != "")
            {
                try
                {
                    logicaModelo.RegistrarModelo(modeloNuevo);
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


       /* protected void BtnGuardar_Click(object sender, EventArgs e)
        {

            Modelo modeloNuevo = new Modelo();

            modeloNuevo.Nombre = this.TxtBoxNombre.Text;
            modeloNuevo.Marca = (Marca)this.DrDoListMarca.SelectedItem; //VER XQ NO SE PUEDE SI EL DROPDOWNLIST TIENE COMO DATA SOURCE UNA LISTA DE MARCAS


            if (this.TxtBoxNombre.Text.Trim() != "")
            {
                try
                {
                    logicaModelo.RegistrarModelo(modeloNuevo);
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
        */



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

        


    }
}