//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Avalon.AccesoDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class menuXperfil
    {
        public int id { get; set; }
        public Nullable<int> idMenu { get; set; }
        public Nullable<int> idPerfil { get; set; }
    
        public virtual perfil perfil { get; set; }
        public virtual menu menu { get; set; }
    }
}
