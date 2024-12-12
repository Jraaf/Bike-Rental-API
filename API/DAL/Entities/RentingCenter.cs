using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.DAL.Entities;

public class RentingCenter
{
    [Key]
    public int Id { get; set; }
    [Column(TypeName = "decimal(9, 6)")]
    public decimal Latitude { get; set; }
    [Column(TypeName = "decimal(9, 6)")]

    public decimal Longitude { get; set; }
    public ICollection<Bike> Bikes { get; set; }
}
