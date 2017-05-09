using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void MenuPrincipal_MenuItemClick(object sender, MenuEventArgs e)
        {
          //ESTA BIEN PONER ACA A QUE WEBFORM REDIRIGE CADA OPCION DEL MENU Y GUARDAR 
          //COMO VARIABLE DE SESION EL ITEM DE MENU QUE SELECCIONO PARA DESPUES USARLO EN AMB PERSONA PARA VER QUE MUESTRA EL WEBFORM????

            Menu menuPrincipal = (Menu)Page.Master.FindControl("MenuPrincipal");
            string itemSelecc = e.Item.Text;

            //GUARDO VARIABLE DE SESION PARA EL ITEM SELECCIONADO
            Session["itemSeleccionado"] = itemSelecc;

           
            //REDIRIJO AL WEBFORM Q CORRESPONDE SEGUN OPCIO DEL MENU QUE SELECCIONO
            switch(itemSelecc)
            {
                //EN ITEM MI PERFIL
                case "Consultar mi perfil":                                             
                                            Page.Response.Redirect("~/WebForms_Persona/ABM_Persona.aspx");
                                            break;

                case "Modificar mi perfil":
                                            Page.Response.Redirect("~/WebForms_Persona/ABM_Persona.aspx");
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


                //EN ITEM VEHICULO
                case "Vender Vehículo":
                                            Page.Response.Redirect("~/WebForms_Vehiculo/SeleccionarVehiculo.aspx");
                                            break;


                case "Registrar Vehículo":
                                            Page.Response.Redirect("~/WebForms_Vehiculo/RegistrarVehiculo.aspx");
                                            break;


                case "Consultar ficha de un Vehículo":
                                            Page.Response.Redirect("~/WebForms_Vehiculo/SeleccionarVehiculo.aspx");
                                            break;


                case "Modificar ficha de un Vehículo":
                                            Page.Response.Redirect("~/WebForms_Vehiculo/SeleccionarVehiculo.aspx");
                                            break;


                case "Eliminar Vehículo":
                                            Page.Response.Redirect("~/WebForms_Vehiculo/SeleccionarVehiculo.aspx");
                                            break;
                                                       

                //EN SUBITEM MARCA
                case "Eliminar Marca":
                                            Page.Response.Redirect("~/WebForms_Vehiculo/AB_Marca/EliminarMarca.aspx");
                                            break;


                //EN SUBITEM MODELO
                case "Eliminar Modelo":
                                            Page.Response.Redirect("~/WebForms_Vehiculo/AB_Modelo/EliminarModelo.aspx");
                                            break;


                //EN SUBITEM VERSION
                case "Eliminar Versión":
                                            Page.Response.Redirect("~/WebForms_Vehiculo/AB_Version/EliminarVersion.aspx");
                                            break;


                //EN SUBITEM COLOR
                case "Eliminar Color":
                                            Page.Response.Redirect("~/WebForms_Vehiculo/AB_Color/EliminarColor.aspx");
                                            break;

                //EN ITEM COMISION
                case "Registrar Comisión":
                                            Page.Response.Redirect("~/WebForms_Comisión/RegistrarComision.aspx");
                                            break;


                case "Consultar Comisión actual":
                                            Page.Response.Redirect("~/WebForms_Comisión/ConsultarComision.aspx");
                                            break;

               

            }

            


        }



       
                
               
       

    }

}



