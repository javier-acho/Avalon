﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AvalonDBEntities : DbContext
    {
        public AvalonDBEntities()
            : base("name=AvalonDBEntities")
        {
        Configuration.LazyLoadingEnabled = false;
        ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = 300;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<menuXperfil> menuXperfil { get; set; }
        public virtual DbSet<modulo> modulo { get; set; }
        public virtual DbSet<perfil> perfil { get; set; }
        public virtual DbSet<usuarioXperfil> usuarioXperfil { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
        public virtual DbSet<menu> menu { get; set; }
        public virtual DbSet<condicionPago> condicionPago { get; set; }
        public virtual DbSet<tipoDocumentoIdentidad> tipoDocumentoIdentidad { get; set; }
        public virtual DbSet<banco> banco { get; set; }
        public virtual DbSet<centroCostos> centroCostos { get; set; }
        public virtual DbSet<clase> clase { get; set; }
        public virtual DbSet<familia> familia { get; set; }
        public virtual DbSet<producto> producto { get; set; }
        public virtual DbSet<servicio> servicio { get; set; }
        public virtual DbSet<socioNegocio> socioNegocio { get; set; }
        public virtual DbSet<subCentroCostos> subCentroCostos { get; set; }
        public virtual DbSet<subClase> subClase { get; set; }
        public virtual DbSet<subFamilia> subFamilia { get; set; }
        public virtual DbSet<subSubCentroCostos> subSubCentroCostos { get; set; }
        public virtual DbSet<subSubClase> subSubClase { get; set; }
        public virtual DbSet<unidadMedida> unidadMedida { get; set; }
    }
}
