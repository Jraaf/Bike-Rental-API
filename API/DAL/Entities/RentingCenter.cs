using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API.DAL.Entities;

public class RentingCenter
{
    [Key]
    public int Id { get; set; }
    [Column(TypeName = "decimal(9, 6)")]
    public decimal Latitude { get; set; }
    [Column(TypeName = "decimal(9, 6)")]

    public decimal Longitude { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public ICollection<Bike> Bikes { get; set; }
}
