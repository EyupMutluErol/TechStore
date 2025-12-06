using AutoMapper;
using TechStore.Business.Dtos.CategoryDtos;
using TechStore.Business.Dtos.ProductDtos;
using TechStore.Entities.Concrete;

namespace TechStore.Business.AutoMapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Category,CategoryAddDto>().ReverseMap();
        CreateMap<Category,CategoryUpdateDto>().ReverseMap();
        CreateMap<Category, CategoryListDto>()
            .ForMember(dest => dest.ParentCategoryName, opt => opt.MapFrom(src => src.ParentCategory.Name));

        CreateMap<Product, ProductAddDto>().ReverseMap();
        CreateMap<Product, ProductUpdateDto>().ReverseMap();
        CreateMap<Product, ProductListDto>()
            .ForMember(dest=>dest.CategoryName,opt=>opt.MapFrom(src=>src.Category.Name));
    }
}
