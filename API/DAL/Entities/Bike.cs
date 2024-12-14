using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API.DAL.Entities;

public class Bike
{
    [Key]
    public int Id { get; set; }
    public string Description { get; set; }
    public string PhotoUrl { get; set; }
    [Column(TypeName = "decimal(5, 2)")]
    public decimal PricePerHour { get; set; }
    public BikeState State { get; set; } = BikeState.Available;
    public int BikeModelId { get; set; }
    public int RentingCenterId { get; set; }
    [JsonIgnore]
    public RentingCenter RentingCenter { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public BikeModel BikeModel { get; set; }
    [JsonIgnore]
    public ICollection<Order> Orders { get; set; }
}
public enum BikeState
{
    Available,
    InUse,
    OutOfOrder
}
