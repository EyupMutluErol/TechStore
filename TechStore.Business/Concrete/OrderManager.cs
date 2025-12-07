using TechStore.Business.Abstract;
using TechStore.DataAccess.Abstract;
using TechStore.Entities.Concrete;

namespace TechStore.Business.Concrete;

public class OrderManager : GenericServiceManager<Order>, IOrderService
{
    public OrderManager(IOrderRepository orderRepository) : base(orderRepository)
    {
    }
}
