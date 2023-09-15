//TodoItems.cs in Models
namespace RealEstate.Models;
//namespace TodoApi.Models;

public class ListingItems
{
    public long Id { get; set; }
    public string? Name { get; set; }

    public string? Worker { get; set; }
    public bool IsComplete { get; set; }

    public string? Secret { get; set; }
}
