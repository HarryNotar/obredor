using System;
using System.Collections.Generic;
using Negocio.Entidades;
using Utilidades;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class DatosColor
    {

        private SqlConnection connection;


        public DatosColor()
        {
            connection = new SqlConnection(ConnString.GetConnectionString());
        }


        // CORROBORADO
        public void RegistrarColor(Color colorNuevo)
        {
            SqlCommand command = connection.CreateCommand();
            String query = "INSERT INTO Colores (nombreColor, registroEliminado) VALUES (@NombreColor, @RegistroEliminado)";
            command.CommandText = query;

            command.Parameters.Add("@NombreColor", SqlDbType.VarChar).Value = colorNuevo.Nombre;
            command.Parameters.Add("@RegistroEliminado", SqlDbType.Bit).Value = false; 

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Ha ocurrido un error al intentar registrar el color. Por favor, vuelva a intentarlo.", ex);
                throw excepcionManejada;
            }
            finally
            {
                connection.Close();
            }
        }


        // CORROBORADO
        public List<Color> GetTodosColores()
        {
            List<Color> listaColores = new List<Color>();

            String query = "SELECT * FROM Colores WHERE registroEliminado = @RegistroEliminado";
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            command.Parameters.Add("@RegistroEliminado", SqlDbType.Bit).Value = false;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    Color colorActual = new Color();

                    colorActual.Nombre = Convert.ToString(reader["nombreColor"]).Trim();
                    colorActual.IdColor = Convert.ToInt32(reader["idColor"]);

                    listaColores.Add(colorActual);
                }
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Ha ocurrido un error al intentar recuperar los colores. Por favor, vuelva a intentarlo.", ex);
                throw excepcionManejada;
            }
            finally
            {
                connection.Close();
            }

            return listaColores;
        }


        public void EliminarColor(Color colorAEliminar)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "UPDATE colores SET registroEliminado = @RegistroEliminado WHERE idColor = @IdColor";

            command.Parameters.Add("@RegistroEliminado", SqlDbType.Bit).Value = true;
            command.Parameters.Add("@IdColor", SqlDbType.Int).Value = colorAEliminar.IdColor;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Ha ocurrido un error al intentar eliminar el color. Por favor, vuelva a intentarlo.", ex);
                throw excepcionManejada;
            }
            finally
            {
                connection.Close();
            }
        }



        public bool ColorYaRegistrado(Color colorAverificar)
        {
            bool colorYaRegistrado = false;

            String query = "SELECT * FROM colores WHERE nombreColor = @NombreColor AND registroEliminado = @RegistroEliminado";
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            command.Parameters.Add("@NombreColor", SqlDbType.VarChar).Value = colorAverificar.Nombre;
            command.Parameters.Add("@RegistroEliminado", SqlDbType.Bit).Value = false;


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    colorYaRegistrado = true;
                }
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Ha ocurrido un error al intentar registrar el color. Por favor, vuelva a intentarlo.", ex);
                throw excepcionManejada;
            }
            finally
            {
                connection.Close();
            }

            return colorYaRegistrado;
        }
    }
}
