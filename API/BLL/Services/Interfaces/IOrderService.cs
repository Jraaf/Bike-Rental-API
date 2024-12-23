﻿using API.BLL.DTO;
using API.BLL.Services.Base;
using API.DAL.Entities;

namespace API.BLL.Services.Interfaces;

public interface IOrderService : ICrud<Order, CreateOrderDTO>
{
    Task<List<Order>> GetByBikeId(int bikeId);
    Task<List<Order>> GetMyOrders(int userId);
}
