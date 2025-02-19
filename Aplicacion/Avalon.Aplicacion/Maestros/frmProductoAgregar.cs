using Avalon.Aplicacion.Ayuda;
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
    public partial class frmProductoAgregar : AvalonForm
    {
        string tipoEvento = "";
        int idProducto;

        DataTable clase, subClase, subSubClase;
        public frmProductoAgregar(string tipoEvento, int idProducto=-1)
        {
            InitializeComponent();
            this.tipoEvento = tipoEvento;
            this.idProducto = idProducto;
        }

        private async void frmProductoAgregar_Load(object sender, EventArgs e)
        {
            if (tipoEvento == "M")
            {
                sbGuardar.Text = "Modificar";
                CargarDatos(idProducto);
            }
            await CargarDatosIniciales();
        }

        private void CargarDatos(object idSocioNegocio)
        {
            throw new NotImplementedException();
        }

        private async Task CargarDatosIniciales()
        {
            try
            {
                string url = $"{Utiles.Constante.PRODUCTO}/DatosIniciales";
                var salida = await Utiles.HelperApi.ExecuteGet<DataSet>($"{url}");
                clase = salida.Tables["cl"];
                subClase = salida.Tables["scl"];
                subSubClase = salida.Tables["sscl"];

                lueClase.Properties.DataSource = clase;
                lueClase.Properties.ValueMember = "id";
                lueClase.Properties.DisplayMember = "nombre";

                lueClase.SelectedIndex("id");
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private void lueClase_EditValueChanged(object sender, EventArgs e)
        {
            if (lueClase.EditValue == null)
                return;
            var idClase = Convert.ToInt32(lueClase.EditValue);
            var filas = subClase.Select($"idClase={idClase}");
            if (filas.Count() > 0)
            {
                var dt = filas.CopyToDataTable();

                lueSubClase.Properties.DataSource = dt;
                lueSubClase.Properties.ValueMember = "id";
                lueSubClase.Properties.DisplayMember = "nombre";
                lueSubClase.SelectedIndex("id");
            }

        }

        private void sbGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                productoViewModel modelo = new productoViewModel();
                modelo.codigoProducto = teCodigoProducto.Text;
                modelo.codigoCliente = teCodComercial.Text;
                modelo.nombreProducto = teNombreProducto.Text;
                modelo.ubicacion = teUbicacion.Text;
                modelo.idUnidadMedida = Convert.ToInt32(lueUM.EditValue);
                modelo.esParaCompra = chkCompra.Checked;
                modelo.esParaVenta = chkVenta.Checked;
                modelo.idClase = Convert.ToInt32(lueClase.EditValue);
                modelo.idSubClase = Convert.ToInt32(lueSubClase.EditValue);
                modelo.idSubSubClase = Convert.ToInt32(lueSubSubClase.EditValue);


            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private void lueSubSubClase_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lueSubClase_EditValueChanged(object sender, EventArgs e)
        {
            if (lueClase.EditValue == null)
                return;
            var idClase = Convert.ToInt32(lueClase.EditValue);
            var idSubClase = Convert.ToInt32(lueSubClase.EditValue);
            var filas = subSubClase.Select($"idClase={idClase} and idSubClase={idSubClase}");
            if (filas.Count() > 0)
            {
                var dt = filas.CopyToDataTable();
                lueSubSubClase.Properties.DataSource = dt;
                lueSubSubClase.Properties.ValueMember = "id";
                lueSubSubClase.Properties.DisplayMember = "nombre";
                lueSubSubClase.SelectedIndex("id");
            }
        }
    }
}
