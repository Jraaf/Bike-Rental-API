using API.DAL.EF;
using API.DAL.Entities;
using API.DAL.Repository.Base;
using API.DAL.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.DAL.Repository;

public class BikeRepository : Repo<Bike, int>, IBikeRepository
{
    private readonly RentalDbContext context;

    public BikeRepository(RentalDbContext context)
        : base(context)
    {
        this.context = context;
    }
    public async new Task<List<Bike>> GetAllAsync()
    {
        return await context.Bikes
            .Include(b=>b.BikeModel)
                .ThenInclude(b=>b.Brand)
            .Include(b=>b.RentingCenter)
            .OrderBy(b=>b.State)
            .ToListAsync();
    }
}
