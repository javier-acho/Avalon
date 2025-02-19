using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.ViewModel.Maestros
{
    public class servicioViewModel
    {
        public int id { get; set; }
        public string codigoServicio { get; set; }
        public string nombreServicio { get; set; }
        public string descripcionServicio { get; set; }
        public Nullable<int> idCentroCostos { get; set; }
        public Nullable<int> idSubCentroCostos { get; set; }
        public Nullable<int> idSubSubCentroCostos { get; set; }
        public Nullable<bool> esParaCompra { get; set; }
        public Nullable<bool> esParaVenta { get; set; }
    }
}
