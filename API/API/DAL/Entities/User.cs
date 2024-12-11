using System.ComponentModel.DataAnnotations;

namespace API.DAL.Entities;

public class User
{
    [Key]
    public int Id { get; set; }
    public string Email { get; set; }
    public string Username { get; set; }
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
}
