using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class Modelo
    {
        #region Propiedades
        public String Nombre { get; set; }
        public int IdModelo { get; set; }
        public List<Version> ListaVersiones { get; set; }
        public Marca Marca { get; set; }
        #endregion
    }
}
