using Datos;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Logica
{
    public class LogicaVenta
    {
        private LogicaEstado logicaEstado;
        private DatosVenta datosVenta;
        private DatosComision datosComision;


        public LogicaVenta()
        {
            datosVenta = new DatosVenta();
            datosComision = new DatosComision();
            logicaEstado = new LogicaEstado();
        }


        // CORROBORADO
        public void RegistrarVenta(Venta ventaActual)
        {
            ventaActual.Fecha = DateTime.Now;

            Estado estadoVendido;

            estadoVendido = logicaEstado.CrearEstadoVendido(ventaActual);
            
            ventaActual.Vehiculo.Estado = estadoVendido;

            try
            {
                Comision comisionActual = datosComision.GetComisionActual();

                if (comisionActual != null)
                {
                    ventaActual.MontoComision = ventaActual.Vehiculo.ValorVenta * comisionActual.Porcentaje/100;
                }
                else
                {
                    ventaActual.MontoComision = 0;
                }

                datosVenta.RegistrarVenta(ventaActual);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
