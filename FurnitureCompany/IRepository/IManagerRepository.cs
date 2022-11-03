using FurnitureCompany.Models;

namespace FurnitureCompany.IRepository
{
    public interface IManagerRepository
    {
        public List<Order> getAllOrder();
        public void updateOrderStatus(Order order);
    }
}
