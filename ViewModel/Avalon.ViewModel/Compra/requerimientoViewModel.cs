using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.ViewModel.Compra
{
    public class requerimientoViewModel
    {
        public int id { get; set; }
        public string codigoRQ { get; set; }
        public DateTime fecha { get; set; }
        public string estado { get; set; }
        public string prioridad { get; set; }
        public int idCc { get; set; }
        public int idScc { get; set; }
        public int idSscc { get; set; }
        public int idArea { get; set; }
        public string solictante { get; set; }
        public string comentario { get; set; }
        public List<requerimientoDetalleViewModel> requerimientoDetalle { get; set; }
    }
}
