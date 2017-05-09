using System;
using System.Collections.Generic;
using Negocio.Entidades;
using Datos;


namespace Negocio.Logica
{
    public class LogicaModelo
    {
        private DatosModelo datosModelo;
  

        public LogicaModelo()
        {
            datosModelo = new DatosModelo();
        }


        // CORROBORADO
        public void RegistrarModelo(Modelo modeloNuevo)
        {
            try
            {
                if (!datosModelo.ModeloYaRegistrado(modeloNuevo))
                {
                    datosModelo.RegistrarModelo(modeloNuevo);
                }
                else
                {
                    Exception excepcionModeloYaRegistrado = new Exception("El modelo que intenta registrar ya se encuentra registrado.");
                    throw excepcionModeloYaRegistrado;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        // CORROBORADO
        public List<Modelo> GetTodosModelos(Marca marcaSeleccionada)
        {
            List<Modelo> listaModelos = new List<Modelo>();

            try
            {
                listaModelos = datosModelo.GetTodosModelos(marcaSeleccionada);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listaModelos;
        }


        public void EliminarModelo(Modelo modeloAeliminar)
        {
            try
            {
                datosModelo.EliminarModelo(modeloAeliminar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
