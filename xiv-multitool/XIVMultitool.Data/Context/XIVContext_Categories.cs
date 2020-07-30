using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using XIVChecklist.Data.Seed;
using XIVChecklist.Entities.Categories;

namespace XIVChecklist.Data.Context
{
    public partial class XIVContext
    {
        public virtual DbSet<Category> Category { get; set; }

        public void OnModelCreating_Categories(ModelBuilder builder)
        {
            builder.Entity<Category>(e =>
            {
                e.HasKey(x => x.Id);

                e.HasOne(x => x.ParentCategory)
                    .WithMany(x => x.ChildCategories)
                    .HasForeignKey(x => x.ParentCategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Category_ParentCategory");

                e.HasData(SeedCategories.Categories);
            });
        }
    }
}
