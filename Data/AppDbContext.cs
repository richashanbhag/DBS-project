﻿using Microsoft.EntityFrameworkCore;
using BlazorApp2.Models;

namespace BlazorApp2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
    }
}
