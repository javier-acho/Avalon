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
    public partial class frmSubCentroCostos: AvalonFormCRUD
    {
        int idCC;
        public frmSubCentroCostos(int idCC)
        {
            InitializeComponent();
            this.idCC = idCC;
        }

        private void sbAgregar_Click(object sender, EventArgs e)
        {
            var frm = new frmSubCentroCostosAgregar(idCC,"C");
            frm.FormClosed += Frm_FormClosed;
            frm.MdiParent = this.MdiParent;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();
        }

        private async void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            await CargarDatos();
        }

        private async void frmSubCentroCostos_Load(object sender, EventArgs e)
        {
            await CargarDatos();
        }
        private async Task CargarDatos()
        {
            try
            {
                var lsta = await Utiles.HelperApi.ExecuteGet<List<subCentroCostosViewModel>>($"{Constante.SUB_CENTRO_COSTO}/byCC/{idCC}");
                gcData.DataSource = lsta;
                gvData.BestFitColumns();
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private void sbModificar_Click(object sender, EventArgs e)
        {
            AvalonForm frm = null;
            var fila = (subCentroCostosViewModel)gvData.GetRow(gvData.FocusedRowHandle);
            frm = new frmSubCentroCostosAgregar(fila.idCentroCostos, "M", fila.id);

            frm.FormClosed += Frm_FormClosed;
            frm.MdiParent = this.MdiParent;
            frm.FormBorderStyle = this.FormBorderStyle;
            frm.Show();
        }
    }
}
