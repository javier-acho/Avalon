using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.ViewModel.Seguridad
{
    public class MenuViewModel
    {
        public MenuViewModel()
        {
            this.menuXperfil = new List<MenuXPerfilViewModel>();
            this.modulo = new List<ModuloViewModel>();
        }

        public int id { get; set; }
        public string nombre { get; set; }
        public int padre { get; set; }
        public bool estado { get; set; }
        public List<MenuXPerfilViewModel> menuXperfil { get; set; }
        public List<ModuloViewModel> modulo { get; set; }
    }
}
