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

namespace Web.WebForms_Persona  //INCOMPLETO
{
    public partial class ABM_Persona : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //No permite tocar el menu mientras se registra
            Menu menuPrincipal = (Menu)Page.Master.FindControl("MenuPrincipal");
            foreach (MenuItem m in menuPrincipal.Items)
            {
                m.Enabled = false;
            }
            
            //CAMBIA TITULO Y BOTON DEL WEBFORM SEGUN SI SELECCIONA MI PERFIL, 
            //EMPLEADO O CLIENTE Y SEGUN SI REGISTRA, MODIFICA O CONSULTA  
                        
            string itemSelecc = (string)(Session["itemSeleccionado"]); //recupero variable de sesion con el item del menu seleccionado


            switch (itemSelecc)
            {
                //EN ITEM MI PERFIL
                case "Consultar mi perfil":
                    this.LblNombrePagina.Text = "Mi perfil";                    
                    break;

                case "Modificar mi perfil":
                    this.LblNombrePagina.Text = "Modificar mi perfil";
                                        
                    break;


                case "Salir": //VER SI PONER LOGOUT ACA
                    break;

                //EN ITEM EMPLEADO
                case "Registrar nuevo Empleado":
                    Page.Response.Redirect("~/WebForms_Persona/ABM_Persona.aspx");
                    break;

                case "Consultar perfil de un Empleado":
                    Page.Response.Redirect("~/WebForms_Persona/ABM_Persona.aspx");
                    break;

                case "Modificar perfil de un Empleado":
                    Page.Response.Redirect("~/WebForms_Persona/ABM_Persona.aspx");
                    break;

                //EN ITEM CLIENTE
                case "Registrar nuevo Cliente":
                    Page.Response.Redirect("~/WebForms_Persona/ABM_Persona.aspx");
                    break;

                case "Consultar perfil de un Cliente":
                    Page.Response.Redirect("~/WebForms_Persona/ABM_Persona.aspx");
                    break;


                case "Modificar perfil de un Cliente":
                    Page.Response.Redirect("~/WebForms_Persona/ABM_Persona.aspx");
                    break;


            }
                
                            
                             
                
                                
                           
                                
                                
                
            
        }

        protected void BtnCancelar_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Home.aspx");
           
        }

        protected void BtnAceptar_Click(object sender, EventArgs e)
        {
            //segun que texto tiene el boton registra, consulta o modifica
        }

       

       

    }
}