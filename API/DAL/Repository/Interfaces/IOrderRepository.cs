using API.DAL.Entities;
using API.DAL.Repository.Base;

namespace API.DAL.Repository.Interfaces;

public interface IOrderRepository : IRepo<Order, int>
{
    Task<List<Order>> GetByBikeId(int bikeId);
    Task<List<Order>> GetMyOrders(int userid);
}
