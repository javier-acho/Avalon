﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avalon.ViewModel.Seguridad
{
    public class MenuXPerfilViewModel
    {
        public int id { get; set; }
        public int idMenu { get; set; }
        public int idPerfil { get; set; }

        public MenuViewModel menu { get; set; }
        public PerfilViewModel perfil { get; set; }
    }
}
