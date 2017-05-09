using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Entidades;
using System.Data.SqlClient;
using Utilidades;
using System.Data;

namespace Datos
{
    public class DatosMarca
    {
        private SqlConnection connection;
        private DatosModelo datosModelo;


        public DatosMarca()
        {
            connection = new SqlConnection(ConnString.GetConnectionString());
            datosModelo = new DatosModelo();
        }


        public void RegistrarMarca(Marca marcaNueva)
        {
            SqlCommand command = connection.CreateCommand();
            String query = "INSERT INTO Marcas (nombreMarca, registroEliminado) VALUES (@NombreMarca, @RegistroEliminado)";
            command.CommandText = query;

            command.Parameters.Add("@NombreMarca", SqlDbType.VarChar).Value = marcaNueva.Nombre;
            command.Parameters.Add("@RegistroEliminado", SqlDbType.Bit).Value = false;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Ha ocurrido un error al intentar eliminar la marca. Por favor, vuelva a intentarlo.", ex);
                throw excepcionManejada;
            }
            finally
            {
                connection.Close();
            }
        }


        public List<Marca> GetTodasMarcas()
        {
            List<Marca> listaMarcas = new List<Marca>();

            String query = "SELECT * FROM marcas WHERE registroEliminado = @RegistroEliminado";
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            command.Parameters.Add("@RegistroEliminado", SqlDbType.Bit).Value = false;

            try
            {
                connection.Open();
                
                SqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    Marca marcaActual = new Marca();

                    marcaActual.Nombre = Convert.ToString(reader["nombreMarca"]).Trim();
                    marcaActual.IdMarca = Convert.ToInt32(reader["idMarca"]);
                    marcaActual.ListaModelos = datosModelo.GetTodosModelos(marcaActual);

                    listaMarcas.Add(marcaActual);
                }
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Ha ocurrido un error al intentar eliminar la marca. Por favor, vuelva a intentarlo.", ex);
                throw excepcionManejada;
            }
            finally
            {
                connection.Close();
            }

            return listaMarcas;
        }


        public void EliminarMarca(Marca marcaAeliminar)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "UPDATE marcas SET registroEliminado = @RegistroEliminado WHERE idMarca = @IdMarca";

            command.Parameters.Add("@RegistroEliminado", SqlDbType.Bit).Value = true;
            command.Parameters.Add("@IdMarca", SqlDbType.Int).Value = marcaAeliminar.IdMarca;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Ha ocurrido un error al intentar eliminar la marca. Por favor, vuelva a intentarlo.", ex);
                throw excepcionManejada;
            }
            finally
            {
                connection.Close();
            }
        }


        public bool MarcaYaRegistrada(Marca marcaAverificar)
        {
            bool marcaYaRegistrada = false;

            String query = "SELECT * FROM marcas WHERE nombreMarca = @NombreMarca AND registroEliminado = @RegistroEliminado";
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            command.Parameters.Add("@NombreMarca", SqlDbType.VarChar).Value = marcaAverificar.Nombre;
            command.Parameters.Add("@RegistroEliminado", SqlDbType.Bit).Value = false;


            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    marcaYaRegistrada = true;   
                }
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Ha ocurrido un error al intentar registrar la marca. Por favor, vuelva a intentarlo.", ex);
                throw excepcionManejada;
            }
            finally
            {
                connection.Close();
            }

            return marcaYaRegistrada;
        }
    }
}