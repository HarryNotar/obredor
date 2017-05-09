using System;
using System.Windows.Forms;
using Negocio.Entidades;
using Negocio.Logica;
using Interfaz.Escritorio.Mensajes;
using Utilidades;

namespace Interfaz.Escritorio.Forms_Vehiculo.AB_Color
{
    public partial class FormRegistrarColor : Form
    {
        private LogicaColor logicaColor;
        

        public FormRegistrarColor()
        {
            InitializeComponent();

            logicaColor = new LogicaColor();
        }



        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }


        // CORROBORADO
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Color colorNuevo = new Color();

            colorNuevo.Nombre = FormateadorTexto.FormatearTexto(txt_nombre.Text);
            
            if (txt_nombre.Text.Trim() != "")
            {
                try
                {
                    logicaColor.RegistrarColor(colorNuevo);
                    Notificador.NotificarOperacionRealizada();
                    DialogResult = DialogResult.OK;                
                }
                catch(Exception ex)
                {
                    Notificador.NotificarErrorInesperado(ex);
                }
            }
            else
            {
                Notificador.NotificarAdvertencia(Notificador.TipoDato.Nombre);
            }
        }
    }
}
