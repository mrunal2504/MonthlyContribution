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
    
    public partial class Fifth_mR
    {
        public int id { get; set; }
        public string memberName { get; set; }
        public string monthlyAmount { get; set; }
        public string interest { get; set; }
        public string paidAmount { get; set; }
        public string CollectedAmount { get; set; }
        public int memberId { get; set; }
        public int bcId { get; set; }
        public Nullable<System.DateTime> updatedAt { get; set; }
        public string bcName { get; set; }
    }
}
