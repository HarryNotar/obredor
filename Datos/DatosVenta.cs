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
    public class DatosVenta
    {
        private SqlConnection connection;

        private DatosEstado datosEstado;


        public DatosVenta()
        {
            connection = new SqlConnection(ConnString.GetConnectionString());

            datosEstado = new DatosEstado();
        }


        // CORROBORADO
        public void RegistrarVenta(Venta ventaActual)
        {
            SqlCommand command = connection.CreateCommand();
            String query = "INSERT INTO Ventas (fecha, cliente_nroDoc, idVehiculo, empleado_nroDoc, montoComision, montoEfectivo, montoFinanciado, tasaInteresAnual, cantCuotas, montoCuota) VALUES ";
            query = query + "(@Fecha, @Cliente_nroDoc, @IdVehiculo, @Empleado_nroDoc, ";
            query = query + "@MontoComision, @MontoEfectivo, @MontoFinanciado, @TasaInteresAnual, @CantCuotas, @MontoCuota)";
            command.CommandText = query;

            command.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = ventaActual.Fecha;
            command.Parameters.Add("@Cliente_nroDoc", SqlDbType.NChar).Value = ventaActual.Cliente.NroDoc;
            command.Parameters.Add("@IdVehiculo", SqlDbType.Int).Value = ventaActual.Vehiculo.IdVehiculo;
            command.Parameters.Add("@Empleado_nroDoc", SqlDbType.NChar).Value = ventaActual.Empleado.NroDoc;
            command.Parameters.Add("@MontoComision", SqlDbType.Float).Value = ventaActual.MontoComision;
            command.Parameters.Add("@MontoEfectivo", SqlDbType.Float).Value = ventaActual.MontoEfectivo;
            command.Parameters.Add("@MontoFinanciado", SqlDbType.Float).Value = ventaActual.MontoFinanciado;
            command.Parameters.Add("@TasaInteresAnual", SqlDbType.Float).Value = ventaActual.TasaInteresAnual;
            command.Parameters.Add("@CantCuotas", SqlDbType.Int).Value = ventaActual.CantCuotas;
            command.Parameters.Add("@MontoCuota", SqlDbType.Float).Value = ventaActual.MontoCuota;


            try
            {
                connection.Open();

                // Iniciar transaccion
                command.Transaction = connection.BeginTransaction();

                // Ejecutar primera consulta
                command.ExecuteNonQuery();

                // Insertar el nuevo estado del vehículo
                query = "INSERT INTO Estados (tipoEstado, fecha, idVehiculo) VALUES (@TipoEstado, @Fecha, @IdVehiculo)";
                command.CommandText = query;

                command.Parameters.Add("@TipoEstado", SqlDbType.VarChar).Value = ventaActual.Vehiculo.Estado.TipoEstado.ToString();
                // Las variables @Fecha e @IdVehiculo toman el mismo valor que en el INSERT del vehiculo

                command.ExecuteNonQuery();

                // Commit de la transacción
                command.Transaction.Commit();
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Ha ocurrido un error al intentar registrar la venta. Por favor, vuelva a intentarlo.", ex);

                // Si ocurrio un error, realizar el rollback
                command.Transaction.Rollback();

                throw excepcionManejada;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
