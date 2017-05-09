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

namespace Web
{
    public partial class Home : Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {            
            Persona.eRol rol = (Persona.eRol)(Session["rol"]);
            Persona.ePerfil perfil = (Persona.ePerfil)(Session["perfil"]);
            Menu menuPrincipal = (Menu)Page.Master.FindControl("MenuPrincipal");
            MenuItem itemSeleccionado = (MenuItem)(Session["itemSeleccionado"]);

            switch (rol)
            {
                case Persona.eRol.Cliente:
                    SetearOpcionesConsultor(menuPrincipal);
                    break;

                case Persona.eRol.Empleado:
                    if (perfil.Equals(Persona.ePerfil.General))
                    {
                        SetearOpcionesGeneral(menuPrincipal);
                    }
                    else
                    {
                        if (perfil.Equals(Persona.ePerfil.Consultor))
                        {
                            SetearOpcionesConsultor(menuPrincipal);
                        }
                    }

                    break;
            }
        }


        #region Setear Opciones de roles General y Consultor

        private void SetearOpcionesGeneral(Menu menuPrincipal)
        {
            // Remover los items que no son accesibles por el usuario
            menuPrincipal.Items.Remove(menuPrincipal.FindItem("Empleado"));
            menuPrincipal.Items.Remove(menuPrincipal.FindItem("Comision"));
        }


        private void SetearOpcionesConsultor(Menu menuPrincipal)
        {
            SetearOpcionesGeneral(menuPrincipal);

            menuPrincipal.Items.Remove(menuPrincipal.FindItem("Cliente"));

            // Buscar el item Vehiculo
            MenuItem menuVehiculo = menuPrincipal.FindItem("Vehiculo");

            // Buscar cada subitem del item Vehiculo
            MenuItem venderVehiculo = menuPrincipal.FindItem("Vehiculo/VenderVehiculo");
            MenuItem registrarVehiculo = menuPrincipal.FindItem("Vehiculo/RegistrarVehiculo");
            MenuItem modificarVehiculo = menuPrincipal.FindItem("Vehiculo/ModificarVehiculo");
            MenuItem caracteristicasVehiculo = menuPrincipal.FindItem("Vehiculo/CaracteristicasVehiculo");
            MenuItem eliminarVehiculo = menuPrincipal.FindItem("Vehiculo/EliminarVehiculo");

            // Eliminar cada subitem del item Vehiculo
            menuVehiculo.ChildItems.Remove(venderVehiculo);
            menuVehiculo.ChildItems.Remove(registrarVehiculo);
            menuVehiculo.ChildItems.Remove(modificarVehiculo);
            menuVehiculo.ChildItems.Remove(caracteristicasVehiculo);
            menuVehiculo.ChildItems.Remove(eliminarVehiculo);
        }

        #endregion


        //cierro sesion
        protected void Logout(object sender, EventArgs e)
        {
            Menu menuPrincipal = (Menu)Page.Master.FindControl("MenuPrincipal");

            foreach (MenuItem m in menuPrincipal.Items)
            {
                if (m.Value.Equals("Salir")) 
                {
                    if (m.Selected) 
                    {   
                        //si selecciona salir, borra los datos de sesion y vuelve a la pag de login 
                        Session.Clear();
                        Page.Response.Redirect("~/WebForms_Login/Login.aspx");
                    }
                }
                
            } 
        } 
     }
}
       
  
