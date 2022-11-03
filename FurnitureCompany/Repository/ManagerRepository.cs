using FurnitureCompany.Data;
using FurnitureCompany.IRepository;
using FurnitureCompany.Models;

namespace FurnitureCompany.Repository
{
    public class ManagerRepository : IManagerRepository
    {
        private FurnitureCompanyContext furnitureCompanyContext;
        public ManagerRepository(FurnitureCompanyContext furnitureCompanyContext)
        {
            this.furnitureCompanyContext = furnitureCompanyContext;
        }
        public List<Order> getAllOrder()
        {
            List<Order> listOrderbyManager = furnitureCompanyContext.Orders.ToList();
            return listOrderbyManager;
        }

        public void updateOrderStatus(Order order)
        {
            throw new NotImplementedException();
        }

       
    }
}
