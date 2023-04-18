using System;
using System.Collections.Generic;
using System.Text;
using ARShowcase.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ARShowcase.Data
{
    internal class AccountContext: IdentityDbContext<User, Role, int>
    {
        public DbSet<Account> Accounts { get; set; }
        public AccountContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Account>().Property(_ => _.User).IsRequired();
            base.OnModelCreating(builder);
        }
    }
}
