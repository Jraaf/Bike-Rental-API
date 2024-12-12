using API.BLL.DTO;
using API.BLL.Services.Base;
using API.BLL.Services.Interfaces;
using API.DAL.Entities;
using API.DAL.Repository.Interfaces;
using AutoMapper;

namespace API.BLL.Services;

public class BikeService : Crud<Bike, CreateBikeDTO>, IBikeService
{
    public BikeService(IMapper mapper, IBikeRepository repo)
        : base(mapper, repo)
    {

    }
}
