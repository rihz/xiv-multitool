using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
using XIVChecklist.Entities;
using XIVChecklist.Entities.Common;
using XIVMultitool.Entities.Account;
using XIVMultitool.Entities.XIVMultitool;

namespace XIVChecklist.Data.Context
{
    public partial class XIVContext : IdentityDbContext<AppUser>
    {
        public virtual DbSet<AppUser> Users { get; set; }
        public virtual DbSet<LodestoneCharacter> LodestoneCharacters { get; set; }
        public virtual DbSet<Retainer> Retainers { get; set; }
        public virtual DbSet<RetainerLabel> RetainerLabels { get; set; }

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

            builder.Entity<LodestoneCharacter>(e =>
            {
                e.HasKey(x => x.Id);

                CreateOneToMany<LodestoneCharacter, AppUser>(e, "User", "LodestoneCharacters", "UserId");
            });

            builder.Entity<Retainer>(e =>
            {
                e.HasKey(x => x.Id);

                CreateOneToMany<Retainer, AppUser>(e, "User", "Retainers", "UserId");
            });

            builder.Entity<RetainerLabel>(e =>
            {
                e.HasKey(x => x.Id);

                CreateOneToMany<RetainerLabel, Retainer>(e, "Retainer", "Labels", "RetainerId");
            });

            OnModelCreating_Common(builder);
            OnModelCreating_Categories(builder);
            OnModelCreating_Tasks(builder);
            OnModelCreating_XIVLedger(builder);
        }
    }
}
