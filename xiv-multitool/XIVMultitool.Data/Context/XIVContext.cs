using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using XIVChecklist.Entities;
using XIVChecklist.Entities.Common;

namespace XIVChecklist.Data.Context
{
    public partial class XIVContext : IdentityDbContext<AppUser>
    {
        public virtual DbSet<AppUser> Users { get; set; }

        public XIVContext(DbContextOptions options)
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging(true);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            OnModelCreating_Common(builder);
            OnModelCreating_Categories(builder);
            OnModelCreating_Tasks(builder);
        }
    }
}
