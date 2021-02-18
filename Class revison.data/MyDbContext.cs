using System;
using System.Collections.Generic;
using System.Text;
using Class_revison.data.Entinities;
using Microsoft.EntityFrameworkCore;

namespace Class_revison.data
{
    class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOpions<ClassDbContext> options) : base(options)
        {

        }
        public DbSet<College> College { set; get; }

        protected override void OnModeCreating(ModelBuildier modelBuilder)
        {
            modelBuilder.Entity<College>.ToTable("College");
        }

    }
}
