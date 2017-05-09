using System;

namespace Negocio.Entidades
{
    public class Venta
    { 
        #region Propiedades
        public DateTime Fecha { get; set; }
        public double MontoComision { get; set; }
        public double MontoEfectivo { get; set; }
        public double MontoFinanciado { get; set; }
        public double TasaInteresAnual { get; set; }
        public double MontoCuota { get; set; }
        public int CantCuotas { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public Persona Cliente { get; set; }
        public Persona Empleado { get; set; }
        #endregion
    }
}
