using API.DAL.EF;
using API.DAL.Entities;
using API.DAL.Repository.Base;
using API.DAL.Repository.Interfaces;

namespace API.DAL.Repository;

public class OrderRepository : Repo<Order, int>, IOrderRepository
{
    public OrderRepository(RentalDbContext context)
        : base(context)
    {

    }
}
