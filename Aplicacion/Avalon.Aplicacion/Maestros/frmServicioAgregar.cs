using Avalon.Aplicacion.Ayuda;
using Avalon.Utiles;
using Avalon.ViewModel.Maestros;
using System;
using System.Collections;
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
    public partial class frmServicioAgregar : AvalonForm
    {
        string tipoEvento = "";
        int idServicio;
        public frmServicioAgregar(string tipoEvento, int idServicio = -1)
        {
            InitializeComponent();
            this.tipoEvento = tipoEvento;
            this.idServicio = idServicio;
        }

        private async void frmServicioAgregar_Load(object sender, EventArgs e)
        {
            await CargarDatosIniciales();

            if (tipoEvento == "M")
            {
                sbGuardar.Text = "Modificar";
                await CargarDatos(idServicio);
            }
        }
        private async Task CargarDatos(object idServicio)
        {
            try
            {
                string urlApi = $"{Constante.SERVICIO}/GetUnById/{idServicio}";
                var modelo = await HelperApi.ExecuteGet<servicioViewModel>(urlApi);

                teCodigoServicio.Text = modelo.codigoServicio;
                teNombreServicio.Text = modelo.nombreServicio;
                chkCompra.Checked = modelo.esParaCompra.Value;
                chkVenta.Checked = modelo.esParaVenta.Value;
                meDescripcion.Text = modelo.descripcionServicio;
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
                //string url = $"{Utiles.Constante.PRODUCTO}/DatosIniciales";
                ////var salida = AsyncHelpers.RunSync<DataSet>(() => Utiles.HelperApi.ExecuteGet<DataSet>($"{url}"));
                //var salida = await Utiles.HelperApi.ExecuteGet<DataSet>($"{url}");
                //clase = salida.Tables["cl"];
                //subClase = salida.Tables["scl"];
                //subSubClase = salida.Tables["sscl"];

                //familia = salida.Tables["fam"];
                //subFamilia = salida.Tables["sfam"];

                //um = salida.Tables["um"];

                //lueClase.Properties.DataSource = clase;
                //lueClase.Properties.ValueMember = "id";
                //lueClase.Properties.DisplayMember = "nombre";

                //lueFamilia.Properties.DataSource = familia;
                //lueFamilia.Properties.ValueMember = "id";
                //lueFamilia.Properties.DisplayMember = "nombre";

                //lueUM.Properties.DataSource = um;
                //lueUM.Properties.ValueMember = "id";
                //lueUM.Properties.DisplayMember = "nombre";

                //lueClase.SelectedIndex("id");
                //lueFamilia.SelectedIndex("id");
                //lueUM.SelectedIndex("id");

            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private async void sbGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                servicioViewModel modelo = new servicioViewModel();
                modelo.codigoServicio = teCodigoServicio.Text;
                modelo.nombreServicio = teNombreServicio.Text;
   
                modelo.esParaCompra = chkCompra.Checked;
                modelo.esParaVenta = chkVenta.Checked;
                modelo.descripcionServicio = meDescripcion.Text;

                if (tipoEvento == "M")
                {
                    modelo.id = idServicio;
                    var respuesta = await Utiles.HelperApi.Execute<servicioViewModel, servicioViewModel>(Constante.SERVICIO, "put", modelo);
                }
                else
                {
                    var respuesta = await Utiles.HelperApi.Execute<servicioViewModel, servicioViewModel>(Constante.SERVICIO, "post", modelo);
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
            teCodigoServicio.Limpiar();
            teNombreServicio.Limpiar();
            meDescripcion.Limpiar();
        }
    }
}
