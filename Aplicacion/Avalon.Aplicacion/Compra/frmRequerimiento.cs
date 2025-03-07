using Avalon.Aplicacion.Ayuda;
using Avalon.Utiles;
using Avalon.ViewModel.Compra;
using DevExpress.DirectX.NativeInterop.DirectWrite.CCW;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avalon.Aplicacion.Compra
{
    public partial class frmRequerimiento: AvalonForm
    {
        DataTable cc;
        DataTable scc;
        DataTable sscc;
        BindingList<requerimientoViewModel> source = new BindingList<requerimientoViewModel>();
        public frmRequerimiento()
        {
            InitializeComponent();
            gcData.DataSource = source;
        }

        private void sbGuardar_Click(object sender, EventArgs e)
        {

        }

        private async void frmRequerimiento_Load(object sender, EventArgs e)
        {
            await CargarDatos();
        }

        private async Task CargarDatos()
        {
            try
            {
                var datos = await HelperApi.ExecuteGet<DataSet>($"{Constante.REQUERIMIENTO}/datosIniciales");
                cc = datos.Tables[0];
                scc = datos.Tables[1];
                sscc = datos.Tables[2];
                var area = datos.Tables[3];
                var numeriacion = datos.Tables[4];


                var codRQ = numeriacion.Rows[0]["numero"].ToString();
                teCodigoRQ.Text = codRQ;
                lueCC.Properties.DataSource = cc;
                lueCC.Properties.DisplayMember = "nombre";
                lueCC.Properties.ValueMember = "id";
                lueCC.SelectedIndex("id");
                lueArea.Properties.DataSource = area;
                lueArea.Properties.DisplayMember = "nombre";
                lueArea.Properties.ValueMember = "id";
                lueArea.SelectedIndex("id");

                teSolicitante.Text = Global.nombreUsuario;
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private void lueCC_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var idCC = Convert.ToInt32(lueCC.EditValue);
                var sourceSCC = scc.Select($"idCentroCostos={idCC}");
                if (sourceSCC.Count() > 0)
                {
                    var datos = sourceSCC.CopyToDataTable();
                    lueSCC.Properties.DataSource = datos;
                    lueSCC.Properties.DisplayMember = "nombre";
                    lueSCC.Properties.ValueMember = "id";
                    lueSCC.SelectedIndex("id");
                }
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private void lueSCC_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var idCC = Convert.ToInt32(lueCC.EditValue);
                var idSCC = Convert.ToInt32(lueSCC.EditValue);
                var sourceSSCC = sscc.Select($"idSubCentroCostos={idSCC} and idCentroCostos={idCC}");
                if (sourceSSCC.Count() > 0)
                {
                    var datos = sourceSSCC.CopyToDataTable();
                    lueSSCC.Properties.DataSource = datos;
                    lueSSCC.Properties.DisplayMember = "nombre";
                    lueSSCC.Properties.ValueMember = "id";
                    lueSSCC.SelectedIndex("id");
                }
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private void sbAddItem_Click(object sender, EventArgs e)
        {

        }
    }
}
