using System;
using Negocio.Entidades;

namespace Interfaz.Escritorio
{
    public class VisualizadorVehiculo
    {
        public String NombreMarca { get; set; }
        public String NombreModelo { get; set; }
        public String NombreVersion { get; set; }
        public int AñoPatentamiento { get; set; }
        public String NombreColor { get; set; }
        public double ValorVenta { get; set; }
        public Vehiculo Vehiculo { get; set; }
    }
}
