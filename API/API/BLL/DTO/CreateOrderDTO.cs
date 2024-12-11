namespace API.BLL.DTO;

public class CreateOrderDTO
{
    public decimal ToPay { get; set; }
    public int UserId { get; set; }
    public int BikeId { get; set; }
}
