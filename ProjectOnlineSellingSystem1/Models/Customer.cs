//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectOnlineSellingSystem1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public Customer()
        {

        }
        public Customer(string customerName, string userName, string customerEmail, string customerPassword)
        {
            CustomerName = customerName;
            UserName = userName;
            CustomerEmail = customerEmail;
            Customerpassword = customerPassword;

        }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        
       
        public string CustomerName { get; set; }
        public string UserName { get; set; }
        public string CustomerEmail { get; set; }
        public string Customerpassword { get; set; }
    
        public virtual UserDetail UserDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order> orders { get; set; }
    }
}
