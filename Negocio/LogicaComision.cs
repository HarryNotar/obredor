using Datos;
using Negocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Logica
{
    public class LogicaComision
    {
        private DatosComision datosComision;


        public LogicaComision()
        {
            datosComision = new DatosComision();
        }



        public Comision GetComisionActual()
        {
            Comision comisionActual = null;

            try
            {
                comisionActual = datosComision.GetComisionActual();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return comisionActual;
        }



        public void RegistrarComision(Comision comisionNueva)
        {
            comisionNueva.Fecha = DateTime.Now;

            try
            {
                datosComision.RegistrarComision(comisionNueva);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
