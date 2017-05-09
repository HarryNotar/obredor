using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Entidades
{
    public class Version
    {
        #region Propiedades
        public String Nombre { get; set; }
        public int IdVersion { get; set; }
        public Modelo Modelo { get; set; }
        #endregion
    }
}
