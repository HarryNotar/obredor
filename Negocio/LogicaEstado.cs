using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Entidades;

namespace Negocio.Logica
{
    public class LogicaEstado
    {
        public Estado CrearEstadoVendido(Venta ventaActual)
        {
            Estado estadoVendido = new Estado();

            estadoVendido.Fecha = ventaActual.Fecha;
            estadoVendido.IdVehiculo = ventaActual.Vehiculo.IdVehiculo;
            estadoVendido.TipoEstado = Estado.TiposEstado.Vendido;

            return estadoVendido;
        }
    }
}
