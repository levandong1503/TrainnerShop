using Acme.TrannerShop.Products;
using AutoMapper;

namespace Acme.TrannerShop;

public class TrannerShopApplicationAutoMapperProfile : Profile
{
    public TrannerShopApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Product, ProductDto>();
        CreateMap<CreateUpdateProductDto, Product>();
    }
}
