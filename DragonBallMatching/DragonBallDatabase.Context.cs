﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DragonBallMatching
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Dragon_Ball_MatchingEntities : DbContext
    {
        public Dragon_Ball_MatchingEntities()
            : base("name=Dragon_Ball_MatchingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AreaTable> AreaTable { get; set; }
        public virtual DbSet<LikesTable> LikesTable { get; set; }
        public virtual DbSet<MessagesTable> MessagesTable { get; set; }
        public virtual DbSet<SexTable> SexTable { get; set; }
        public virtual DbSet<UsersTable> UsersTable { get; set; }
        public virtual DbSet<LogonTable> LogonTable { get; set; }
    }
}