﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GenkPrintMVC_v0._5.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class genkPrintDbEntities : DbContext
    {
        public genkPrintDbEntities()
            : base("name=genkPrintDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<CurrCreditAmount> CurrCreditAmounts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CutMethod> CutMethods { get; set; }
        public virtual DbSet<DeliveryMethod> DeliveryMethods { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<LaminationMethod> LaminationMethods { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<PrintingMode> PrintingModes { get; set; }
        public virtual DbSet<Priority> Priorities { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<ProductsubCategory> ProductsubCategories { get; set; }
        public virtual DbSet<Shape> Shapes { get; set; }
        public virtual DbSet<Sticker> Stickers { get; set; }
        public virtual DbSet<CreditTransLog> CreditTransLogs { get; set; }
    }
}