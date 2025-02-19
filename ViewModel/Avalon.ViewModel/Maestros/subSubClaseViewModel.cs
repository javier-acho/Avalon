using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.ViewModel.Maestros
{
    public class subSubClaseViewModel
    {
        public int id { get; set; }
        public int idClase { get; set; }
        public int idSubClase { get; set; }
        public string nombre { get; set; }
        public string nombreCorto { get; set; }
        public Nullable<bool> estado { get; set; }

        public subClaseViewModel subClase { get; set; }
    }
}
