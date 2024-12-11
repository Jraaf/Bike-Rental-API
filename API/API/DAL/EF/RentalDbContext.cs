using API.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.DAL.EF;

public class RentalDbContext : DbContext
{
    public RentalDbContext(DbContextOptions<RentalDbContext> options)
        : base(options)
    {

    }
    public DbSet<Bike> Bikes { get; set; }
    public DbSet<BikeModel> Models { get; set; }
    public DbSet<Brand> Brands { get; set; }
    public DbSet<RentingCenter> Centers { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserHistory> UserHistories { get; set; }
}
