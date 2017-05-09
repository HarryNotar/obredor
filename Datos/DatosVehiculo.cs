using System;
using System.Collections.Generic;
using Negocio.Entidades;
using System.Data.SqlClient;
using Utilidades;
using System.Data;

namespace Datos
{
    public class DatosVehiculo
    {
        private SqlConnection connection;
        private DatosEstado datosEstado;


        public DatosVehiculo()
        {
            connection = new SqlConnection(ConnString.GetConnectionString());
            datosEstado = new DatosEstado();
        }


        #region Funcionalidades

        public void RegistrarVehiculo(Vehiculo vehiculoNuevo)
        {
            // Insertar el nuevo vehiculo
            String query = "INSERT INTO Vehiculos (idVersion, idColor, nroMotor, ";
            query = query + "nroChasis, dominio, observaciones, añoPatentamiento, kilometraje, valorAdquisicion, ";
            query = query + "valorVenta, esUsado, fechaRegistro, registroEliminado) VALUES (@IdVersion, @IdColor, @NroMotor, ";
            query = query + "@NroChasis, @Dominio, @Observaciones, @AñoPatentamiento, @Kilometraje, @ValorAdquisicion,";
            query = query + " @ValorVenta, @EsUsado, @FechaRegistro, @RegistroEliminado)";
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            command.Parameters.Add("@IdVersion", SqlDbType.Int).Value = vehiculoNuevo.Version.IdVersion;
            command.Parameters.Add("@IdColor", SqlDbType.Int).Value = vehiculoNuevo.Color.IdColor;
            command.Parameters.Add("@NroMotor", SqlDbType.VarChar).Value = vehiculoNuevo.NroMotor;
            command.Parameters.Add("@NroChasis", SqlDbType.NChar).Value = vehiculoNuevo.NroChasis;
            command.Parameters.Add("@Dominio", SqlDbType.NChar).Value = vehiculoNuevo.Dominio;
            command.Parameters.Add("@Observaciones", SqlDbType.Text).Value = vehiculoNuevo.Observaciones;
            command.Parameters.Add("@AñoPatentamiento", SqlDbType.Int).Value = vehiculoNuevo.AñoPatentamiento;
            command.Parameters.Add("@Kilometraje", SqlDbType.Int).Value = vehiculoNuevo.Kilometraje;
            command.Parameters.Add("@ValorAdquisicion", SqlDbType.Float).Value = vehiculoNuevo.ValorAdquisicion;
            command.Parameters.Add("@ValorVenta", SqlDbType.Float).Value = vehiculoNuevo.ValorVenta;
            command.Parameters.Add("@EsUsado", SqlDbType.Bit).Value = vehiculoNuevo.EsUsado;
            command.Parameters.Add("@FechaRegistro", SqlDbType.DateTime).Value = vehiculoNuevo.FechaRegistro;
            command.Parameters.Add("@RegistroEliminado", SqlDbType.Bit).Value = false;

            try
            {
                connection.Open();

                // Iniciar transaccion
                command.Transaction = connection.BeginTransaction();

                // Ejecutar primera consulta
                command.ExecuteNonQuery();

                // Buscar el idVehiculo asignado al vehiculo recién insertado 
                query = "SELECT @@identity";
                command.CommandText = query;
                int idVehiculo = Convert.ToInt32(command.ExecuteScalar());

                // Asignar el idVehiculo del vehiculo recién insertado al estado a guardar
                vehiculoNuevo.Estado.IdVehiculo = idVehiculo;

                // Insertar el nuevo estado con el idVehiculo buscado
                query = "INSERT INTO Estados (tipoEstado, fecha, idVehiculo) VALUES (@TipoEstado, @Fecha, @IdVehiculo)";
                command.CommandText = query;

                command.Parameters.Add("@TipoEstado", SqlDbType.VarChar).Value = vehiculoNuevo.Estado.TipoEstado.ToString();
                command.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = vehiculoNuevo.Estado.Fecha;
                command.Parameters.Add("@IdVehiculo", SqlDbType.Int).Value = vehiculoNuevo.Estado.IdVehiculo;

                command.ExecuteNonQuery();

                // Commit de transacción
                command.Transaction.Commit();
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Ha ocurrido un error al intentar registrar el vehículo. Por favor, vuelva a intentarlo.", ex);

                // Si ocurrio un error, realizar el rollback
                command.Transaction.Rollback();

                throw excepcionManejada;
            }
            finally
            {
                connection.Close();
            }
        }
        

        // CORROBORADO
        public List<Vehiculo> GetTodosVehiculos()
        {
            List<Vehiculo> listaVehiculos = new List<Vehiculo>();
            
            String query = "SELECT * FROM Vehiculos JOIN Estados ON (Vehiculos.idVehiculo = Estados.idVehiculo) JOIN Versiones ON (Vehiculos.idVersion = Versiones.idVersion)";
            query = query + "JOIN Modelos ON (Versiones.idModelo = Modelos.idModelo) JOIN Marcas ON (Modelos.idMarca = Marcas.idMarca)";
            query = query + " JOIN Colores ON (Vehiculos.idColor = Colores.idColor) WHERE Vehiculos.registroEliminado = @RegistroEliminado";
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            command.Parameters.Add("@RegistroEliminado", SqlDbType.Bit).Value = false;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Vehiculo vehiculoActual = new Vehiculo();

                    vehiculoActual = MapearDeDatos(vehiculoActual, reader);
                    
                    vehiculoActual.Estado = datosEstado.GetEstadoMasReciente(vehiculoActual);

                    listaVehiculos.Add(vehiculoActual);
                }
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Ha ocurrido un error al intentar recuperar la lista de vehículos. Por favor, vuelva a intentarlo.", ex);
                throw excepcionManejada;
            }
            finally
            {
                connection.Close();
            }

            return listaVehiculos;
        }


        // CORROBORADO
        public void ModificarVehiculo(Vehiculo vehiculoModificado)
        {
            SqlCommand command = connection.CreateCommand();
            String query = "UPDATE Vehiculos SET idVersion = @IdVersion, idColor = @IdColor, dominio = @Dominio, observaciones = @Observaciones,";
            query = query + "añoPatentamiento = @AñoPatentamiento, kilometraje = @Kilometraje, valorVenta = @ValorVenta, esUsado = @EsUsado WHERE idVehiculo = @IdVehiculo";
            command.CommandText = query;

            command.Parameters.Add("@IdVersion", SqlDbType.Int).Value = vehiculoModificado.Version.IdVersion;
            command.Parameters.Add("@IdColor", SqlDbType.Int).Value = vehiculoModificado.Color.IdColor;
            command.Parameters.Add("@Dominio", SqlDbType.NChar).Value = vehiculoModificado.Dominio;
            command.Parameters.Add("@Observaciones", SqlDbType.Text).Value = vehiculoModificado.Observaciones;
            command.Parameters.Add("@AñoPatentamiento", SqlDbType.Int).Value = vehiculoModificado.AñoPatentamiento;
            command.Parameters.Add("@Kilometraje", SqlDbType.Int).Value = vehiculoModificado.Kilometraje;
            command.Parameters.Add("@ValorVenta", SqlDbType.Float).Value = vehiculoModificado.ValorVenta;
            command.Parameters.Add("@EsUsado", SqlDbType.Bit).Value = vehiculoModificado.EsUsado;
            command.Parameters.Add("@IdVehiculo", SqlDbType.Int).Value = vehiculoModificado.IdVehiculo;


            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Ha ocurrido un error al intentrar modificar los datos del vehículo. Por favor, vuelva a intentarlo.", ex);
                throw excepcionManejada;
            }
            finally
            {
                connection.Close();
            }
        }


        public List<Vehiculo> BuscarVehiculosPorMarcaModeloVersion(Marca marca, Modelo modelo, Negocio.Entidades.Version version)
        {
            List<Vehiculo> listaVehiculos = new List<Vehiculo>();

            String query = "SELECT * FROM Vehiculos JOIN Estados ON (Vehiculos.idVehiculo = Estados.idVehiculo) JOIN Versiones ON (Vehiculos.idVersion = Versiones.idVersion)";
            query = query + "JOIN Modelos ON (Versiones.idModelo = Modelos.idModelo) JOIN Marcas ON (Modelos.idMarca = Marcas.idMarca)";
            query = query + " JOIN Colores ON (Vehiculos.idColor = Colores.idColor) ";
            query = query + "WHERE Marcas.idMarca = @IdMarca AND Modelos.idModelo = @IdModelo AND Versiones.idVersion = @IdVersion ";
            query = query + "AND Vehiculos.registroEliminado = @RegistroEliminado";
            SqlCommand command = connection.CreateCommand();
            command.CommandText = query;

            command.Parameters.Add("@IdMarca", SqlDbType.Int).Value = marca.IdMarca;
            command.Parameters.Add("@IdModelo", SqlDbType.Int).Value = modelo.IdModelo;
            command.Parameters.Add("@IdVersion", SqlDbType.Int).Value = version.IdVersion;
            command.Parameters.Add("@RegistroEliminado", SqlDbType.Bit).Value = false;

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Vehiculo vehiculoActual = new Vehiculo();

                    vehiculoActual = MapearDeDatos(vehiculoActual, reader);

                    vehiculoActual.Estado = datosEstado.GetEstadoMasReciente(vehiculoActual);

                    listaVehiculos.Add(vehiculoActual);
                }
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Ha ocurrido un error al intentar recuperar la lista de vehículos. Por favor, vuelva a intentarlo.", ex);
                throw excepcionManejada;
            }
            finally
            {
                connection.Close();
            }

            return listaVehiculos;
        }


        public void EliminarVehiculo(Vehiculo vehiculoAEliminar)
        {
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "UPDATE vehiculos SET registroEliminado = @RegistroEliminado WHERE idVehiculo = @IdVehiculo";

            command.Parameters.Add("@IdVehiculo", SqlDbType.Int).Value = vehiculoAEliminar.IdVehiculo;
            command.Parameters.Add("@RegistroEliminado", SqlDbType.Bit).Value = true;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Ha ocurrido un error al intentar eliminar el vehículo. Por favor, vuelva a intentarlo.", ex);
                throw excepcionManejada;
            }
            finally
            {
                connection.Close();
            }
        }

        #endregion


        #region Funciones internas

        private Vehiculo MapearDeDatos(Vehiculo vehiculoActual, SqlDataReader reader)
        {
            Negocio.Entidades.Version versionActual = new Negocio.Entidades.Version();
            Modelo modeloActual = new Modelo();
            Marca marcaActual = new Marca();
            Color colorActual = new Color();

            marcaActual.IdMarca = Convert.ToInt32(reader["idMarca"]);
            marcaActual.Nombre = Convert.ToString(reader["nombreMarca"]);

            modeloActual.IdModelo = Convert.ToInt32(reader["idModelo"]);
            modeloActual.Nombre = Convert.ToString(reader["nombreModelo"]);
            modeloActual.Marca = marcaActual;

            versionActual.IdVersion = Convert.ToInt32(reader["idVersion"]);
            versionActual.Nombre = Convert.ToString(reader["nombreVersion"]);
            versionActual.Modelo = modeloActual;

            colorActual.IdColor = Convert.ToInt32(reader["idColor"]);
            colorActual.Nombre = Convert.ToString(reader["nombreColor"]);

            vehiculoActual.IdVehiculo = Convert.ToInt32(reader["idVehiculo"]);
            vehiculoActual.Version = versionActual;
            vehiculoActual.Color = colorActual;
            vehiculoActual.NroChasis = Convert.ToString(reader["nroChasis"]);
            vehiculoActual.NroMotor = Convert.ToString(reader["nroMotor"]);
            vehiculoActual.Dominio = Convert.ToString(reader["dominio"]);
            vehiculoActual.Observaciones = Convert.ToString(reader["observaciones"]);
            vehiculoActual.AñoPatentamiento = Convert.ToInt32(reader["añoPatentamiento"]);
            vehiculoActual.Kilometraje = Convert.ToInt32(reader["kilometraje"]);
            vehiculoActual.ValorAdquisicion = Convert.ToDouble(reader["valorAdquisicion"]);
            vehiculoActual.ValorVenta = Convert.ToDouble(reader["valorVenta"]);
            vehiculoActual.EsUsado = Convert.ToBoolean(reader["esUsado"]);
            vehiculoActual.FechaRegistro = Convert.ToDateTime(reader["fechaRegistro"]);

            return vehiculoActual;
        }

        #endregion
    }
}

