using API.BLL.DTO;
using API.BLL.Services.Base;
using API.BLL.Services.Interfaces;
using API.DAL.Entities;
using API.DAL.Repository.Interfaces;
using AutoMapper;

namespace API.BLL.Services;

public class OrderService : Crud<Order, CreateOrderDTO>, IOrderService
{
    public OrderService(IMapper mapper, IOrderRepository repo)
        : base(mapper, repo)
    {

    }
}
