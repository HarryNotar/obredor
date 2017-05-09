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

namespace Web.WebForms_Vehiculo
{
    public partial class RegistrarVehiculo : System.Web.UI.Page
    {
        private LogicaModelo logicaModelo = new LogicaModelo();
        private LogicaMarca logicaMarca = new LogicaMarca();
        private LogicaVersion logicaVersion = new LogicaVersion();
        private LogicaVehiculo logicaVehiculo = new LogicaVehiculo();
        private LogicaColor logicaColor = new LogicaColor();
        
        public Vehiculo vehiculoNuevo { get; set; }

        //INCOMPLETO

        protected void Page_Load(object sender, EventArgs e)
        {
            //No permite tocar el menu mientras se hace el registro
            Menu menuPrincipal = (Menu)Page.Master.FindControl("MenuPrincipal");
            foreach (MenuItem m in menuPrincipal.Items)
            {
                m.Enabled = false;
            }

            

            this.cargarDropDownListMarcas();

            Marca marca = new Marca();
            marca.IdMarca = Convert.ToInt32(DrDoListMarca.SelectedValue);
            this.cargarDropDownListModelos(marca);

            Modelo modelo = new Modelo();
            modelo.IdModelo = Convert.ToInt32(DrDoListModelo.SelectedValue);
            this.cargarDropDownListVersiones(modelo);

            this.cargarDropDownListColores();

        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Home.aspx");
        }



   //INCOMPLETO
        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {
            vehiculoNuevo = new Vehiculo();
            Marca marca = new Marca();
            marca.IdMarca = Convert.ToInt32(DrDoListMarca.SelectedValue);
            
            Modelo modelo = new Modelo();
            modelo.IdModelo = Convert.ToInt32(DrDoListModelo.SelectedValue);

            Negocio.Entidades.Version version = new Negocio.Entidades.Version();
            version.Modelo = modelo;
            version.Modelo.Marca = marca;
            vehiculoNuevo.Version = version;

            Color color = new Color();
            color.IdColor = Convert.ToInt32(DrDoListColor.SelectedValue);
            vehiculoNuevo.Color = color; //HASTA ACA ASIGNE AL VEHICULO NUEVO COLOR Y VERSION, CON MODELO Y MARCA


         /*   if (this.TxtBoxRegistrarColor.Text.Trim() != "")
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
            } */



        }




        protected void BtnAgregarMarca_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/WebForms_Vehiculo/AB_Marca/RegistrarMarca.aspx");
            //VER COMO VOLVER DEL REGISTRO DE LA MARCA AL REGISTRO DEL VEHICULO EN CURSO

        }

        protected void BtnAgregarModelo_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/WebForms_Vehiculo/AB_Modelo/RegistrarModelo.aspx");
        }

        protected void BtnAgregarVersion_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/WebForms_Vehiculo/AB_Version/RegistrarVersion.aspx");
        }

        protected void BtnAgregarColor_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/WebForms_Vehiculo/AB_Color/RegistrarColor.aspx");
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


        private void cargarDropDownListVersiones(Modelo m)
        {
            try
            {
                DatosVersion datosVersion = new DatosVersion(); //ERROR SIN SENTIDO ??
                List<Negocio.Entidades.Version> listaVersiones = datosVersion.GetTodasVersiones(m);
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