using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.ViewModel.Maestros
{
    public class subSubCentroCostosViewModel
    {
        public int id { get; set; }
        public int idCentroCostos { get; set; }
        public int idSubCentroCostos { get; set; }
        public string nombre { get; set; }
        public string nombreCorto { get; set; }
        public Nullable<bool> estado { get; set; }

        public subCentroCostosViewModel subCentroCostos { get; set; }
    }
}
