using AutoMapper;
using BusinessLayer.Models;
using DataLayer.Models;

namespace Infrastructure.DataMapper
{
    public class DomainProfile: Profile
    {
        public DomainProfile()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<ShoppingCart, ShoppingCartDto>();
        }
    }
}
