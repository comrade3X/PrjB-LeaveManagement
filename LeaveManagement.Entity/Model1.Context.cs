﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LeaveManagementEntities : DbContext
    {
        public LeaveManagementEntities()
            : base("name=LeaveManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanyRole> CompanyRoles { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeLabor> EmployeeLabors { get; set; }
        public virtual DbSet<EmployeeLeaveInformation> EmployeeLeaveInformations { get; set; }
        public virtual DbSet<LaborType> LaborTypes { get; set; }
        public virtual DbSet<LeaveRequest> LeaveRequests { get; set; }
        public virtual DbSet<LeaveRequestHistory> LeaveRequestHistories { get; set; }
        public virtual DbSet<LeaveType> LeaveTypes { get; set; }
    }
}
