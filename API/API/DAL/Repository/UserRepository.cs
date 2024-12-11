using API.DAL.EF;
using API.DAL.Entities;
using API.DAL.Repository.Base;
using API.DAL.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.DAL.Repository;

public class UserRepository:Repo<User,int>,IUserRepository
{
    private readonly RentalDbContext _context;
    public UserRepository(RentalDbContext context)
        : base(context)
    {
        _context = context;
    }
    public async Task<User?> GetByUsername(string username)
    {
        return await _context.Users.FirstOrDefaultAsync(x =>
                     x.Username.ToLower() == username.ToLower());
    }

    public async Task<bool> UserExists(string username)
    {
        return await _context.Users.AnyAsync(x =>
            x.Username.ToLower() == username.ToLower());
    }
}
