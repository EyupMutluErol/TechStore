using TechStore.Business.Abstract;
using TechStore.DataAccess.Abstract;
using TechStore.Entities.Concrete;

namespace TechStore.Business.Concrete;

public class CategoryManager : GenericServiceManager<Category>, ICategoryService
{
    public CategoryManager(ICategoryRepository categoryRepository) : base(categoryRepository)
    {
    }
}
