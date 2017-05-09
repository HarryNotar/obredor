using Interfaz.Escritorio.Mensajes;
using Negocio.Entidades;
using Negocio.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz.Escritorio.Forms_Vehiculo.AB_Marca
{
    public partial class FormEliminarMarca : Form
    {
        private LogicaMarca logicaMarca;


        public FormEliminarMarca()
        {
            InitializeComponent();

            logicaMarca = new LogicaMarca();

            CargarMarcas();

            cmb_marca.DisplayMember = "Nombre";
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }


        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (cmb_marca.SelectedItem != null)
            {
                try
                {
                    logicaMarca.EliminarMarca((Marca)cmb_marca.SelectedItem);

                    Notificador.NotificarOperacionRealizada();

                    CargarMarcas();
                }
                catch (Exception ex)
                {
                    Notificador.NotificarErrorInesperado(ex);
                }
            }
            else
            {
                Notificador.NotificarAdvertencia(Notificador.TipoDato.Marca);
            }
        }


        private void CargarMarcas()
        {
            try
            {
                cmb_marca.DataSource = logicaMarca.GetTodasMarcas();
            }
            catch (Exception ex)
            {
                Notificador.NotificarErrorInesperado(ex);
            }
        }
    }
}
