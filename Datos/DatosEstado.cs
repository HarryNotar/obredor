using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades;

namespace Datos
{
    public class DatosEstado
    {
        private SqlConnection connection;


        public DatosEstado()
        {
            connection = new SqlConnection(ConnString.GetConnectionString());
        }


        // CORROBORADO
        public void RegistrarEstado(Estado estadoNuevo)
        {
            SqlCommand command = connection.CreateCommand();
            String query = "INSERT INTO Estados (tipoEstado, fecha, idVehiculo) VALUES (@TipoEstado, @Fecha, @IdVehiculo)";
            command.CommandText = query;

            command.Parameters.Add("@TipoEstado", SqlDbType.VarChar).Value = estadoNuevo.TipoEstado.ToString();
            command.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = estadoNuevo.Fecha;
            command.Parameters.Add("@IdVehiculo", SqlDbType.Int).Value = estadoNuevo.IdVehiculo;


            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Ha ocurrido un error al intentar registrar el estado del vehículo. Por favor, vuelva a intentarlo.", ex);
                throw excepcionManejada;
            }
            finally
            {
                connection.Close();
            }
        }


        // CORROBORADO
        public Estado GetEstadoMasReciente(Vehiculo vehiculoActual)
        {
            List<Estado> listaEstados = new List<Estado>();

            String query = "SELECT * FROM Estados WHERE idVehiculo = '" + vehiculoActual.IdVehiculo + "'";
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            Estado estadoMasReciente = new Estado();

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                // Buscar todos los estados de vehiculoActual
                while (reader.Read())
                {
                    Estado estadoActual = new Estado();

                    estadoActual.IdVehiculo = vehiculoActual.IdVehiculo;
                    estadoActual.Fecha = Convert.ToDateTime(reader["fecha"]);

                    String tipoEstado = Convert.ToString(reader["tipoEstado"]);
                    switch(tipoEstado)
                    {
                        case "Disponible":
                            estadoActual.TipoEstado = Estado.TiposEstado.Disponible;
                            break;
                        case "Vendido":
                            estadoActual.TipoEstado = Estado.TiposEstado.Vendido;
                            break;
                    }

                    listaEstados.Add(estadoActual);
                }

                // Buscar el estado más reciente
                foreach (Estado estadoActual in listaEstados)
                {
                    if (estadoActual.Fecha > estadoMasReciente.Fecha)
                    {
                        estadoMasReciente = estadoActual;
                    }
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

            return estadoMasReciente;
        }
    }
}
