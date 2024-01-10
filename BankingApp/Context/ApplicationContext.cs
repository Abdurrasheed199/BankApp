using BankingApp.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace BankingApp.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options /*IIdentityService identityService*/) : base(options)
        {
            //_identityService = identityService;

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<TransactionHistory> TransactionHistories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        //public DbSet<Product> Products { get; set; }
        //public DbSet<UserRole> UserRoles { get; set; }

    }
}
