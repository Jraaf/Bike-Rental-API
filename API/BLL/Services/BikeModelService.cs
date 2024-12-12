using API.BLL.DTO;
using API.BLL.Services.Base;
using API.BLL.Services.Interfaces;
using API.DAL.Entities;
using API.DAL.Repository.Interfaces;
using AutoMapper;

namespace API.BLL.Services;

public class BikeModelService : Crud<BikeModel, CreateBikeModelDTO>, IBikeModelService
{
    public BikeModelService(IMapper mapper, IBikeModelRepository repo)
        : base(mapper, repo)
    {

    }
}
