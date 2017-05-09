using System;
using System.Collections.Generic;


namespace Negocio.Entidades
{
    public class Vehiculo
    {   
        #region Propiedades
        public String NroMotor { get; set; }
        public String NroChasis { get; set; }
        public String Dominio { get; set; }
        public String Observaciones { get; set; }
        public Color Color { get; set; }
        public Version Version { get; set; }
        public int AñoPatentamiento { get; set; }
        public int IdVehiculo { get; set; }
        public int Kilometraje { get; set; }
        public double ValorAdquisicion { get; set; }
        public double ValorVenta { get; set; }
        public bool EsUsado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public Estado Estado { get; set; }
        #endregion
    }
}
