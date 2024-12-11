using API.DAL.EF;
using API.DAL.Entities;
using API.DAL.Repository.Base;
using API.DAL.Repository.Interfaces;

namespace API.DAL.Repository;

public class BikeRepository : Repo<Bike, int>, IBikeRepository
{
    public BikeRepository(RentalDbContext context)
        : base(context)
    {

    }
}
