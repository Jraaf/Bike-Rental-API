﻿using API.BLL.DTO;
using API.BLL.Services.Base;
using API.DAL.Entities;

namespace API.BLL.Services.Interfaces
{
    public interface IBikeModelService:ICrud<BikeModel,CreateBikeModelDTO>
    {
    }
}
