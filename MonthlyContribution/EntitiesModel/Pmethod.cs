//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MonthlyContribution.EntitiesModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pmethod
    {
        public int id { get; set; }
        public string name { get; set; }
        public string paymentType { get; set; }
        public string mobileNumber { get; set; }
        public string accountNumber { get; set; }
        public string ifscCode { get; set; }
        public string accHName { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
    }
}