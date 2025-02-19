using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.ViewModel.Maestros
{
    public class tipoDocumentoIdentidadViewModel
    {
        public tipoDocumentoIdentidadViewModel()
        {
            this.socioNegocio = new List<socioNegocioViewModel>();
        }

        public int id { get; set; }
        public string nombre { get; set; }

        public List<socioNegocioViewModel> socioNegocio { get; set; }
    }
}
