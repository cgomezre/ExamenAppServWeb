//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Venta
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int ViviendaId { get; set; }
        public System.DateTime FechaVenta { get; set; }
        public decimal Precio { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Vivienda Vivienda { get; set; }
    }
}
