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
    
    public partial class requerimientoDetalle
    {
        public int id { get; set; }
        public Nullable<int> idRQ { get; set; }
        public Nullable<int> linea { get; set; }
        public Nullable<int> idProducto { get; set; }
        public string descripcion { get; set; }
        public Nullable<decimal> cantidad { get; set; }
        public Nullable<int> idUM { get; set; }
        public Nullable<decimal> cantidadAprobada { get; set; }
        public string observacion { get; set; }
    
        public virtual requerimiento requerimiento { get; set; }
    }
}
