using System.ComponentModel.DataAnnotations.Schema;

namespace API.BLL.DTO;

public class CreateRentingCenterDTO
{
    public decimal Latitude { get; set; }
    public decimal Longitude { get; set; }
}
