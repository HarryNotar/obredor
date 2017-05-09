using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    // Clase estática - NO REQUIERE INSTANCIAR
    public static class ConnString
    {
        static public String GetConnectionString()
        {
             //return "Data Source=ARACELI;Initial Catalog=TP2_NET;Integrated Security=True";
             return "Data Source=DESKTOP-6CC93TF; Initial Catalog=Proyecto_Obredor;Integrated Security=True"; // cadena para pc harry
           // return "Data Source=NESTY-NOTEBOOK;Initial Catalog=TP2_NET;Integrated Security=True;"; // Cadena para compu del Nesty
        }

    }
}
