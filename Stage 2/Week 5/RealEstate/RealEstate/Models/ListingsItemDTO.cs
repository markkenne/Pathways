//PropertyItemDTO.cs
//namespace TodoApi.Models;
namespace RealEstate.Models;

public class ListingsItemDTO
{
    public long Id { get; set; }
    public string? Name { get; set; }

    public string? Worker { get; set; }
    public bool IsComplete { get; set; }

}