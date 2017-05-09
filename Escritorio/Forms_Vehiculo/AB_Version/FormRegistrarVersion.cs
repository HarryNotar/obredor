using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Negocio.Entidades;
using Negocio.Logica;
using Interfaz.Escritorio.Mensajes;
using Utilidades;

namespace Interfaz.Escritorio.Forms_Vehiculo.AB_Version
{
    public partial class FormRegistrarVersion : Form
    {
        #region Propiedades y Atributos

        private LogicaVersion logicaVersion;

        public List<Modelo> ListaModelos { get; set; }
        public List<Marca> ListaMarcas { get; set; }

        #endregion


        #region Constructor y Cargador
        public FormRegistrarVersion()
        {
            InitializeComponent();

            logicaVersion = new LogicaVersion();
            ListaModelos = new List<Modelo>();
            ListaMarcas = new List<Marca>();
        }

        private void frm_registrarVersion_Load(object sender, EventArgs e)
        {
            cmb_modelo.DisplayMember = "Nombre";
            cmb_marca.DisplayMember = "Nombre";
        }

        #endregion


        #region Comportamiento de botones y controles

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Negocio.Entidades.Version versionNueva = new Negocio.Entidades.Version();

            versionNueva.Nombre = FormateadorTexto.FormatearTexto(txt_nombre.Text);

            versionNueva.Modelo = (Modelo)cmb_modelo.SelectedItem;

            if (txt_nombre.Text.Trim() != "")
            {
                try
                {
                    logicaVersion.RegistrarVersion(versionNueva);
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


        private void cmb_marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cuando cambia la marca seleccionada cambia los modelos para mostrar los de dicha marca.
            if (cmb_marca.Items.Count != 0)
            {
                Marca marcaSeleccionada = (Marca)cmb_marca.SelectedItem;
                cmb_modelo.DataSource = marcaSeleccionada.ListaModelos;
            }
        }

        #endregion


        #region Seteadores de ComboBox

        public void SetListaModelos(List<Modelo> listaModelos)
        {
            cmb_modelo.DataSource = listaModelos;
        }


        public void SetListaMarcas(List<Marca> listaMarcas)
        {
            cmb_marca.DataSource = listaMarcas;
        }


        public void SetMarcaModeloActuales(Marca marcaActual, Modelo modeloActual)
        {
            cmb_marca.SelectedItem = marcaActual;
            cmb_modelo.SelectedItem = modeloActual;
        }


        #endregion

    }
}
