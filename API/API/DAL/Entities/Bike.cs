using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.DAL.Entities;

public class Bike
{
    [Key]
    public int Id { get; set; }
    public string Description { get; set; }
    public string PhotoUrl { get; set; }
    [Column(TypeName = "decimal(5, 2)")]
    public decimal PricePerHour { get; set; }
    public BikeState State { get; set; }
    public int BikeModelId { get; set; }
    public int RentingCenterId { get; set; }
    public BikeModel BikeModel { get; set; }
    public ICollection<UserHistory> UserHistories { get; set; }
}
public enum BikeState
{
    Available,
    InUse,
    OutOfOrder
}
