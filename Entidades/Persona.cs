using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class Persona
    {
        public enum eRol { Cliente, Empleado }
        public enum ePerfil { Administrador, General, Consultor }

       
       #region Propiedades

        public String NroDoc { get; set; }
        public eRol Rol { get; set; }
        public String Email { get; set; }
        public String Apellido { get; set; }
        public String Nombre { get; set; }
        public String Telefono1 { get; set; }
        public String Telefono2 { get; set; }
        public String Telefono3 { get; set; }
        public ePerfil Perfil { get; set; }
        public String Contraseña { get; set; }
        public String Localidad { get; set; }
        public String Direccion { get; set; }
        public String Observaciones { get; set; }

        #endregion


        public Persona()
        {
            // Constructor por defecto
        }

        public Persona(string nroDoc, eRol erol, string email, string apellido, string nombre, string telefono1, string telefono2, string telefono3, string contraseña, ePerfil eperfil, string localidad, string direccion, string observaciones)
        {
            NroDoc = nroDoc;
            Rol = erol;
            Email = email;
            Apellido = apellido;
            Nombre = nombre;
            Telefono1 = telefono1;
            Telefono2 = telefono2;
            Telefono3 = telefono3;
            Contraseña = contraseña;
            Perfil = eperfil;
            Localidad = localidad;
            Direccion = direccion;
            Observaciones = observaciones;
        }
    }
}
