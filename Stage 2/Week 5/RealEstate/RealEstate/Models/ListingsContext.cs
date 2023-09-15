// ListingsContext.cs in Models
using Microsoft.EntityFrameworkCore;
using RealEstate.Models;

namespace TodoApi.Models;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
    {
    }

    public DbSet<ListingItems> ListingsItems { get; set; } = null!;
}