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
    
    public partial class usuario
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usuario()
        {
            this.usuarioXperfil = new HashSet<usuarioXperfil>();
        }
    
        public int id { get; set; }
        public string nombre { get; set; }
        public string nomUsu { get; set; }
        public string password { get; set; }
        public Nullable<bool> cambioPassword { get; set; }
        public Nullable<bool> estado { get; set; }
        public string usuCrea { get; set; }
        public Nullable<System.DateTime> fechaCrea { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<usuarioXperfil> usuarioXperfil { get; set; }
    }
}
