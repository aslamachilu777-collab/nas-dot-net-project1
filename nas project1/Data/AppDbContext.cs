using nas_project1.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;


namespace nas_project1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Policy> Policies { get; set; }
    }
}
