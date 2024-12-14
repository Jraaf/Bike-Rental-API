using API.BLL.DTO;
using API.BLL.Services.Base;
using API.BLL.Services.Interfaces;
using API.DAL.Entities;
using API.DAL.Repository.Interfaces;
using AutoMapper;

namespace API.BLL.Services;

public class RentingCenterService : Crud<RentingCenter, CreateRentingCenterDTO>, IRentingCenterService
{
    private readonly IMapper mapper;
    private readonly IRentingCenterRepository repo;

    public RentingCenterService(IMapper mapper, IRentingCenterRepository repo)
        : base(mapper, repo)
    {
        this.mapper = mapper;
        this.repo = repo;
    }

    public async Task<List<RentingCenter>> GetByBikeId(int bikeId)
    {
        return await repo.GetByBikeId(bikeId);
    }
}
