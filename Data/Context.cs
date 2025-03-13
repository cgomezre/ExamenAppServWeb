using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

using ExamenAppServWeb.Models;

namespace ExamenAppServWeb.Data
{
    public class Viviendas_ITMEntities : DbContext
    {

        public Viviendas_ITMEntities() : base("name=Viviendas_ITMEntities") { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<TipoVivienda> TiposVivienda { get; set; }
        public DbSet<Agencia> Agencias { get; set; }
        public DbSet<Vivienda> Viviendas { get; set; }
        public DbSet<Venta> Ventas { get; set; }

    }
}