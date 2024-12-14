using API.DAL.EF;
using API.DAL.Entities;
using API.DAL.Repository.Base;
using API.DAL.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.DAL.Repository;

public class OrderRepository : Repo<Order, int>, IOrderRepository
{
    private readonly RentalDbContext context;

    public OrderRepository(RentalDbContext context)
        : base(context)
    {
        this.context = context;
    }
    public async new Task<List<Order>> GetAllAsync()
    {
        return await context.Orders
                    .Include(o => o.User)
                    .Include(o => o.Bike)
                    .ToListAsync();
    }
    public async new Task<Order?> GetAsync(int Id)
    {
        return await context.Orders
                    .Include(o => o.User)
                    .Include(o => o.Bike)
                    .FirstOrDefaultAsync(o => o.Id == Id);
    }

    public async Task<List<Order>> GetByBikeId(int bikeId)
    {
        return await context.Orders
            .Include(o => o.User)
            .Where(o => o.BikeId == bikeId)
            .ToListAsync();
    }
}
