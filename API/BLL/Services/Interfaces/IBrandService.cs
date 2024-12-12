using API.BLL.DTO;
using API.BLL.Services.Base;
using API.Controllers;
using API.DAL.Entities;

namespace API.BLL.Services.Interfaces
{
    public interface IBrandService : ICrud<Brand, CreateBrandDTO>
    {
    }
}
