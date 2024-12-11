using API.DAL.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.BLL.DTO;

public class CreateBikeDTO
{
    public string Description { get; set; }
    public string PhotoUrl { get; set; }
    public decimal PricePerHour { get; set; }
    public int BikeModelId { get; set; }
    public int RentingCenterId { get; set; }
}
