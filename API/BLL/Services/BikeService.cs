using API.BLL.DTO;
using API.BLL.Services.Base;
using API.BLL.Services.Interfaces;
using API.DAL.Entities;
using API.DAL.Repository.Interfaces;
using AutoMapper;
using Azure.Core.Pipeline;

namespace API.BLL.Services;

public class BikeService : Crud<Bike, CreateBikeDTO>, IBikeService
{
    public BikeService(IMapper mapper, IBikeRepository repo)
        : base(mapper, repo)
    {

    }
    public async new Task<Bike> AddAsync(CreateBikeDTO dto)
    {
        if (dto.State < 0 || dto.State > 2)
        {
            dto.State = 0;
        }
        return await base.AddAsync(dto);
    }
    public async new Task<Bike> UpdateByIdAsync(int id, CreateBikeDTO dto)
    {
        if (dto.State < 0 || dto.State > 2)
        {
            dto.State = 0;
        }
        return await base.UpdateByIdAsync(id, dto);
    }
}
