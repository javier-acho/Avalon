using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.ViewModel.Seguridad
{
    public class UsuarioViewModel
    {
        public UsuarioViewModel()
        {
            this.usuarioXperfil = new List<UsuarioXPerfilViewModel>();
        }

        public int id { get; set; }
        public string nombre { get; set; }
        public string nomUsu { get; set; }
        public string password { get; set; }
        public bool cambioPassword { get; set; }
        public bool estado { get; set; }
        public string usuCrea { get; set; }
        public DateTime fechaCrea { get; set; }
        public List<UsuarioXPerfilViewModel> usuarioXperfil { get; set; }
    }
}
