using Avalon.ViewModel.Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avalon.Aplicacion.Seguridad
{
    public partial class frmUsuario : AvalonFormCRUD
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sbAgregar_Click(object sender, EventArgs e)
        {
            frmCrearUsuario frm = new frmCrearUsuario("C");
            frm.MdiParent = this.MdiParent;
            frm.FormBorderStyle = this.FormBorderStyle;
            frm.Show();
        }

        private void sbModificar_Click(object sender, EventArgs e)
        {
            if (gvData.FocusedRowHandle < 0)
                return;
            var usuario = (UsuarioViewModel)gvData.GetRow(gvData.FocusedRowHandle);
            frmCrearUsuario frm = new frmCrearUsuario("M",usuario.nomUsu);
            frm.MdiParent = this.MdiParent;
            frm.FormBorderStyle = this.FormBorderStyle;
            frm.Show();
        }

        private async void frmUsuario_Load(object sender, EventArgs e)
        {
            await CargarDatos();
        }

        private async Task CargarDatos()
        {
            try
            {
                var salida = await Utiles.HelperApi.ExecuteGet<List<UsuarioViewModel>>($"{Utiles.Constante.USUARIO}/P");
                gcData.DataSource = salida;
                gvData.BestFitColumns();
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }
    }
}
