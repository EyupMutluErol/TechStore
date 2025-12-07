using TechStore.Business.Dtos.ProductDtos;
using TechStore.Entities.Concrete;

namespace TechStore.Business.Abstract;

public interface IProductService:IGenericService<Product>
{
    Task<List<Product>> GetProductsByCategoryAsync(int categoryId);
}
