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

namespace Interfaz.Escritorio.Forms_Vehiculo.AB_Modelo
{
    public partial class FormEliminarModelo : Form
    {
        private LogicaMarca logicaMarca;
        private LogicaModelo logicaModelo;


        public FormEliminarModelo()
        {
            InitializeComponent();

            logicaMarca = new LogicaMarca();
            logicaModelo = new LogicaModelo();

            CargarMarcasModelos();

            cmb_modelo.DisplayMember = "Nombre";
            cmb_marca.DisplayMember = "Nombre";
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }


        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (ValidarMarcaModelo())
            {
                try
                {
                    logicaModelo.EliminarModelo((Modelo)cmb_modelo.SelectedItem);

                    Notificador.NotificarOperacionRealizada();

                    CargarMarcasModelos();
                }
                catch (Exception ex)
                {
                    Notificador.NotificarErrorInesperado(ex);
                }
            }
        }


        private bool ValidarMarcaModelo()
        {
            bool opCorrecta = false;

            if (cmb_marca.SelectedItem != null)
            {
                if (cmb_modelo.SelectedItem != null)
                {
                    opCorrecta = true;
                }
                else
                {
                    Notificador.NotificarAdvertencia(Notificador.TipoDato.Modelo);
                }
            }
            else
            {
                Notificador.NotificarAdvertencia(Notificador.TipoDato.Marca);
            }

            return opCorrecta;
        }


        private void CargarMarcasModelos()
        {
            List<Marca> listaMarcas = new List<Marca>();

            try
            {
                listaMarcas = logicaMarca.GetTodasMarcas();

                cmb_marca.DataSource = listaMarcas;

                if (listaMarcas.Count != 0)
                {
                    Marca marcaSeleccionada = (Marca)cmb_marca.SelectedItem;
                    cmb_modelo.DataSource = marcaSeleccionada.ListaModelos;
                }
            }
            catch (Exception ex)
            {
                Notificador.NotificarErrorInesperado(ex);
            }
        }


        private void cmb_marca_SelectedIndexChanged(object sender, EventArgs e)
        { 
            Marca marcaSeleccionada = (Marca)cmb_marca.SelectedItem;
            cmb_modelo.DataSource = marcaSeleccionada.ListaModelos;
        }
    }
}
