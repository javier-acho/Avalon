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
    public partial class frmSocioNegocioAgregar : AvalonForm
    {
        string prefijo = "";
        string tipoEvento = "";
        int idSocioNegocio;
        public frmSocioNegocioAgregar(string tipoEvento,int idSocioNegocio = -1)
        {
            InitializeComponent();
            //teCodigoProveedor.Text = "P";
            this.tipoEvento = tipoEvento;
            this.idSocioNegocio = idSocioNegocio;
        }

        private void teNroDocumentoIdentidad_TextChanged(object sender, EventArgs e)
        {
            teCodigoProveedor.Text = prefijo+teNroDocumentoIdentidad.Text;
        }

        private async void frmProveedorAgregar_Load(object sender, EventArgs e)
        {
            if (tipoEvento == "M")
            {
                sbGuardar.Text = "Modificar";
                CargarDatos(idSocioNegocio);
            }
            await CargarDatosIniciales();
        }

        private async void CargarDatos(int idSocioNegocio)
        {
            try
            {
                var modelo= await Utiles.HelperApi.ExecuteGet<socioNegocioViewModel>(Constante.SOCIO_NEGOCIO_GET_UN+$"/{idSocioNegocio}");

                cbTipoSocio.SelectedIndex = modelo.tipoSocio == "C" ? 0 : 1;
                teCodigoProveedor.Text = modelo.codigoSocio;
                cbGrupoProveedor.SelectedIndex = modelo.grupoSocio == "N" ? 0 : 1;
                lueTipoDocIdentidad.EditValue = modelo.idTipoDocumento;
                teNroDocumentoIdentidad.Text = modelo.nroDocumento;
                teRazonSocial.Text = modelo.razonSocial;
                teTelefono1.Text = modelo.telefono1;
                teTelefono2.Text = modelo.telefono2;
                teEmail.Text = modelo.email;
                teDireccionFiscal.Text = modelo.direccionFiscal;
                teDireccionAlternativa.Text = modelo.direccionAlternativa;
                lueCondicionPago.EditValue = modelo.idCondicionPago;
                teCta1.Text = modelo.cuentaCorriente1;
                teCta2.Text = modelo.cuentaCorriente2;
                chkActivo.Checked = modelo.estado.Value;
                teNomContacto1.Text = modelo.contacto1;
                teNomContacto2.Text = modelo.contacto2;
                teNomContacto3.Text = modelo.contacto3;
                teTelfContacto1.Text = modelo.telefonoContacto1;
                teTelfContacto2.Text = modelo.telefonoContacto2;
                teTelfContacto3.Text = modelo.telefonoContacto3;
                teEmailContacto1.Text = modelo.emailContacto1;
                teEmailContacto2.Text = modelo.emailContacto2;
                teEmailContacto3.Text = modelo.emailContacto3;
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
                prefijo = cbTipoSocio.SelectedIndex == 0 ? "C" : "P";

                var datos = await Utiles.HelperApi.ExecuteGet<DataSet>(Constante.DATOS_SOCIO_NEGOCIO);
                
                var dtCondicionPagp = datos.Tables[0];
                lueCondicionPago.Properties.DataSource = dtCondicionPagp;
                lueCondicionPago.Properties.ValueMember = "id";
                lueCondicionPago.Properties.DisplayMember = "nombre";
                if(dtCondicionPagp.Rows.Count>0)
                {
                    var id = dtCondicionPagp.Rows[0]["id"];
                    lueCondicionPago.EditValue = id;
                }

                var dtTipodoc = datos.Tables[1];
                lueTipoDocIdentidad.Properties.DataSource = dtTipodoc;
                lueTipoDocIdentidad.Properties.ValueMember = "id";
                lueTipoDocIdentidad.Properties.DisplayMember = "nombre";
                if(dtTipodoc.Rows.Count>0)
                {
                    var id = dtTipodoc.Rows[0]["id"];
                    lueTipoDocIdentidad.EditValue = id;
                }
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
                socioNegocioViewModel modelo = new socioNegocioViewModel();
                modelo.tipoSocio = cbTipoSocio.SelectedIndex == 0 ? "C" : "P";
                modelo.codigoSocio = teCodigoProveedor.Text;
                modelo.grupoSocio = cbGrupoProveedor.SelectedIndex == 0 ? "N" : "E";
                modelo.idTipoDocumento = Convert.ToInt32(lueTipoDocIdentidad.EditValue);
                modelo.nroDocumento = teNroDocumentoIdentidad.Text;
                modelo.razonSocial = teRazonSocial.Text;
                modelo.telefono1 = teTelefono1.Text;
                modelo.telefono2 = teTelefono2.Text;
                modelo.email = teEmail.Text;
                modelo.direccionFiscal = teDireccionFiscal.Text;
                modelo.direccionAlternativa = teDireccionAlternativa.Text;
                modelo.idCondicionPago = Convert.ToInt32(lueCondicionPago.EditValue);
                modelo.cuentaCorriente1 = teCta1.Text;
                modelo.cuentaCorriente2 = teCta2.Text;
                modelo.estado = chkActivo.Checked;
                modelo.contacto1 = teNomContacto1.Text;
                modelo.contacto2 = teNomContacto2.Text;
                modelo.contacto3 = teNomContacto3.Text;
                modelo.telefonoContacto1 = teTelfContacto1.Text;
                modelo.telefonoContacto2 = teTelfContacto2.Text;
                modelo.telefonoContacto3 = teTelfContacto3.Text;
                modelo.emailContacto1 = teEmailContacto1.Text;
                modelo.emailContacto2 = teEmailContacto2.Text;
                modelo.emailContacto3 = teEmailContacto3.Text;
                if (tipoEvento == "C")
                {
                    var salida = await Utiles.HelperApi.Execute<socioNegocioViewModel, socioNegocioViewModel>(Constante.SOCIO_NEGOCIO, "post", modelo);
                }
                else
                {
                    modelo.id = idSocioNegocio;
                    var salida = await Utiles.HelperApi.Execute<socioNegocioViewModel, socioNegocioViewModel>(Constante.SOCIO_NEGOCIO, "put", modelo);
                }
                Mensaje("Se grabo con exito");
                Limpiar();
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private void Limpiar()
        {
            teCodigoProveedor.Limpiar();
            teRazonSocial.Limpiar();
            teNroDocumentoIdentidad.Limpiar();
            teTelefono1.Limpiar();
            teTelefono2.Limpiar();
            teEmail.Limpiar();
            teCta1.Limpiar();
            teCta2.Limpiar();
            teDireccionFiscal.Limpiar();
            teDireccionAlternativa.Limpiar();
            teEmailContacto1.Limpiar();
            teEmailContacto2.Limpiar();
            teEmailContacto3.Limpiar();
            teNomContacto1.Limpiar();
            teNomContacto2.Limpiar();
            teNomContacto3.Limpiar();
            teTelfContacto1.Limpiar();
            teTelfContacto2.Limpiar();
            teTelfContacto3.Limpiar();
        }

        private void cbTipoSocio_SelectedIndexChanged(object sender, EventArgs e)
        {
            prefijo = cbTipoSocio.SelectedIndex == 0 ? "C" : "P";
        }

        
    }
}
