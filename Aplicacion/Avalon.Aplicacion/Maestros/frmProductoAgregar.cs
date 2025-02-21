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
    public partial class frmProductoAgregar : AvalonForm
    {
        string tipoEvento = "";
        int idProducto;

        DataTable clase, subClase, subSubClase;
        DataTable familia, subFamilia;
        DataTable um;
        public frmProductoAgregar(string tipoEvento, int idProducto=-1)
        {
            InitializeComponent();
            this.tipoEvento = tipoEvento;
            this.idProducto = idProducto;
        }

        private async void frmProductoAgregar_Load(object sender, EventArgs e)
        {
            await CargarDatosIniciales();

            if (tipoEvento == "M")
            {
                sbGuardar.Text = "Modificar";
                await CargarDatos(idProducto);
            }
            
        }

        private async Task CargarDatos(int idProducto)
        {
            try
            {
                string urlApi = $"{Constante.PRODUCTO}/GetUnById/{idProducto}";
                var modelo = await HelperApi.ExecuteGet<productoViewModel>(urlApi);

                teCodigoProducto.Text = modelo.codigoProducto;
                teCodComercial.Text = modelo.codigoCliente;
                teNombreProducto.Text = modelo.nombreProducto;
                teUbicacion.Text = modelo.ubicacion;
                lueUM.EditValue = (long)modelo.idUnidadMedida.Value;
                chkCompra.Checked = modelo.esParaCompra.Value;
                chkVenta.Checked = modelo.esParaVenta.Value;
                lueClase.EditValue = (long)modelo.idClase.Value;
                lueSubClase.EditValue = (long)modelo.idSubClase.Value;
                lueSubSubClase.EditValue = (long)modelo.idSubSubClase.Value;
                lueFamilia.EditValue = (long)modelo.idFamilia.Value;
                lueSubFamilia.EditValue = (long)modelo.idSubFamilia.Value;
                meComentarios.Text = modelo.descripcionProducto;
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private async Task CargarDatosIniciales()
        {
            try
            {
                string url = $"{Utiles.Constante.PRODUCTO}/DatosIniciales";
                //var salida = AsyncHelpers.RunSync<DataSet>(() => Utiles.HelperApi.ExecuteGet<DataSet>($"{url}"));
                var salida = await Utiles.HelperApi.ExecuteGet<DataSet>($"{url}");
                clase = salida.Tables["cl"];
                subClase = salida.Tables["scl"];
                subSubClase = salida.Tables["sscl"];

                familia = salida.Tables["fam"];
                subFamilia = salida.Tables["sfam"];

                um = salida.Tables["um"];

                lueClase.Properties.DataSource = clase;
                lueClase.Properties.ValueMember = "id";
                lueClase.Properties.DisplayMember = "nombre";

                lueFamilia.Properties.DataSource = familia;
                lueFamilia.Properties.ValueMember = "id";
                lueFamilia.Properties.DisplayMember = "nombre";

                lueUM.Properties.DataSource = um;
                lueUM.Properties.ValueMember = "id";
                lueUM.Properties.DisplayMember = "nombre";

                lueClase.SelectedIndex("id");
                lueFamilia.SelectedIndex("id");
                lueUM.SelectedIndex("id");
                
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

        private void lueFamilia_EditValueChanged(object sender, EventArgs e)
        {
            if (lueFamilia.EditValue == null)
                return;
            var idFamilia = Convert.ToInt32(lueFamilia.EditValue);
            var filas = subFamilia.Select($"idFamilia={idFamilia}");
            if (filas.Count() > 0)
            {
                var dt = filas.CopyToDataTable();

                lueSubFamilia.Properties.DataSource = dt;
                lueSubFamilia.Properties.ValueMember = "id";
                lueSubFamilia.Properties.DisplayMember = "nombre";
                lueSubFamilia.SelectedIndex("id");
            }
        }

        private async void sbGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
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
                modelo.idFamilia = Convert.ToInt32(lueFamilia.EditValue);
                modelo.idSubFamilia = Convert.ToInt32(lueSubFamilia.EditValue);
                modelo.descripcionProducto = meComentarios.Text;
                if(tipoEvento=="M")
                {
                    modelo.id = idProducto;
                    var respuesta = await Utiles.HelperApi.Execute<productoViewModel, productoViewModel>(Constante.PRODUCTO, "put", modelo);
                }
                else
                { 
                    var respuesta = await Utiles.HelperApi.Execute<productoViewModel, productoViewModel>(Constante.PRODUCTO, "post", modelo);
                }
                Mensaje("Se registro con exito");
                Limpiar();
                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private void Limpiar()
        {
            teCodComercial.Limpiar();
            teCodigoProducto.Limpiar();
            teNombreProducto.Limpiar();
            teUbicacion.Limpiar();
            meComentarios.Limpiar();
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
