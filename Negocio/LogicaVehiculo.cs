using System;
using System.Collections.Generic;
using Negocio.Entidades;
using Datos;

namespace Negocio.Logica
{
    public class LogicaVehiculo
    {
        private DatosVehiculo datosVehiculo;

        
        public LogicaVehiculo()
        {
            datosVehiculo = new DatosVehiculo();
        }


        // CORROBORADO
        public void RegistrarVehiculo(Vehiculo vehiculoNuevo)
        {

            vehiculoNuevo.Estado.TipoEstado = Estado.TiposEstado.Disponible;
            vehiculoNuevo.Estado.Fecha = DateTime.Now;

            vehiculoNuevo.FechaRegistro = vehiculoNuevo.Estado.Fecha;

            try
            {
                datosVehiculo.RegistrarVehiculo(vehiculoNuevo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        // CORROBORADO
        public List<Vehiculo> GetTodosVehiculos()
        {
            List<Vehiculo> listaVehiculos = new List<Vehiculo>();

            try
            {
                listaVehiculos = datosVehiculo.GetTodosVehiculos();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listaVehiculos;
        }



        public void ModificarVehiculo(Vehiculo vehiculoModificado)
        {
            try
            {
                datosVehiculo.ModificarVehiculo(vehiculoModificado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<Vehiculo> BuscarVehiculosPorMarcaModeloVersion(Marca marca, Modelo modelo, Entidades.Version version)
        {
            List<Vehiculo> listaVehiculos = new List<Vehiculo>();

            try
            {
                listaVehiculos = datosVehiculo.BuscarVehiculosPorMarcaModeloVersion(marca, modelo, version);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listaVehiculos;
        }


        public void EliminarVehiculo(Vehiculo vehiculoAeliminar)
        {
            try
            {
                datosVehiculo.EliminarVehiculo(vehiculoAeliminar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
