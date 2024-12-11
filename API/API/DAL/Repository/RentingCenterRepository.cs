﻿using API.DAL.EF;
using API.DAL.Entities;
using API.DAL.Repository.Base;
using API.DAL.Repository.Interfaces;

namespace API.DAL.Repository;

public class RentingCenterRepository : Repo<RentingCenter, int>, IRentingCenterRepository
{
    public RentingCenterRepository(RentalDbContext context)
        : base(context)
    {

    }
}
