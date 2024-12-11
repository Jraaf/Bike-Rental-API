using System.ComponentModel.DataAnnotations;

namespace API.DAL.Entities;

public class UserHistory
{
    [Key]
    public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public ICollection<Bike> Bikes { get; set; }
}
