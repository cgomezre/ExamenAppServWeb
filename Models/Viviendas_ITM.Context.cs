﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExamenAppServWeb.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Viviendas_ITMEntities : DbContext
    {
        public Viviendas_ITMEntities()
            : base("name=Viviendas_ITMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Agencia> Agencias { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<TipoVivienda> TipoViviendas { get; set; }
        public virtual DbSet<Venta> Ventas { get; set; }
        public virtual DbSet<Vivienda> Viviendas { get; set; }
    }
}
