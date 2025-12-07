using TechStore.Business.Abstract;
using TechStore.DataAccess.Abstract;
using TechStore.Entities.Concrete;

namespace TechStore.Business.Concrete;

public class OrderDetailManager : GenericServiceManager<OrderDetail>, IOrderDetailService
{
    public OrderDetailManager(IOrderDetailRepository orderDetailRepository) : base(orderDetailRepository)
    {
    }
}
