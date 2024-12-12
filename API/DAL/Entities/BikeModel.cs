﻿namespace API.DAL.Entities;

public class BikeModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int BrandId { get; set; }
    public Brand Brand { get; set; }
    public ICollection<Bike> Bikes { get; set; }
}