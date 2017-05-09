using System;
using System.Windows.Forms;
using Negocio.Entidades;
using Negocio.Logica;
using Interfaz.Escritorio.Mensajes;
using Utilidades;

namespace Interfaz.Escritorio.Forms_Vehiculo.AB_Marca
{
    public partial class FormRegistrarMarca : Form
    {
        private LogicaMarca logicaMarca;

        
        public FormRegistrarMarca()
        {
            InitializeComponent();

            logicaMarca = new LogicaMarca();
        }

        
        // CORROBORAR
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Marca marcaNueva = new Marca();

            marcaNueva.Nombre = FormateadorTexto.FormatearTexto(txt_nombre.Text);

            if (txt_nombre.Text.Trim() != "")
            {
                try
                {
                    logicaMarca.RegistrarMarca(marcaNueva);
                    Notificador.NotificarOperacionRealizada();
                    DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    Notificador.NotificarErrorInesperado(ex);
                }
            }
            else
            {
                Notificador.NotificarAdvertencia(Notificador.TipoDato.Nombre);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
