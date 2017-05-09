using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Entidades;
using Negocio.Logica;
using Interfaz.Escritorio.Mensajes;
using Utilidades;

namespace Interfaz.Escritorio.Forms_Vehiculo.AB_Modelo
{
    public partial class FormRegistrarModelo : Form
    {
        private LogicaModelo logicaModelo;


        public FormRegistrarModelo()
        {
            InitializeComponent();

            logicaModelo = new LogicaModelo();
        }


        // CORROBORAR
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Modelo modeloNuevo = new Modelo();

            modeloNuevo.Nombre = FormateadorTexto.FormatearTexto(txt_nombre.Text);

            modeloNuevo.Marca = (Marca) cmb_marca.SelectedItem;


            if (txt_nombre.Text.Trim() != "")
            {
                try
                {
                    logicaModelo.RegistrarModelo(modeloNuevo);
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



        private void frm_registrarModelo_Load(object sender, EventArgs e)
        {
            cmb_marca.DisplayMember = "Nombre";
        }



        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



        public void SetListaMarcas(List<Marca> listaMarcas)
        {
            cmb_marca.DataSource = listaMarcas;
        }


        public void SetMarcaActual(Marca marcaActual)
        {
            cmb_marca.SelectedItem = marcaActual;
        }
    }
}
