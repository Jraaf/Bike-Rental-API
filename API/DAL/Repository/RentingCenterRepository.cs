using API.DAL.EF;
using API.DAL.Entities;
using API.DAL.Repository.Base;
using API.DAL.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace API.DAL.Repository;

public class RentingCenterRepository : Repo<RentingCenter, int>, IRentingCenterRepository
{
    private readonly RentalDbContext context;

    public RentingCenterRepository(RentalDbContext context)
        : base(context)
    {
        this.context = context;
    }
    public async new Task<List<RentingCenter>> GetAllAsync()
    {
        return await context.Centers
            .Include(c=>c.Bikes)
            .ToListAsync();
    }

    public async Task<List<RentingCenter>> GetByBikeId(int bikeId)
    {
        return await context.Centers
            .Include (c=>c.Bikes)
            .Where(c=>c.Bikes
            .Any(b=>b.Id == bikeId))
            .ToListAsync();
    }
}
