using System;


namespace Negocio.Entidades
{
    public class Estado
    {
        public enum TiposEstado { Disponible, Vendido }

        #region Propiedades
        public int IdVehiculo { get; set; }
        public TiposEstado TipoEstado { get; set; }
        public DateTime Fecha { get; set; }
        #endregion
    }
}
