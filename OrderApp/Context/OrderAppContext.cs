using Microsoft.EntityFrameworkCore;
using OrderApp.Mappings;
using OrderApp.Models;
using OrderApp.ViewModels;

namespace OrderApp.Context
{
    public class OrderAppContext : DbContext
    {
        public OrderAppContext(DbContextOptions<OrderAppContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb; Initial Catalog=DB_OrderApp; Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerMap());
            modelBuilder.ApplyConfiguration(new UserMap());
        }

        public DbSet<OrderApp.ViewModels.CustomerViewModel> CustomerViewModel { get; set; }

        public DbSet<OrderApp.Models.Customer> Customer { get; set; }
    }
}
