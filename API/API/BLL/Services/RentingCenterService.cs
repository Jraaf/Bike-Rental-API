using API.BLL.DTO;
using API.BLL.Services.Base;
using API.BLL.Services.Interfaces;
using API.DAL.Entities;
using API.DAL.Repository.Interfaces;
using AutoMapper;

namespace API.BLL.Services;

public class RentingCenterService : Crud<RentingCenter, CreateRentingCenterDTO>, IRentingCenterService
{
    public RentingCenterService(IMapper mapper, IRentingCenterRepository repo)
        : base(mapper, repo)
    {

    }
}
