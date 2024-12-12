using API.DAL.EF;
using API.DAL.Entities;
using API.DAL.Repository.Base;
using API.DAL.Repository.Interfaces;

namespace API.DAL.Repository;

public class BikeModelRepository : Repo<BikeModel, int>, IBikeModelRepository
{
    public BikeModelRepository(RentalDbContext cotnext)
        :base(cotnext)
    {
        
    }
}
