using API.DAL.Entities;

namespace API.BLL.DTO;

public class UserDTO
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string AccessToken { get; set; }
    public Role Role { get; set; }
}
