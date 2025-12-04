using TechStore.DataAccess.Abstract;
using TechStore.DataAccess.Concrete.Context;
using TechStore.Entities.Concrete;

namespace TechStore.DataAccess.Concrete.EntityFramework;

public class EfOrderDetailRepository : EfGenericRepository<OrderDetail>, IOrderDetailRepository
{
    public EfOrderDetailRepository(TechStoreContext context) : base(context)
    {
    }
}
