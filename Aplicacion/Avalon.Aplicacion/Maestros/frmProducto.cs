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
    public partial class frmProducto : AvalonFormCRUD
    {
        string tipo = "";
        public frmProducto(string tipo)
        {
            InitializeComponent();
            this.tipo = tipo;
            if (tipo == "P")
            {
                this.Text = "Producto";
            }
            else
            {
                this.Text = "Servicio";
            }
        }

        private async void frmProducto_Load(object sender, EventArgs e)
        {
            await CargarDatos();
        }
        private async Task CargarDatos()
        {
            try
            {
                if (tipo == "P")
                {
                    var salida = await Utiles.HelperApi.ExecuteGet<List<productoViewModel>>($"{Utiles.Constante.PRODUCTO}");
                    gcData.DataSource = salida;
                    gvData.BestFitColumns();
                }
                else
                {
                    var salida = await Utiles.HelperApi.ExecuteGet<List<servicioViewModel>>($"{Utiles.Constante.SERVICIO}");
                    gcData.DataSource = salida;
                    gvData.BestFitColumns();
                }
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private void sbAgregar_Click(object sender, EventArgs e)
        {
            AvalonForm frm = null;
            if (tipo=="P")
            {
                frm = new frmProductoAgregar("C");
            }
            else
            {
                frm = new frmServicioAgregar("C");
            }
            frm.MdiParent = this.MdiParent;
            frm.FormBorderStyle = this.FormBorderStyle;
            frm.Show();
        }
    }
}
