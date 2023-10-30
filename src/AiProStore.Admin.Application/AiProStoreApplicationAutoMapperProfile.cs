using AutoMapper;
using AiProStore.Admin.ProductCategories;
using AiProStore.ProductCategories;
using AiProStore.Products;

namespace AiProStore.Admin;

public class AiProStoreApplicationAutoMapperProfile : Profile
{
    public AiProStoreApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        // Product category
        CreateMap<ProductCategory, ProductCategoryDto>();
        CreateMap<ProductCategory, ProductCategoryInListDto>();
        CreateMap<CreateUpdateProductCategoryDto, ProductCategory>();

        // Product
        CreateMap<Product, ProductDto>();
        CreateMap<Product, ProductInListDto>();
        CreateMap<CreateUpdateProductDto, Product>();
    }
}
