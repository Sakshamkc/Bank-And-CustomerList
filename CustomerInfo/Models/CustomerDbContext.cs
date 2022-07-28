
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerInfo.Models
{
    public class CustomerDbContext: DbContext
    {
        public CustomerDbContext(DbContextOptions<CustomerDbContext>options):base(options)
        {

        }
        public DbSet<Customers> customers { get; set; }
        public DbSet<Bank> Bank { get; set; }
    }
}
