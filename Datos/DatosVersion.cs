using System;
using System.Collections.Generic;
using Negocio.Entidades;
using System.Data.SqlClient;
using Utilidades;
using System.Data;

namespace Datos
{
    public class DatosVersion
    {
        private SqlConnection connection;


        public DatosVersion()
        {
            connection = new SqlConnection(ConnString.GetConnectionString());
        }


        // CORROBORADO
        public void RegistrarVersion(Negocio.Entidades.Version versionNueva)
        {
            SqlCommand command = connection.CreateCommand();
            String query = "INSERT INTO Versiones (nombreVersion, idModelo, registroEliminado) VALUES (@NombreVersion, @IdModelo, @RegistroEliminado)";
            command.CommandText = query;

            command.Parameters.Add("@NombreVersion", SqlDbType.VarChar).Value = versionNueva.Nombre;
            command.Parameters.Add("@IdModelo", SqlDbType.Int).Value = versionNueva.Modelo.IdModelo;
            command.Parameters.Add("@RegistroEliminado", SqlDbType.Bit).Value = false;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Ha ocurrido un error al intentar registrar la versión. Por favor, vuelva a intentarlo.", ex);
                throw excepcionManejada;
            }
            finally
            {
                connection.Close();
            }
        }


        // CORROBORADO
        public List<Negocio.Entidades.Version> GetTodasVersiones(Modelo modeloActual)
        {
            List<Negocio.Entidades.Version> listaVersiones = new List<Negocio.Entidades.Version>();

            String query = "SELECT * FROM Versiones WHERE idModelo = @IdModelo AND registroEliminado = @RegistroEliminado";
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            command.Parameters.Add("@IdModelo", SqlDbType.Int).Value = modeloActual.IdModelo;
            command.Parameters.Add("@RegistroEliminado", SqlDbType.Bit).Value = false;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    Negocio.Entidades.Version versionActual = new Negocio.Entidades.Version();

                    versionActual.Nombre = Convert.ToString(reader["nombreVersion"]).Trim();
                    versionActual.IdVersion = Convert.ToInt32(reader["idVersion"]);
                    versionActual.Modelo = modeloActual;

                    listaVersiones.Add(versionActual);
                }
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Ha ocurrido un error al intentar recuperar las versiones. Por favor, vuelva a intentarlo.", ex);
                throw excepcionManejada;
            }
            finally
            {
                connection.Close();
            }

            return listaVersiones;
        }


        public void EliminarVersion(Negocio.Entidades.Version versionAEliminar)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "UPDATE versiones SET registroEliminado = @RegistroEliminado WHERE idVersion = @IdVersion";

            command.Parameters.Add("@IdVersion", SqlDbType.Int).Value = versionAEliminar.IdVersion;
            command.Parameters.Add("@RegistroEliminado", SqlDbType.Bit).Value = true;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Ha ocurrido un error al intentar eliminar la versión. Por favor, vuelva a intentarlo.", ex);
                throw excepcionManejada;
            }
            finally
            {
                connection.Close();
            }
        }



        public bool VersionYaRegistrada(Negocio.Entidades.Version versionAverificar)
        {
            bool versionYaRegistrada = false;

            String query = "SELECT * FROM versiones WHERE nombreVersion = @NombreVersion AND registroEliminado = @RegistroEliminado";
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            command.Parameters.Add("@NombreVersion", SqlDbType.VarChar).Value = versionAverificar.Nombre;
            command.Parameters.Add("@RegistroEliminado", SqlDbType.Bit).Value = false;


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    versionYaRegistrada = true;
                }
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Ha ocurrido un error al intentar registrar la versión. Por favor, vuelva a intentarlo.", ex);
                throw excepcionManejada;
            }
            finally
            {
                connection.Close();
            }

            return versionYaRegistrada;
        }
    }
}
