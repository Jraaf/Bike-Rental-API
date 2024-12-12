using System.ComponentModel.DataAnnotations;

namespace API.DAL.Entities;

public class Brand
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public ICollection<BikeModel> BikeModels { get; set; }
}
