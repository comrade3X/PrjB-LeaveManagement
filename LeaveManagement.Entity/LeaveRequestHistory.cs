//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeaveManagement.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class LeaveRequestHistory
    {
        public int Id { get; set; }
        public int LeaveRequestId { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdateOn { get; set; }
        public string Status { get; set; }
    
        public virtual LeaveRequest LeaveRequest { get; set; }
    }
}
