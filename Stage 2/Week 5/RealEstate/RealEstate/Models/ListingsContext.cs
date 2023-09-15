// ListingsContext.cs in Models
using Microsoft.EntityFrameworkCore;
using RealEstate.Models;

//namespace RealEstate.Models;
namespace TodoApi.Models;

public class ListingsContext : DbContext
{
    public ListingsContext(DbContextOptions<ListingsContext> options)
        : base(options)
    {
    }

    public DbSet<ListingItems> ListingsItems { get; set; } = null!;
}