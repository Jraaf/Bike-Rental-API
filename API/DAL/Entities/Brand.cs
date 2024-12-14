using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace API.DAL.Entities;

public class Brand
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    [JsonIgnore]
    public ICollection<BikeModel> BikeModels { get; set; }
}
