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
    
    public partial class Dailininkas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dailininkas()
        {
            this.Paveikslas = new HashSet<Paveikslas>();
        }
    
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public System.DateTime GimimoMetai { get; set; }
        public Nullable<System.DateTime> MirtiesMetai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Paveikslas> Paveikslas { get; set; }
    }
}