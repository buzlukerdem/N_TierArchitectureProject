﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    // identity kutuphanesi eklenince DbContext -> :IdentityDbContext oldu (islemlerimizi kolaylastiran bir islem)
    public class Context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-HJL1ER0;database=DB_OOPSatis;integrated security=true");
        }
        public DbSet<Product>? Products { get; set; }
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Job>? Jobs { get; set; }
    }
}
