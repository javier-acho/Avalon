using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.ViewModel.Compra
{
    public class requerimientoDetalleViewModel
    {
        public int id { get; set; }
        public int linea { get; set; }
        public int idProducto { get; set; }
        public string codigoProducto { get; set; }
        public string descripcion { get; set; }
        public decimal cantidad { get; set; }
        public int idUM { get; set; }
        public string unidadMedida { get; set; }
        public decimal cantidadAprobada { get; set; }
        public string observacion { get; set; }
    }
}
