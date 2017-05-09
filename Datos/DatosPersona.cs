using System;
using System.Data.SqlClient;
using Negocio.Entidades;
using Utilidades;
using System.Data;

namespace Datos
{
    public class DatosPersona
    {
        private SqlConnection connection;

        public Persona PersonaActual { get; set; }


        public DatosPersona()
        {
            connection = new SqlConnection(ConnString.GetConnectionString());
        }



        #region Funcionalidades

        public Persona BuscarPersona(String nroDoc)
        {
            PersonaActual = null;

            SqlCommand command = connection.CreateCommand();
            String query = "SELECT * FROM personas WHERE nroDoc = @NroDoc AND registroEliminado = @RegistroEliminado";
            command.CommandText = query;

            command.Parameters.Add("@NroDoc", SqlDbType.NChar).Value = nroDoc;
            command.Parameters.Add("@RegistroEliminado", SqlDbType.Bit).Value = false;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    MapearDeDatos(reader);
                }
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Ha ocurrido un error al intentar recuperar los datos de la persona. Por favor, vuelva a intentarlo.", ex);

                throw excepcionManejada;
            }
            finally
            {
                connection.Close();
            }

            return PersonaActual;
        }


        // CORROBORADO
        public Persona BuscarPersona(String nroDoc, Persona.eRol erol)
        {
            String rol = erol.ToString();

            PersonaActual = null;

            SqlCommand command = connection.CreateCommand();
            String query = "SELECT * FROM personas WHERE nroDoc = @NroDoc AND rol = @Rol AND registroEliminado = @RegistroEliminado";
            command.CommandText = query;

            command.Parameters.Add("@NroDoc", SqlDbType.NChar).Value = nroDoc;
            command.Parameters.Add("@Rol", SqlDbType.VarChar).Value = rol;
            command.Parameters.Add("@RegistroEliminado", SqlDbType.Bit).Value = false;

            try
            {
                connection.Open();
                
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    MapearDeDatos(reader);                    
                }
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Ha ocurrido un error al intentar recuperar los datos de la persona. Por favor, vuelva a intentarlo.", ex);

                throw excepcionManejada;
            }
            finally
            {
                connection.Close();
            }

            return PersonaActual;
        }

        
        public void RegistrarPersona(Persona personaNueva)
        {
            if(!EstaRegistrada(personaNueva.NroDoc))
            {
                SqlCommand command = connection.CreateCommand();
                String query = "INSERT INTO Personas (nroDoc, rol, email, apellido, nombre, telefono1, telefono2, telefono3, contraseña, perfil, localidad, direccion, observaciones, registroEliminado) VALUES ";
                query = query + "(@NroDoc, @Rol, @Email, @Apellido, @Nombre, @Telefono1, @Telefono2, @Telefono3, @Contraseña, @Perfil, @Localidad, @Direccion, @Observaciones, @RegistroEliminado)";
                command.CommandText = query;

                command.Parameters.Add("@NroDoc", SqlDbType.NChar).Value = personaNueva.NroDoc;
                command.Parameters.Add("@Rol", SqlDbType.VarChar).Value = personaNueva.Rol;
                command.Parameters.Add("@Email", SqlDbType.VarChar).Value = personaNueva.Email;
                command.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = personaNueva.Apellido;
                command.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = personaNueva.Nombre;
                command.Parameters.Add("@Telefono1", SqlDbType.NVarChar).Value = personaNueva.Telefono1;
                command.Parameters.Add("@Telefono2", SqlDbType.VarChar).Value = personaNueva.Telefono2;
                command.Parameters.Add("@Telefono3", SqlDbType.VarChar).Value = personaNueva.Telefono3;
                command.Parameters.Add("@Contraseña", SqlDbType.NChar).Value = personaNueva.Contraseña;
                command.Parameters.Add("@Perfil", SqlDbType.VarChar).Value = personaNueva.Perfil;
                command.Parameters.Add("@Localidad", SqlDbType.VarChar).Value = personaNueva.Localidad;
                command.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = personaNueva.Direccion;
                command.Parameters.Add("@Observaciones", SqlDbType.Text).Value = personaNueva.Observaciones;
                command.Parameters.Add("@RegistroEliminado", SqlDbType.Bit).Value = false;
                
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Exception excepcionManejada = new Exception("Ha ocurrido un error al intentar registrar la persona. Por favor, vuelva a intentarlo.", ex);
                    throw excepcionManejada;
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                Exception excepcionManejada = new Exception("La persona que intenta registrar ya se encuentra registrada.");
                throw excepcionManejada;
            }
        }


        public bool EstaRegistrada(String nroDoc)
        {
            bool estaRegistrada = false;

            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM personas WHERE nroDoc = @NroDoc AND registroEliminado = @RegistroEliminado";

            command.Parameters.Add("@NroDoc", SqlDbType.NChar).Value = nroDoc;
            command.Parameters.Add("@RegistroEliminado", SqlDbType.Bit).Value = false;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) //Verifica que el Reader no este vacio
                {
                    estaRegistrada = true;
                }
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Ha ocurrido un error al intentar registrar la persona. Por favor, vuelva a intentarlo.", ex);
                throw excepcionManejada;
            }
            finally
            {
                connection.Close();
            }

            return estaRegistrada;
        }


        public void EliminarPersona(Persona personaAEliminar)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "UPDATE personas SET registroEliminado = @RegistroEliminado WHERE nroDoc = @NroDoc";

            command.Parameters.Add("@NroDoc", SqlDbType.NChar).Value = personaAEliminar.NroDoc;
            command.Parameters.Add("@RegistroEliminado", SqlDbType.Bit).Value = true;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Ha ocurrido un error al intentar eliminar la persona. Por favor, vuelva a intentarlo.", ex);
                throw excepcionManejada;
            }
            finally
            {
                connection.Close();
            }
        }


        // CORROBORADO
        public void ModificarPersona(Persona personaAModificar)
         {
            SqlCommand command = connection.CreateCommand();
            String query = "UPDATE Personas SET rol = @Rol, email = @Email, apellido = @Apellido, nombre = @Nombre, telefono1 = @Telefono1, telefono2 = @Telefono2, telefono3 = @Telefono3, ";
            query = query + "perfil = @Perfil, localidad = @Localidad, direccion = @Direccion, observaciones = @Observaciones WHERE nroDoc = @NroDoc";
            command.CommandText = query;

            command.Parameters.Add("@Rol", SqlDbType.VarChar).Value = personaAModificar.Rol;
            command.Parameters.Add("@Email", SqlDbType.VarChar).Value = personaAModificar.Email;
            command.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = personaAModificar.Apellido;
            command.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = personaAModificar.Nombre;
            command.Parameters.Add("@Telefono1", SqlDbType.NChar).Value = personaAModificar.Telefono1;
            command.Parameters.Add("@Telefono2", SqlDbType.VarChar).Value = personaAModificar.Telefono2;
            command.Parameters.Add("@Telefono3", SqlDbType.VarChar).Value = personaAModificar.Telefono3;
            command.Parameters.Add("@Perfil", SqlDbType.VarChar).Value = personaAModificar.Perfil;
            command.Parameters.Add("@Localidad", SqlDbType.VarChar).Value = personaAModificar.Localidad;
            command.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = personaAModificar.Direccion;
            command.Parameters.Add("@Observaciones", SqlDbType.Text).Value = personaAModificar.Observaciones;
            command.Parameters.Add("@NroDoc", SqlDbType.NChar).Value = personaAModificar.NroDoc;


            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Ha ocurrido un error al intentrar modificar los datos de la persona. Por favor, vuelva a intentarlo.", ex);
                throw excepcionManejada;
            }
            finally
            {
                connection.Close();
            }
        }
        

        public void RecuperarConstrseña(Persona personaAActualizar, String nuevaContraseña)
        {
            String contraseña = nuevaContraseña;
            String nroDoc = personaAActualizar.NroDoc;

            SqlCommand command = connection.CreateCommand();
            String query = "UPDATE personas SET contraseña = @Contraseña WHERE nroDoc = @NroDoc";
            command.CommandText = query;

            command.Parameters.Add("@NroDoc", SqlDbType.NChar).Value = nroDoc;
            command.Parameters.Add("@Contraseña", SqlDbType.NChar).Value = contraseña;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Ha ocurrido un error al intentar actualizar su contraseña. Por favor, vuelva a intentarlo.", ex);
                throw excepcionManejada;
            }
            finally
            {
                connection.Close();
            }
        }


        // CORROBORADO
        public Persona LoguearPersona(String nroDoc, String contraseña)
        {
            PersonaActual = null;

            SqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM personas WHERE nroDoc = @NroDoc AND registroEliminado = @RegistroEliminado";

            command.Parameters.Add("@NroDoc", SqlDbType.NChar).Value = nroDoc;
            command.Parameters.Add("@RegistroEliminado", SqlDbType.Bit).Value = false;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                
                if (reader.HasRows) //Verifica que el Reader no este vacio
                {
                    if (reader.Read())
                    {
                        if (((Convert.ToString(reader["contraseña"]).Trim()) == contraseña))
                        {
                            MapearDeDatos(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Ha ocurrido un error al intentar loguear su usuario. Por favor, vuelva a intentarlo.", ex);
                throw excepcionManejada;
            }
            finally
            {
                connection.Close();
            }

            return PersonaActual;
        }

        #endregion


        #region Funciones internas

        // Mapea los datos del reader y los asigna a PersonaActual
        private void MapearDeDatos(SqlDataReader reader)
        {
            String nroDoc = Convert.ToString(reader["nroDoc"]).Trim();
            String email = Convert.ToString(reader["email"]).Trim();
            String apellido = Convert.ToString(reader["apellido"]).Trim();
            String nombre = Convert.ToString(reader["nombre"]).Trim();
            String contraseña = Convert.ToString(reader["contraseña"]).Trim();
            String telefono1 = Convert.ToString(reader["telefono1"]).Trim();
            String telefono2 = Convert.ToString(reader["telefono2"]).Trim();
            String telefono3 = Convert.ToString(reader["telefono3"]).Trim();
            String localidad = Convert.ToString(reader["localidad"]).Trim();
            String direccion = Convert.ToString(reader["direccion"]).Trim();
            String observaciones = Convert.ToString(reader["observaciones"]).Trim();

            String perfil = Convert.ToString(reader["perfil"]).Trim();
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

            String rol = Convert.ToString(reader["rol"]).Trim();
            Persona.eRol erol = new Persona.eRol();
            switch (rol)
            {
                case "Cliente":
                    erol = Persona.eRol.Cliente;
                    break;
                case "Empleado":
                    erol = Persona.eRol.Empleado;
                    break;
            }

            PersonaActual = new Persona(nroDoc, erol, email, apellido, nombre, telefono1, telefono2, telefono3, contraseña, eperfil, localidad,
                                                 direccion, observaciones);
        }

        #endregion
    }
}

