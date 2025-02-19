using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.ViewModel.Maestros
{
    public class socioNegocioViewModel
    {
        public int id { get; set; }
        public string tipoSocio { get; set; }
        public string codigoSocio { get; set; }
        public string grupoSocio { get; set; }
        public Nullable<int> idTipoDocumento { get; set; }
        public string nroDocumento { get; set; }
        public string razonSocial { get; set; }
        public string telefono1 { get; set; }
        public string telefono2 { get; set; }
        public string email { get; set; }
        public string direccionFiscal { get; set; }
        public string direccionAlternativa { get; set; }
        public Nullable<int> idCondicionPago { get; set; }
        public string cuentaDetraccion { get; set; }
        public string cuentaCorriente1 { get; set; }
        public string cuentaMoneda1 { get; set; }
        public Nullable<int> cuentaCodigoBanco1 { get; set; }
        public string cuentaCorriente2 { get; set; }
        public string cuentaMoneda2 { get; set; }
        public Nullable<int> cuentaCodigoBanco2 { get; set; }
        public Nullable<bool> estado { get; set; }
        public string contacto1 { get; set; }
        public string telefonoContacto1 { get; set; }
        public string emailContacto1 { get; set; }
        public string contacto2 { get; set; }
        public string telefonoContacto2 { get; set; }
        public string emailContacto2 { get; set; }
        public string contacto3 { get; set; }
        public string telefonoContacto3 { get; set; }
        public string emailContacto3 { get; set; }

        public condicionPagoViewModel condicionPago { get; set; }
        public tipoDocumentoIdentidadViewModel tipoDocumentoIdentidad { get; set; }
    }
}
