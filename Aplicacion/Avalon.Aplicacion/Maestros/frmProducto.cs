using Avalon.Utiles;
using Avalon.ViewModel.Maestros;
using DevExpress.XtraGrid.Columns;
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
                    CrearColumnas();
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

        private void CrearColumnas()
        {
            gvData.Columns.Clear();
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Codigo";
            this.gridColumn1.FieldName = "codigoServicio";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nombre";
            this.gridColumn2.FieldName = "nombreServicio";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Para Venta";
            this.gridColumn9.FieldName = "esParaVenta";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.OptionsColumn.ReadOnly = true;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Para Compra";
            this.gridColumn10.FieldName = "esParaCompra";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.OptionsColumn.ReadOnly = true;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 9;

            gvData.Columns.AddRange(new GridColumn[] { gridColumn1, gridColumn2, gridColumn9, gridColumn10 });
        }

        private async void sbAgregar_Click(object sender, EventArgs e)
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
            frm.FormClosed += Frm_FormClosed;
            frm.MdiParent = this.MdiParent;
            frm.FormBorderStyle = this.FormBorderStyle;
            frm.Show();
        }

        private async void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            await CargarDatos();
        }

        private void sbModificar_Click(object sender, EventArgs e)
        {
            AvalonForm frm = null;
            if (tipo == "P")
            {
                var fila = (productoViewModel)gvData.GetRow(gvData.FocusedRowHandle);
                frm = new frmProductoAgregar("M",fila.id);
            }
            else
            {
                var fila = (servicioViewModel)gvData.GetRow(gvData.FocusedRowHandle);
                frm = new frmServicioAgregar("M", fila.id);
            }
            frm.FormClosed += Frm_FormClosed;
            frm.MdiParent = this.MdiParent;
            frm.FormBorderStyle = this.FormBorderStyle;
            frm.Show();
        }
    }
}
