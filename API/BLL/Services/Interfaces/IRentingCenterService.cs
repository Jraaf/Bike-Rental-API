using API.BLL.DTO;
using API.BLL.Services.Base;
using API.DAL.Entities;

namespace API.BLL.Services.Interfaces;

public interface IRentingCenterService : ICrud<RentingCenter, CreateRentingCenterDTO>
{
    Task<List<RentingCenter>> GetByBikeId(int bikeId);
}
