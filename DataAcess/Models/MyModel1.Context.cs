﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAcess.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DBEntities : DbContext
    {
        public DBEntities()
            : base("name=DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Auther> Authers { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
    
        public virtual ObjectResult<ProcRport1_Result> ProcRport1(Nullable<System.DateTime> from, Nullable<System.DateTime> to)
        {
            var fromParameter = from.HasValue ?
                new ObjectParameter("from", from) :
                new ObjectParameter("from", typeof(System.DateTime));
    
            var toParameter = to.HasValue ?
                new ObjectParameter("to", to) :
                new ObjectParameter("to", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ProcRport1_Result>("ProcRport1", fromParameter, toParameter);
        }
    }
}
