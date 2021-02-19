using System;
using System.Collections.Generic;
using System.Text;
using Class_revison.data.Entinities;
using Microsoft.EntityFrameworkCore; 

namespace Class_revison.data
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        public DbSet<College> College { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<College>().ToTable("College");
        }

    }
}
