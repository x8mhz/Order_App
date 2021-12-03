using OrderApp.Context;
using OrderApp.Interfaces;
using OrderApp.Models;

namespace OrderApp.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(OrderAppContext context) : base(context)
        {

        }
    }
}
