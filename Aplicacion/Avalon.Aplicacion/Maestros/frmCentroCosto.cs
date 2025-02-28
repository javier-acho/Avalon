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
    public partial class frmCentroCosto : AvalonFormCRUD
    {
        public frmCentroCosto()
        {
            InitializeComponent();
        }

        private void sbAgregar_Click(object sender, EventArgs e)
        {
            var frm = new frmCentroCostoAgregar("C");
            frm.FormClosed += Frm_FormClosed;
            frm.MdiParent = this.MdiParent;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();
        }

        private async void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            await CargarDatos();
        }

        private async void frmCentroCosto_Load(object sender, EventArgs e)
        {
            await CargarDatos();
        }

        private async Task CargarDatos()
        {
            try
            {
                var lsta = await Utiles.HelperApi.ExecuteGet<List<centroCostosViewModel>>(Constante.CENTRO_COSTO);
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
            var fila = (centroCostosViewModel)gvData.GetRow(gvData.FocusedRowHandle);
            frm = new frmProductoAgregar("M", fila.id);

            frm.FormClosed += Frm_FormClosed;
            frm.MdiParent = this.MdiParent;
            frm.FormBorderStyle = this.FormBorderStyle;
            frm.Show();
        }
    }
}
