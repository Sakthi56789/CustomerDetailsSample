using CustomerDetailsSample.Domain;
using Microsoft.EntityFrameworkCore;

namespace CustomerDetailsSample.Infrastructure
{
    public class CustomerDetailsDbContext : DbContext
    {
        public CustomerDetailsDbContext (DbContextOptions <CustomerDetailsDbContext> options) : base (options) 
        {
        }
        public DbSet<CustomerDetails> customerdetails { get; set; }
    }
}
