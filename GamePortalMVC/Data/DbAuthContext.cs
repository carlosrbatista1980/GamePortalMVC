using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using GamePortalMVC.Data.Repositories;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace GamePortalMVC.Data
{
    public class DbAuthContext : DbContext
    {
        //INSERT YOUR DbSets HERE!
        public DbSet<Account> Account { get; set; }
        public DbSet<Block> Block { get; set; }
        
        public DbAuthContext(DbContextOptions<DbAuthContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //INSERT YOUR Entities HERE!
            modelBuilder.Entity<Account>().ToTable(nameof(Account));
            modelBuilder.Entity<Block>().ToTable(nameof(Block));
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
                optionsBuilder.UseSqlServer($"Server=LOCALHOST; Database=Auth;User Id=sa;Password=;");
            }

            base.OnConfiguring(optionsBuilder);
        }
    }
}
