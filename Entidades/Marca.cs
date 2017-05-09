using System;
using System.Collections.Generic;


namespace Negocio.Entidades
{
    public class Marca
    {
        #region Propiedades
        public String Nombre { get; set; }
        public int IdMarca { get; set; }
        public List<Modelo> ListaModelos { get; set; }
        #endregion
    }
}
