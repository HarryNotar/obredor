using Interfaz.Escritorio.Mensajes;
using Negocio.Entidades;
using Negocio.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades;

namespace Interfaz.Escritorio.Forms_Persona
{
    public partial class FormBasePersona : Form
    {
        #region Propiedades y Atributos

        public Persona.eRol Rol { get; set; }
        public Persona PersonaActual { get; set; }

        protected LogicaPersona logicaPersona;

        #endregion


        #region Constructores y Cargadores

        public FormBasePersona()
        {
            InitializeComponent();
        }


        public FormBasePersona(Persona.eRol rol):this()
        {
            logicaPersona = new LogicaPersona();
            PersonaActual = new Persona();

            Rol = rol;

            if (Rol == Persona.eRol.Cliente)
            {
                SetearFormCliente();
            }
            else
            {
                SetearFormEmpleado();
            }
        }
        
        #endregion


        protected void ConsultarPersona()
        {
            try
            {
                PersonaActual = logicaPersona.BuscarPersona(mtxt_dni.Text, Rol);

                if (PersonaActual != null)
                {
                    MapearDeDatos();
                }
                else
                {
                    VaciarControles();

                    if (Rol == Persona.eRol.Cliente)
                    {
                        Notificador.NotificarAdvertencia(Notificador.TipoDato.ClientNoRegistrado);
                    }
                    else
                    {
                        Notificador.NotificarAdvertencia(Notificador.TipoDato.EmpleadoNoRegistrado);
                    }
                }
            }
            catch (Exception ex)
            {
                Notificador.NotificarErrorInesperado(ex);
            }
        }


        #region Funciones internas: MapearADatos, MepearDeDatos y ValidarCampos

        /// <summary>
        /// Copia la información de los controles del formulario a un objeto Persona.
        /// </summary>
        /// <returns></returns>
        protected virtual void MapearADatos()
        {
            // Atributos comunes a Cliente y Empleado
            PersonaActual.Apellido = FormateadorTexto.FormatearTexto(txt_apellido.Text);
            PersonaActual.Nombre = FormateadorTexto.FormatearTexto(txt_nombre.Text);
            PersonaActual.Telefono1 = mtxt_telefono1.Text;
            if (!mtxt_telefono2.MaskFull)
            {
                PersonaActual.Telefono2 = "-";
            }
            else
            {
                PersonaActual.Telefono2 = mtxt_telefono2.Text;
            }

            if (!mtxt_telefono3.MaskFull)
            {
                PersonaActual.Telefono3 = "-";
            }
            else
            {
                PersonaActual.Telefono3 = mtxt_telefono3.Text;
            }
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
            if (Rol == Persona.eRol.Cliente)
            {
                PersonaActual.Localidad = FormateadorTexto.FormatearTexto(txt_localidad.Text);
                PersonaActual.Direccion = FormateadorTexto.FormatearTexto(txt_direccion.Text);

                PersonaActual.Perfil = Persona.ePerfil.Consultor;
                PersonaActual.Rol = Persona.eRol.Cliente;
            }
            // Si se esta registrando un Empleado
            else
            {
                PersonaActual.Localidad = "-";
                PersonaActual.Direccion = "-";

                String perfil = cmb_perfil.SelectedItem.ToString();
                Persona.ePerfil eperfil = new Persona.ePerfil();
                switch (perfil)
                {
                    case "Administrador":
                        eperfil = Persona.ePerfil.Administrador;
                        break;
                    case "General":
                        eperfil = Persona.ePerfil.General;
                        break;
                    case "Consultor":
                        eperfil = Persona.ePerfil.Consultor;
                        break;
                }
                PersonaActual.Perfil = eperfil;
                PersonaActual.Rol = Persona.eRol.Empleado;
            }
        }


        /// <summary>
        /// Copia la información de un objeto Persona a los controles del formulario.
        /// </summary>
        protected void MapearDeDatos()
        {
            mtxt_dni.Text = PersonaActual.NroDoc;
            txt_apellido.Text = PersonaActual.Apellido;
            txt_nombre.Text = PersonaActual.Nombre;
            mtxt_telefono1.Text = PersonaActual.Telefono1;
            if (PersonaActual.Telefono2 != "-")
            {
                mtxt_telefono2.Text = PersonaActual.Telefono2;
            }
            if (PersonaActual.Telefono3 != "-")
            {
                mtxt_telefono3.Text = PersonaActual.Telefono3;
            }
            txt_email.Text = PersonaActual.Email;
            cmb_perfil.SelectedItem = PersonaActual.Perfil.ToString();
            txt_observaciones.Text = PersonaActual.Observaciones;

            if (Rol == Persona.eRol.Cliente)
            {
                txt_localidad.Text = PersonaActual.Localidad;
                txt_direccion.Text = PersonaActual.Direccion;
            }
        }


        /// <summary>
        /// Valida si se han ingresado todos los campos obligatorios.
        /// </summary>
        /// <returns></returns>
        protected bool ValidarCampos()
        {
            bool camposValidos = false;

            if (!mtxt_dni.MaskFull)
            {
                Notificador.NotificarAdvertencia(Notificador.TipoDato.NroDoc);
            }
            else
            {
                if (txt_apellido.Text == String.Empty)
                {
                    Notificador.NotificarAdvertencia(Notificador.TipoDato.Apellido);
                }
                else
                {
                    if (txt_nombre.Text == String.Empty)
                    {
                        Notificador.NotificarAdvertencia(Notificador.TipoDato.Nombre);
                    }
                    else
                    {
                        if (!mtxt_telefono1.MaskFull)
                        {
                            Notificador.NotificarAdvertencia(Notificador.TipoDato.Telefono1);
                        }
                        else
                        {
                            if (mtxt_telefono2.Text.Trim() != "-" && !mtxt_telefono2.MaskFull)
                            {
                                Notificador.NotificarAdvertencia(Notificador.TipoDato.Telefono23);
                            }
                            else
                            {
                                if (mtxt_telefono3.Text.Trim() != "-" && !mtxt_telefono3.MaskFull)
                                {
                                    Notificador.NotificarAdvertencia(Notificador.TipoDato.Telefono23);
                                }
                                else
                                {
                                    if (txt_email.Text == String.Empty)
                                    {
                                        Notificador.NotificarAdvertencia(Notificador.TipoDato.Email);
                                    }
                                    else
                                    {
                                        if (Rol == Persona.eRol.Cliente)
                                        {
                                            if (txt_localidad.Text == String.Empty)
                                            {
                                                Notificador.NotificarAdvertencia(Notificador.TipoDato.Localidad);
                                            }
                                            else
                                            {
                                                if (txt_direccion.Text == String.Empty)
                                                {
                                                    Notificador.NotificarAdvertencia(Notificador.TipoDato.Direccion);
                                                }
                                                else
                                                {
                                                    camposValidos = true;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            camposValidos = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return camposValidos;
        }

        #endregion


        #region Comportamiento de botones

        protected virtual void btn_aceptar_Click(object sender, EventArgs e)
        {

        }


        protected virtual void btn_buscar_Click(object sender, EventArgs e)
        {
            
        }


        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        #endregion


        #region Comportamiento de controles
        

        private void SetearFormCliente()
        {
            // Ocultar el comboBox para seleccionar el perfil.
            // Los clientes siempre son "Consultor" y no se puede cambiar.
            lbl_perfil.Visible = false;
            cmb_perfil.Visible = false;
        }


        private void SetearFormEmpleado()
        {
            // Oculta localidad y dirección que no son requeridos para 
            // registrar un Empleado
            lbl_localidad.Visible = false;
            txt_localidad.Visible = false;

            lbl_direccion.Visible = false;
            txt_direccion.Visible = false;
        }


        protected void VaciarControles()
        {
            txt_apellido.Text = "";
            txt_nombre.Text = "";
            txt_localidad.Text = "";
            txt_direccion.Text = "";
            mtxt_telefono1.Text = "";
            mtxt_telefono2.Text = "";
            mtxt_telefono3.Text = "";
            txt_email.Text = "";
            txt_observaciones.Text = "";

        }


        protected void DeshabilitarEscrituraControles()
        {
            cmb_perfil.Enabled = false;
            txt_apellido.Enabled = false;
            txt_nombre.Enabled = false;
            txt_localidad.Enabled = false;
            txt_direccion.Enabled = false;
            mtxt_telefono1.Enabled = false;
            mtxt_telefono2.Enabled = false;
            mtxt_telefono3.Enabled = false;
            txt_email.Enabled = false;
            txt_observaciones.Enabled = false;
        }

        #endregion

        
    }
}
