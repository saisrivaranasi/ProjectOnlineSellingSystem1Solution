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
    
    public partial class seller
    {
        public seller()
        {

        }
        public seller(string sellerName, string userName, string sellerEmail, string sellerPassword)
        {
            SellerName = sellerName;
            UserName = userName;
            SellerEmail = sellerEmail;
            SellerPassword = sellerPassword;

        }
        
        public string SellerName { get; set; }
        public string UserName { get; set; }
        public string SellerEmail { get; set; }
        public string SellerPassword { get; set; }
    
        public virtual UserDetail UserDetail { get; set; }
    }
}
