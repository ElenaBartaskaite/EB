//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aukcionas
{
    using System;
    using System.Collections.Generic;
    
    public partial class Aukcionas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Aukcionas()
        {
            this.Paveikslas = new HashSet<Paveikslas>();
            this.Kolekcionierius = new HashSet<Kolekcionierius>();
        }
    
        public string AukcionoPavadinimas { get; set; }
        public string Vieta { get; set; }
        public System.DateTime Data { get; set; }
        public System.TimeSpan Pradzia { get; set; }
        public System.TimeSpan Pabaiga { get; set; }
        public string Slaptazodis { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Paveikslas> Paveikslas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kolekcionierius> Kolekcionierius { get; set; }
    }
}