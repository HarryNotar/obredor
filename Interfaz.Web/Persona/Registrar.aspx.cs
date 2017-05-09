using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio.Entidades;
using Negocio.Logica;
using Utilidades;

namespace Interfaz.Web.Persona
{
    public partial class Registrar : System.Web.UI.Page
    {
        private Negocio.Entidades.Persona.eRol rol;
        private LogicaPersona logicaPersona;
        private Negocio.Entidades.Persona personaActual;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nroDoc"] == null)
            {
                Response.Redirect("/Login/Login");
            }
            else
            {
                if (Session["perfil"].ToString() == "Administrador")
                {
                    div_exito.Visible = false;
                    div_error.Visible = false;

                    switch (Request.QueryString["rol"])
                    {
                        case "cliente":
                            rol = Negocio.Entidades.Persona.eRol.Cliente;
                            titulo.Text = "<h2> Registrar Cliente </h2>";
                            // Ocultar el comboBox para seleccionar el perfil.
                            // Los clientes siempre son "Consultor" y no se puede cambiar.
                            div_perfil.Visible = false;
                            break;
                        case "empleado":
                            rol = Negocio.Entidades.Persona.eRol.Empleado;
                            titulo.Text = "<h2> Registrar Empleado </h2>";
                            // Oculta localidad y dirección que no son requeridos para registrar un Empleado
                            div_localidad.Visible = false;
                            div_direccion.Visible = false;
                            break;
                    }
                }
                else
                {
                    Response.Redirect("/");
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            personaActual = new Negocio.Entidades.Persona();

            this.MapearADatos(personaActual);

            personaActual.Contraseña = GeneradorContraseñas.GenerarContraseña();

            try
            {
                logicaPersona = new LogicaPersona();
                logicaPersona.RegistrarPersona(personaActual);

                div_exito.Visible = true;
                div_error.Visible = false;
                lbl_mensaje_exito.Text = "La operación ha sido realizada satisfactoriamente";
                // AGREGAR CODIGO PARA ENVIAR UN EMAIL CON LA CONTRASEÑA AL EMPLEADO
            }
            catch (Exception ex)
            {
                div_error.Visible = true;
                div_exito.Visible = false;
                lbl_mensaje_error.Text = ex.Message;
            }
        }


        protected virtual void MapearADatos(Negocio.Entidades.Persona PersonaActual)
        {
            // Atributos comunes a Cliente y Empleado
            PersonaActual.NroDoc = txt_nroDoc.Text;
            PersonaActual.Apellido = txt_apellido.Text;
            PersonaActual.Nombre = txt_nombre.Text;
            PersonaActual.Telefono1 = txt_telefono.Text;
            PersonaActual.Telefono2 = "-";
            PersonaActual.Telefono3 = "-";
            PersonaActual.Email = txt_email.Text;

            if (txt_observaciones.Text.Trim() != "")
            {
                PersonaActual.Observaciones = txt_observaciones.Text;
            }
            else
            {
                PersonaActual.Observaciones = "-";
            }

            // Si se esta registrando un Cliente
            if (rol == Negocio.Entidades.Persona.eRol.Cliente)
            {
                PersonaActual.Localidad = txt_localidad.Text;
                PersonaActual.Direccion = txt_direccion.Text;

                PersonaActual.Perfil = Negocio.Entidades.Persona.ePerfil.Consultor;
                PersonaActual.Rol = Negocio.Entidades.Persona.eRol.Cliente;
            }
            // Si se esta registrando un Empleado
            else
            {
                PersonaActual.Localidad = "-";
                PersonaActual.Direccion = "-";

                String perfil = cmb_perfil.SelectedItem.ToString();
                Negocio.Entidades.Persona.ePerfil eperfil = new Negocio.Entidades.Persona.ePerfil();
                switch (perfil)
                {
                    case "Administrador":
                        eperfil = Negocio.Entidades.Persona.ePerfil.Administrador;
                        break;
                    case "General":
                        eperfil = Negocio.Entidades.Persona.ePerfil.General;
                        break;
                    case "Consultor":
                        eperfil = Negocio.Entidades.Persona.ePerfil.Consultor;
                        break;
                }
                PersonaActual.Perfil = eperfil;
                PersonaActual.Rol = Negocio.Entidades.Persona.eRol.Empleado;
            }
        }

    }
}