using TechStore.Business.Abstract;
using TechStore.DataAccess.Abstract;
using TechStore.Entities.Concrete;

namespace TechStore.Business.Concrete;

public class ProductManager : GenericServiceManager<Product>, IProductService
{
    protected readonly IProductRepository _productRepository;
    public ProductManager(IProductRepository productRepository) : base(productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<List<Product>> GetProductsByCategoryAsync(int categoryId)
    {
        return await _productRepository.GetAllAsync(x=>x.CategoryId == categoryId);
    }
}
