using TechStore.DataAccess.Abstract;
using TechStore.DataAccess.Concrete.Context;
using TechStore.Entities.Concrete;

namespace TechStore.DataAccess.Concrete.EntityFramework;

public class EfOrderRepository : EfGenericRepository<Order>, IOrderRepository
{
    public EfOrderRepository(TechStoreContext context) : base(context)
    {
    }
}
