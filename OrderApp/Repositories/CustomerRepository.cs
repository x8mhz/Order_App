using OrderApp.Context;
using OrderApp.Interfaces;
using OrderApp.Models;

namespace OrderApp.Repositories
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(OrderAppContext context) : base(context)
        {
        }
    }
}
