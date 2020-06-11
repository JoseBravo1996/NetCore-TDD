using Microsoft.EntityFrameworkCore;
using NetCore_TDD.Infra.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore_TDD.Infra.Repositories
{
    public class DBContext: DbContext
    {
        public DbSet<Insurance> Insurance { get; set; }
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Insurance>(e =>
            {
                e
                .ToTable("insurance")
                .HasKey(k => k.Id);

                e
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();
            });
        }
    }
}
