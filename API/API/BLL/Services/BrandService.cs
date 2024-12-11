using API.BLL.DTO;
using API.BLL.Services.Base;
using API.BLL.Services.Interfaces;
using API.DAL.Entities;
using API.DAL.Repository;
using API.DAL.Repository.Interfaces;
using AutoMapper;

namespace API.BLL.Services;

public class BrandService : Crud<Brand, CreateBrandDTO>, IBrandService
{
    public BrandService(IMapper mapper, IBrandRepository repo)
        : base(mapper, repo)
    {

    }
}
