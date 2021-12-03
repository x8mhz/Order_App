using AutoMapper;
using OrderApp.Models;
using OrderApp.ViewModels;

namespace OrderApp.AutoMapper
{
    public class ViewModelToDomain : Profile
    {
        public ViewModelToDomain()
        {
            CreateMap<CustomerViewModel, Customer>();
            CreateMap<UserViewModel, User>();
        }
    }
}
