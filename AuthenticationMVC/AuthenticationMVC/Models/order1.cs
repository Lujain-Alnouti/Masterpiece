//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AuthenticationMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class order1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public order1()
        {
            this.orderProducts = new HashSet<orderProduct>();
        }
    
        public int id { get; set; }
        public Nullable<int> productId { get; set; }
        public Nullable<double> total { get; set; }
        public Nullable<int> quantity { get; set; }
        public string userEmail { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orderProduct> orderProducts { get; set; }
    }
}
