﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace emlakportal.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class emlakportaliDB01Entities : DbContext
    {
        public emlakportaliDB01Entities()
            : base("name=emlakportaliDB01Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ilan> Ilan { get; set; }
        public virtual DbSet<Kategori> Kategori { get; set; }
        public virtual DbSet<Uye> Uye { get; set; }
        public virtual DbSet<Yorum> Yorum { get; set; }
    }
}