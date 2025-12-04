using TechStore.DataAccess.Abstract;
using TechStore.DataAccess.Concrete.Context;
using TechStore.Entities.Concrete;

namespace TechStore.DataAccess.Concrete.EntityFramework;

public class EfProductRepository : EfGenericRepository<Product>, IProductRepository
{
    public EfProductRepository(TechStoreContext context) : base(context)
    {
    }
}
