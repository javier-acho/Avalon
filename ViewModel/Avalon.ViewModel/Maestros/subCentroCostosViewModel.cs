using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.ViewModel.Maestros
{
    public class subCentroCostosViewModel
    {
        public subCentroCostosViewModel()
        {
            this.subSubCentroCostos = new List<subSubCentroCostosViewModel>();
        }

        public int id { get; set; }
        public int idCentroCostos { get; set; }
        public string nombre { get; set; }
        public string nombreCorto { get; set; }
        public Nullable<bool> estado { get; set; }

        public centroCostosViewModel centroCostos { get; set; }
        public List<subSubCentroCostosViewModel> subSubCentroCostos { get; set; }
    }
}
