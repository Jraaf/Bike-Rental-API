using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.DAL.Entities;

public class Order
{
    [Key]
    public int Id { get; set; }
    [Column(TypeName = "decimal(5, 2)")]
    public decimal ToPay { get; set; }
    public int UserId { get; set; }
    public int BikeId { get; set; }
    public User User { get; set; }
    public Bike Bike { get; set; }
}
