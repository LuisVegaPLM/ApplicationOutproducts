﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class PLMUsersM : DbContext
    {
        public PLMUsersM()
            : base("name=PLMUsersM")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ActivityLogs> ActivityLogs { get; set; }
        public virtual DbSet<ActivitySessions> ActivitySessions { get; set; }
        public virtual DbSet<Applications> Applications { get; set; }
        public virtual DbSet<ApplicationUsers> ApplicationUsers { get; set; }
        public virtual DbSet<Countries_Users> Countries_Users { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Tables> Tables { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserCountries> UserCountries { get; set; }
    
        public virtual ObjectResult<plm_spLoginApplications_Result> plm_spLoginApplications(string user, string password, string hashKey)
        {
            var userParameter = user != null ?
                new ObjectParameter("User", user) :
                new ObjectParameter("User", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var hashKeyParameter = hashKey != null ?
                new ObjectParameter("HashKey", hashKey) :
                new ObjectParameter("HashKey", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<plm_spLoginApplications_Result>("plm_spLoginApplications", userParameter, passwordParameter, hashKeyParameter);
        }
    }
}
