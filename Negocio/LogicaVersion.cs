using System;
using Datos;


namespace Negocio.Logica
{
    public class LogicaVersion
    {
        private DatosVersion datosVersion;


        public LogicaVersion()
        {
            datosVersion = new DatosVersion();
        }


        // CORROBORADO
        public void RegistrarVersion(Entidades.Version versionNueva)
        {
            try
            {
                if (!datosVersion.VersionYaRegistrada(versionNueva))
                {
                    datosVersion.RegistrarVersion(versionNueva);
                }
                else
                {
                    Exception excepcionVersionYaRegistrada = new Exception("La versión que intenta registrar ya se encuentra registrada.");
                    throw excepcionVersionYaRegistrada;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public void EliminarVersion(Entidades.Version versionAeliminar)
        {
            try
            {
                datosVersion.EliminarVersion(versionAeliminar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
