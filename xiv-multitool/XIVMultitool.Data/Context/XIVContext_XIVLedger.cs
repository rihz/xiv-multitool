using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Entities;
using XIVMultitool.Entities.XIVLedger;

namespace XIVChecklist.Data.Context
{
    public partial class XIVContext
    {
        public virtual DbSet<LedgerSheet> LedgerSheet { get; set; }
        public virtual DbSet<MarketTransaction> MarketTransaction { get; set; }

        public void OnModelCreating_XIVLedger(ModelBuilder builder)
        {
            builder.Entity<LedgerSheet>(e =>
            {
                e.HasKey(x => x.Id);

                CreateOneToMany<LedgerSheet, AppUser>(e, "User", "LedgerSheets", "UserId", deleteBehavior: DeleteBehavior.Cascade);
            });

            builder.Entity<MarketTransaction>(e =>
            {
                e.HasKey(x => x.Id);

                CreateOneToMany<MarketTransaction, LedgerSheet>(e, "Sheet", "MarketTransactions", "SheetId", deleteBehavior: DeleteBehavior.Cascade);
            });
        }
    }
}
