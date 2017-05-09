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
    public class DatosComision
    {
        private SqlConnection connection;


        public DatosComision()
        {
            connection = new SqlConnection(ConnString.GetConnectionString());
        }


        // CORROBORADO
        public Comision GetComisionActual()
        {
            String query = "SELECT * FROM Comisiones ORDER BY fecha DESC";
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            Comision comisionActual = null;

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    comisionActual = new Comision();

                    comisionActual.Fecha = Convert.ToDateTime(reader["fecha"]);
                    comisionActual.Porcentaje = Convert.ToDouble(reader["porcentaje"]);
                }
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Ha ocurrido un error al intentar recuperar los datos de la comisión. Por favor, vuelva a intentarlo.", ex);
                throw excepcionManejada;
            }
            finally
            {
                connection.Close();
            }

            return comisionActual;
        }


        public void RegistrarComision(Comision comisionNueva)
        {
            SqlCommand command = connection.CreateCommand();
            String query = "INSERT INTO Comisiones (porcentaje, fecha) VALUES (@Porcentaje, @Fecha)";
            command.CommandText = query;

            command.Parameters.Add("@Porcentaje", SqlDbType.Float).Value = comisionNueva.Porcentaje;
            command.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = comisionNueva.Fecha;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Ha ocurrido un error al intentar registrar la comisión. Por favor, vuelva a intentarlo.", ex);
                throw excepcionManejada;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
