using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.ViewModel.Seguridad
{
    public class PerfilViewModel
    {
        public PerfilViewModel()
        {
            this.menuXperfil = new List<MenuXPerfilViewModel>();
            this.usuarioXperfil = new List<UsuarioXPerfilViewModel>();
        }

        public int id { get; set; }
        public string nombrePerfil { get; set; }
        public string usuCrea { get; set; }
        public DateTime fechaCrea { get; set; }

        public List<MenuXPerfilViewModel> menuXperfil { get; set; }
        public List<UsuarioXPerfilViewModel> usuarioXperfil { get; set; }
    }
}
