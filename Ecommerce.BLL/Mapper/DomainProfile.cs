using AutoMapper;
using Ecommerce.BLL.Models;
using Ecommerce.DAL.Entities;

namespace Ecommerce.BLL.Mapper
{
    public class DomainProfile: Profile
    {
        public DomainProfile()
        {
            CreateMap<Product, ProductVM>().ReverseMap();
            CreateMap<Order, OrderVM>().ReverseMap();
            CreateMap<Customer, CustomerVM>().ReverseMap();
        }
    }
}
