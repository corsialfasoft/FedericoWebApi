//------------------------------------------------------------------------------
// <auto-generated>
//     Codice generato da un modello.
//
//     Le modifiche manuali a questo file potrebbero causare un comportamento imprevisto dell'applicazione.
//     Se il codice viene rigenerato, le modifiche manuali al file verranno sovrascritte.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FedericoWebApi
{
    using System;
    using System.Collections.Generic;
    
    public partial class RichiesteSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RichiesteSet()
        {
            this.RichiesteProdotti = new HashSet<RichiesteProdotti>();
        }
    
        public int Id { get; set; }
        public System.DateTime data { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RichiesteProdotti> RichiesteProdotti { get; set; }
    }
}
