using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Utilidades;
using Negocio.Entidades;


namespace Negocio.Logica
{
    public class LogicaPersona
    {
        private DatosPersona datosPersona;

        public Persona PersonaActual { get; set; }


        public LogicaPersona()
        {
            datosPersona = new DatosPersona();
        }

        
        // CORROBORADO
        public Persona BuscarPersona(String nroDoc, Persona.eRol erol)
        {
            try
            {
                PersonaActual = datosPersona.BuscarPersona(nroDoc, erol);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return PersonaActual;
        }


        // CORROBORADO
        public void RegistrarPersona(Persona personaNueva)
        {
            try
            {
                datosPersona.RegistrarPersona(personaNueva);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        // CORROBORADO
        public Persona LoguearPersona(String dni, String contraseña)
        {
            try
            {
                PersonaActual = datosPersona.LoguearPersona(dni, contraseña);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return PersonaActual;
        }


        public void EliminarPersona(Persona personaAeliminar)
        {
            try
            {
                datosPersona.EliminarPersona(personaAeliminar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        // CORROBORADO
        public void ModificarPersona(Persona personaAModificar) 
        {
            try
            {
                datosPersona.ModificarPersona(personaAModificar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        // CORROBORADO
        /// <summary>
        /// Genera una nueva contraseña, la asigna al usuario y le envía un e-mail con la misma. 
        /// Retorna un true si la combinación nroDoc + email corresponde a un usuario válido, false de lo contrario.
        /// </summary>
        /// <param name="nroDoc"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool RecuperarContraseña(String nroDoc, String email)
        {
            bool personaValida = false;

            try
            {                
                Persona personaAActualizar = datosPersona.BuscarPersona(nroDoc);

                if (personaAActualizar != null)
                {

                    if (personaAActualizar.Email == email)
                    {
                        personaValida = true;

                        String contraseñaNueva = GeneradorContraseñas.GenerarContraseña();
                        datosPersona.RecuperarConstrseña(personaAActualizar, contraseñaNueva);

                        // AGREGAR CODIGO PARA ENVIAR EL EMAIL CON LA RESTAURACION DE LA CONTRASEÑA A PERSONAAACTUALIZAR.EMAIL 
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return personaValida;
        }
    }
}
