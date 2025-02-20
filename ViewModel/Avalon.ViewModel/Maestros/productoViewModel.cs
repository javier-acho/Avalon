using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.ViewModel.Maestros
{
    public class productoViewModel
    {
        public int id { get; set; }
        public string codigoProducto { get; set; }
        public string nombreProducto { get; set; }
        public string descripcionProducto { get; set; }
        public string codigoCliente { get; set; }
        public Nullable<int> idUnidadMedida { get; set; }
        public string unidadMedida { get; set; }
        public Nullable<int> idClase { get; set; }
        public string clase { get; set; }
        public Nullable<int> idSubClase { get; set; }
        public string subClase { get; set; }
        public Nullable<int> idSubSubClase { get; set; }
        public string subSubClase { get; set; }
        public Nullable<int> idCentroCostos { get; set; }
        public string cc { get; set; }
        public Nullable<int> idSubCentroCostos { get; set; }
        public string scc { get; set; }
        public Nullable<int> idSubSubCentroCostos { get; set; }
        public string sscc { get; set; }
        public Nullable<int> idFamilia { get; set; }
        public string familia { get; set; }
        public Nullable<int> idSubFamilia { get; set; }
        public string subFamilia { get; set; }
        public string ubicacion { get; set; }
        public Nullable<bool> esParaVenta { get; set; }
        public Nullable<bool> esParaCompra { get; set; }
    }
}
