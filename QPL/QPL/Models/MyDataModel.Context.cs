//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QPL.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TechLeagueDBEntities : DbContext
    {
        public TechLeagueDBEntities()
            : base("name=TechLeagueDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<RoleTable> RoleTables { get; set; }
        public virtual DbSet<TeamTable> TeamTables { get; set; }
        public virtual DbSet<UserTable> UserTables { get; set; }
        public virtual DbSet<UserToRoleMapping> UserToRoleMappings { get; set; }
        public virtual DbSet<UserToTeamMapping> UserToTeamMappings { get; set; }
    }
}
