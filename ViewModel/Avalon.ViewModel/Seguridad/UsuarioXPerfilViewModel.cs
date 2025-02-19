using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.ViewModel.Seguridad
{
    public class UsuarioXPerfilViewModel
    {
        public int id { get; set; }
        public int idUsuario { get; set; }
        public int idPerfil { get; set; }
        public bool estado { get; set; }

        public PerfilViewModel perfil { get; set; }
        public UsuarioViewModel usuario { get; set; }
    }
}
