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

namespace Interfaz.Escritorio.Forms_Vehiculo.AB_Version
{
    public partial class FormEliminarVersion : Form
    {
        private LogicaMarca logicaMarca;
        private LogicaVersion logicaVersion;


        public FormEliminarVersion()
        {
            InitializeComponent();

            logicaMarca = new LogicaMarca();
            logicaVersion = new LogicaVersion();

            CargarMarcasModelosVersiones();

            cmb_modelo.DisplayMember = "Nombre";
            cmb_marca.DisplayMember = "Nombre";
            cmb_version.DisplayMember = "Nombre";
        }


        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }


        private void cmb_marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            Marca marcaSeleccionada = (Marca)cmb_marca.SelectedItem;
            cmb_modelo.DataSource = marcaSeleccionada.ListaModelos;
        }


        private void cmb_modelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Modelo modeloSeleccionado = (Modelo)cmb_modelo.SelectedItem;
            cmb_version.DataSource = modeloSeleccionado.ListaVersiones;
        }


        private void CargarMarcasModelosVersiones()
        {
            List<Marca> listaMarcas = new List<Marca>();

            try
            {
                listaMarcas = logicaMarca.GetTodasMarcas();

                // Asignar la lista de marcas como DataSource del cmb_marca
                cmb_marca.DataSource = listaMarcas;

                // Si la lista de marcas no está vacia
                if (listaMarcas.Count != 0)
                {
                    // Obtener la marca seleccionada en el comboBox           
                    Marca marcaSeleccionada = (Marca)cmb_marca.SelectedItem;
                    // Asignar la lista de modelos de la marca seleccionada como DataSource del cmb_modelos
                    cmb_modelo.DataSource = marcaSeleccionada.ListaModelos;

                    // Si la lista de modelos no esta vacía
                    if (marcaSeleccionada.ListaModelos.Count != 0)
                    {
                        // Obtener el modelo seleccionado en el comboBox
                        Modelo modeloSeleccionado = (Modelo)cmb_modelo.SelectedItem;
                        // Asignar la lista de versiones del modelo seleccionado como DataSource del cmb_versiones
                        cmb_version.DataSource = modeloSeleccionado.ListaVersiones;
                    }
                }
            }
            catch (Exception ex)
            {
                Notificador.NotificarErrorInesperado(ex);
            }
        }


        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (ValidarMarcaModeloVersion())
            {
                try
                {
                    logicaVersion.EliminarVersion((Negocio.Entidades.Version)cmb_version.SelectedItem);

                    Notificador.NotificarOperacionRealizada();

                    CargarMarcasModelosVersiones();
                }
                catch (Exception ex)
                {
                    Notificador.NotificarErrorInesperado(ex);
                }
            }
        }


        private bool ValidarMarcaModeloVersion()
        {
            bool opCorrecta = false;

            if (cmb_marca.SelectedItem != null)
            {
                if (cmb_modelo.SelectedItem != null)
                {
                    if (cmb_version.SelectedItem != null)
                    {
                        opCorrecta = true;
                    }
                    else
                    {
                        Notificador.NotificarAdvertencia(Notificador.TipoDato.Version);
                    }
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
    }
}
