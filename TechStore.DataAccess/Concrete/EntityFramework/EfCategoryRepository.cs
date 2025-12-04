using TechStore.DataAccess.Abstract;
using TechStore.DataAccess.Concrete.Context;
using TechStore.Entities.Concrete;

namespace TechStore.DataAccess.Concrete.EntityFramework;

public class EfCategoryRepository : EfGenericRepository<Category>, ICategoryRepository
{
    public EfCategoryRepository(TechStoreContext context) : base(context)
    {
    }
}
