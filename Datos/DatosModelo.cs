using System;
using System.Collections.Generic;
using Negocio.Entidades;
using System.Data.SqlClient;
using Utilidades;
using System.Data;

namespace Datos
{
    public class DatosModelo
    {
        private SqlConnection connection;
        private DatosVersion datosVersion;


        public DatosModelo()
        {
            connection = new SqlConnection(ConnString.GetConnectionString());
            datosVersion = new DatosVersion();
        }


        // CORROBORADO
        public void RegistrarModelo(Modelo modeloNuevo)
        {
            SqlCommand command = connection.CreateCommand();
            String query = "INSERT INTO Modelos (nombreModelo, idMarca, registroEliminado) VALUES (@NombreModelo, @IdMarca, @RegistroEliminado)";
            command.CommandText = query;

            command.Parameters.Add("@NombreModelo", SqlDbType.VarChar).Value = modeloNuevo.Nombre;
            command.Parameters.Add("@IdMarca", SqlDbType.Int).Value = modeloNuevo.Marca.IdMarca;
            command.Parameters.Add("@RegistroEliminado", SqlDbType.Bit).Value = false;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Ha ocurrido un error al intentar registrar el modelo. Por favor, vuelva a intentarlo.", ex);
                throw excepcionManejada;
            }
            finally
            {
                connection.Close();
            }
        }


        // CORROBORADO
        public List<Modelo> GetTodosModelos(Marca marcaSeleccionada)
        {          
            List<Modelo> listaModelos = new List<Modelo>();
            String query = "SELECT * FROM Modelos WHERE idMarca = @IdMarca AND registroEliminado = @RegistroEliminado";
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            command.Parameters.Add("@IdMarca", SqlDbType.Int).Value = marcaSeleccionada.IdMarca;
            command.Parameters.Add("@RegistroEliminado", SqlDbType.Bit).Value = false;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Modelo modeloActual = new Modelo();

                    modeloActual.Nombre = Convert.ToString(reader["nombreModelo"]).Trim();
                    modeloActual.IdModelo = Convert.ToInt32(reader["idModelo"]);
                    modeloActual.Marca = marcaSeleccionada;
                    modeloActual.ListaVersiones = datosVersion.GetTodasVersiones(modeloActual);

                    listaModelos.Add(modeloActual);
                }
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Ha ocurrido un error al intentar recuperar los modelos. Por favor, vuelva a intentarlo.", ex);
                throw excepcionManejada;
            }
            finally
            {
                connection.Close();
            }

            return listaModelos;
        }


        public void EliminarModelo(Modelo modeloAEliminar)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "UPDATE modelos SET registroEliminado = @RegistroEliminado WHERE idModelo = @IdModelo";

            command.Parameters.Add("@RegistroEliminado", SqlDbType.Bit).Value = true;
            command.Parameters.Add("@IdModelo", SqlDbType.Int).Value = modeloAEliminar.IdModelo;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Ha ocurrido un error al intentar eliminar el modelo. Por favor, vuelva a intentarlo.", ex);
                throw excepcionManejada;
            }
            finally
            {
                connection.Close();
            }
        }


        public bool ModeloYaRegistrado(Modelo modeloAverificar)
        {
            bool modeloYaRegistrado = false;

            String query = "SELECT * FROM modelos WHERE nombreModelo = @NombreModelo AND registroEliminado = @RegistroEliminado";
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            command.Parameters.Add("@NombreModelo", SqlDbType.VarChar).Value = modeloAverificar.Nombre;
            command.Parameters.Add("@RegistroEliminado", SqlDbType.Bit).Value = false;


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    modeloYaRegistrado = true;
                }
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Ha ocurrido un error al intentar registrar el modelo. Por favor, vuelva a intentarlo.", ex);
                throw excepcionManejada;
            }
            finally
            {
                connection.Close();
            }

            return modeloYaRegistrado;
        }
    }
}
