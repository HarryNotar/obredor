using Interfaz.Escritorio.Mensajes;
using Negocio.Entidades;
using Negocio.Logica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Interfaz.Escritorio.Forms_Vehiculo.AB_Color
{
    public partial class FormEliminarColor : Form
    {
        private LogicaColor logicaColor;
    

        public FormEliminarColor()
        {
            InitializeComponent();

            logicaColor = new LogicaColor();

            CargarColores();
            
            cmb_color.DisplayMember = "Nombre";
        }


        private void CargarColores()
        {
            try
            {
                cmb_color.DataSource = logicaColor.GetTodosColores();
            }
            catch (Exception ex)
            {
                Notificador.NotificarErrorInesperado(ex);
            }
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }


        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (cmb_color.SelectedItem != null)
            {
                try
                {
                    logicaColor.EliminarColor((Color)cmb_color.SelectedItem);
                    
                    Notificador.NotificarOperacionRealizada();

                    CargarColores();
                }
                catch (Exception ex)
                {
                    Notificador.NotificarErrorInesperado(ex);
                }
            }
            else
            {
                Notificador.NotificarAdvertencia(Notificador.TipoDato.Color);
            }
        }
    }
}
