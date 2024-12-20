﻿using API.DAL.EF;
using API.DAL.Entities;
using API.DAL.Repository.Base;
using API.DAL.Repository.Interfaces;

namespace API.DAL.Repository;

public class BrandRepository : Repo<Brand, int>, IBrandRepository
{
    public BrandRepository(RentalDbContext cotnext)
        : base(cotnext)
    {

    }
}
