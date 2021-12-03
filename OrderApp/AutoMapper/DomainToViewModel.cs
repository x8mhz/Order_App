using AutoMapper;
using OrderApp.Models;
using OrderApp.ViewModels;

namespace OrderApp.AutoMapper
{
    public class DomainToViewModel : Profile
    {
        public DomainToViewModel()
        {
            CreateMap<Customer, CustomerViewModel>();
            CreateMap<User, UserViewModel>();
        }
    }
}
