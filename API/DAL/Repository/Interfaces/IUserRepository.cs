using API.DAL.Entities;
using API.DAL.Repository.Base;

namespace API.DAL.Repository.Interfaces;

public interface IUserRepository: IRepo<User, int>
{
    Task<bool> UserExists(string username);
    Task<User> GetByUsername(string username);
}
