using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API.DAL.Entities;

public class User
{
    [Key]
    public int Id { get; set; }
    public string Email { get; set; }
    public string Username { get; set; }
    public Role Role { get; set; }
    [JsonIgnore]
    public byte[] PasswordHash { get; set; }
    [JsonIgnore]
    public byte[] PasswordSalt { get; set; }
}
public enum Role
{
    Admin,
    Customer
}