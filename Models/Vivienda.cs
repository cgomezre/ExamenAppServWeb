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
    
    public partial class Vivienda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vivienda()
        {
            this.Ventas = new HashSet<Venta>();
        }
    
        public int Id { get; set; }
        public int TipoViviendaId { get; set; }
        public int AgenciaId { get; set; }
        public int NumCuartos { get; set; }
        public int NumBanos { get; set; }
        public decimal Tamano { get; set; }
        public int NumPisos { get; set; }
        public string Accesorios { get; set; }
    
        public virtual Agencia Agencia { get; set; }
        public virtual TipoVivienda TipoVivienda { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta> Ventas { get; set; }
    }
}
