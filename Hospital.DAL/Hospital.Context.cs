﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hospital.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class HospitalEntities : DbContext
    {
        public HospitalEntities()
            : base("name=HospitalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<dbo_empAddress> dbo_empAddress { get; set; }
        public virtual DbSet<dbo_empSalary> dbo_empSalary { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<User> Users { get; set; }
    
        public virtual int insertEmpAddressSalary(string firstname, string lastname, string title, string phone, Nullable<bool> status, Nullable<int> empSalary, string empAddress)
        {
            var firstnameParameter = firstname != null ?
                new ObjectParameter("firstname", firstname) :
                new ObjectParameter("firstname", typeof(string));
    
            var lastnameParameter = lastname != null ?
                new ObjectParameter("lastname", lastname) :
                new ObjectParameter("lastname", typeof(string));
    
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var statusParameter = status.HasValue ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(bool));
    
            var empSalaryParameter = empSalary.HasValue ?
                new ObjectParameter("empSalary", empSalary) :
                new ObjectParameter("empSalary", typeof(int));
    
            var empAddressParameter = empAddress != null ?
                new ObjectParameter("empAddress", empAddress) :
                new ObjectParameter("empAddress", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("insertEmpAddressSalary", firstnameParameter, lastnameParameter, titleParameter, phoneParameter, statusParameter, empSalaryParameter, empAddressParameter);
        }
    }
}
