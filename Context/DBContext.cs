﻿using StolAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace StolAPI.Context
{
    public class DBContext : DbContext
    {

     
        public DbSet<EFMaga> Magas { get; set; }
        public DbSet<EFStols> Stols { get; set; }
        public DBContext(string cnnString)
        {
            ConnectionString = cnnString;
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public string ConnectionString { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
            
        }
    }
}
