using API.DAL.Entities;
using API.DAL.Repository.Base;

namespace API.DAL.Repository.Interfaces;

public interface IRentingCenterRepository : IRepo<RentingCenter, int>
{
    Task<List<RentingCenter>> GetByBikeId(int bikeId);
}
