﻿using Microsoft.AspNet.Identity.EntityFramework;
using ApotheekApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Microsoft.AspNetCore.Identity;

namespace ApotheekApp.Data
{
    public class DataContext : IdentityDbContext<AppUser>
    {
        public DbSet<Client> Clients {  get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Medicine> Medicines { get; set; }

        public DataContext() : base()
        {

        } 

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Client>().HasKey(x => x.Id);
            //modelBuilder.Entity<Client>().HasOne(x => x.Medicines).WithMany();
            //modelBuilder.Entity<Employee>().HasKey(x => x.Id);
            //modelBuilder.Entity<Medicine>().HasKey(x => x.Id);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    if (!options.IsConfigured)
        //    {
        //        options.UseLazyLoadingProxies().UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ApotheekDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=True");
        //        base.OnConfiguring(options);
        //    }
        //}
    }
}
