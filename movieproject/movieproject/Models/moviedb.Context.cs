﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace movieproject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class movieEntities : DbContext
    {
        public movieEntities()
            : base("name=movieEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbllocation> tbllocations { get; set; }
        public virtual DbSet<tblmovy> tblmovies { get; set; }
        public virtual DbSet<tbltheatre> tbltheatres { get; set; }
    }
}
