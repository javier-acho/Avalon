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
    public partial class frmSocioNegocio : AvalonFormCRUD
    {
        public frmSocioNegocio()
        {
            InitializeComponent();
            
        }

        private void sbAgregar_Click(object sender, EventArgs e)
        {
            frmSocioNegocioAgregar frm = new frmSocioNegocioAgregar("C");
            frm.MdiParent = this.MdiParent;
            frm.FormBorderStyle = this.FormBorderStyle;
            frm.Show();
        }

        private async void frmProveedor_Load(object sender, EventArgs e)
        {
            await CargarDatos();
        }

        private async Task CargarDatos()
        {
            try
            {
                var salida = await Utiles.HelperApi.ExecuteGet<List<socioNegocioViewModel>>($"{Utiles.Constante.SOCIO_NEGOCIO}/P");
                gcData.DataSource = salida;
                gvData.BestFitColumns();
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private void sbModificar_Click(object sender, EventArgs e)
        {
            var fila = (socioNegocioViewModel)gvData.GetRow(gvData.FocusedRowHandle);
            frmSocioNegocioAgregar frm = new frmSocioNegocioAgregar("M",fila.id);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void sbEliminar_Click(object sender, EventArgs e)
        {
        }
    }
}
