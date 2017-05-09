using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    // Clase estática - NO REQUIERE INSTANCIAR
    public static class GeneradorContraseñas
    {
        public static String GenerarContraseña()
        {
            Random random = new Random();
            string posibles = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"; 
            int longitud = posibles.Length;
            char letra;
            int longitudNuevaCadena = 8;
            string nuevacadena = "";

            for (int i = 0; i < longitudNuevaCadena; i++)
            {
               letra = posibles[random.Next(longitud)];
               nuevacadena += letra.ToString();
            }

            return nuevacadena;
        }
    }
}
