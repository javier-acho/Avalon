using Avalon.Aplicacion.Ayuda;
using Avalon.Utiles;
using Avalon.ViewModel.Maestros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avalon.Aplicacion.Maestros
{
    public partial class frmSubCentroCostosAgregar: AvalonForm
    {
        string tipoEvento;
        int idSCC;
        int idCC;
        public frmSubCentroCostosAgregar(int idCC, string tipoEvento, int idSCC = -1)
        {
            InitializeComponent();
            this.tipoEvento = tipoEvento;
            this.idCC = idCC;
            if (tipoEvento == "M")
            {
                sbGuardar.Text = "Modificar";
                this.idSCC = idSCC;
            }
        }

        private async void sbGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                if (idSCC > 0)
                {
                    subCentroCostosViewModel cc = new subCentroCostosViewModel();
                    cc.id = idSCC;
                    cc.idCentroCostos = idCC;
                    cc.nombre = teNombre.Text;
                    cc.nombreCorto = teNombreCorto.Text;
                    cc.estado = true;

                    var salida = await Utiles.HelperApi.Execute<subCentroCostosViewModel, subCentroCostosViewModel>(Constante.SUB_CENTRO_COSTO, "put", cc);
                }
                else
                {
                    subCentroCostosViewModel cc = new subCentroCostosViewModel();
                    cc.idCentroCostos = idCC;
                    cc.nombre = teNombre.Text;
                    cc.nombreCorto = teNombreCorto.Text;
                    cc.estado = true;

                    var salida = await Utiles.HelperApi.Execute<subCentroCostosViewModel, subCentroCostosViewModel>(Constante.SUB_CENTRO_COSTO, "post", cc);
                }
                splashScreenManager1.CloseWaitForm();
                Mensaje("Se registro con éxito");
                Limpiar();

            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }
        private void Limpiar()
        {
            teNombre.Limpiar();
            teNombreCorto.Limpiar();
        }

        private async void frmSubCentroCostosAgregar_Load(object sender, EventArgs e)
        {
            if (tipoEvento == "M")
            {
                await CargarDatos();
            }
        }
        private async Task CargarDatos()
        {
            try
            {
                if (idSCC > 0)
                {
                    var cc = await Utiles.HelperApi.ExecuteGet<subCentroCostosViewModel>($"{Constante.SUB_CENTRO_COSTO}/{idSCC}");
                    teNombre.Text = cc.nombre;
                    teNombreCorto.Text = cc.nombreCorto;
                }
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }
    }
}
