using API.BLL.DTO;
using API.DAL.Entities;
using AutoMapper;

namespace API.BLL;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<CreateBikeDTO, Bike>();
        CreateMap<CreateBikeModelDTO,BikeModel>();
        CreateMap<CreateBrandDTO,Brand>();
        CreateMap<CreateOrderDTO,Order>();
        CreateMap<CreateRentingCenterDTO,RentingCenter>();
        CreateMap<User, UserDTO>();
    }
}
