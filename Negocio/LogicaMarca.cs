using System;
using System.Collections.Generic;
using Negocio.Entidades;
using Datos;

namespace Negocio.Logica
{
    public class LogicaMarca
    {
        private DatosMarca datosMarca;

        
        public LogicaMarca()
        {
            datosMarca = new DatosMarca();
        }


        // CORROBORADO
        public void RegistrarMarca(Marca marcaNueva)
        {            
            try
            {
                if(!datosMarca.MarcaYaRegistrada(marcaNueva))
                {
                    datosMarca.RegistrarMarca(marcaNueva);
                }
                else
                {
                    Exception excepcionMarcaYaRegistrada = new Exception("La marca que intenta registrar ya se encuentra registrada.");
                    throw excepcionMarcaYaRegistrada;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        // CORROBORADO
        public List<Marca> GetTodasMarcas()
        {
            List<Marca> listaMarcas = new List<Marca>();

            try
            {
                listaMarcas = datosMarca.GetTodasMarcas();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listaMarcas;
        }


        public void EliminarMarca(Marca marcaAeliminar)
        {
            try
            {
                datosMarca.EliminarMarca(marcaAeliminar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
