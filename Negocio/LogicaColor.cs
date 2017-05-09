using System;
using System.Collections.Generic;
using Negocio.Entidades;
using Datos;

namespace Negocio.Logica
{
    public class LogicaColor
    {
        private DatosColor datosColor;


        public LogicaColor()
        {
            datosColor = new DatosColor();
        }


        // CORROBORADO
        public void RegistrarColor(Color colorNuevo)
        {
            try
            {
                if (!datosColor.ColorYaRegistrado(colorNuevo))
                {
                    datosColor.RegistrarColor(colorNuevo);
                }
                else
                {
                    Exception excepcionColorYaRegistrado = new Exception("El color que intenta registrar ya se encuentra registrado.");
                    throw excepcionColorYaRegistrado;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        // CORROBORADO
        public List<Color> GetTodosColores()
        {
            List<Color> listaColores = new List<Color>();

            try
            {
                listaColores = datosColor.GetTodosColores();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listaColores;
        }


        public void EliminarColor(Color colorAeliminar)
        {
            try
            {
                datosColor.EliminarColor(colorAeliminar);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
