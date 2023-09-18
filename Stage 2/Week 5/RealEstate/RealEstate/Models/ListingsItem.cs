﻿//TodoItems.cs in Models
namespace RealEstate.Models;

public class ListingItems
{
    public long Id { get; set; }
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }

    public string? Agent { get; set; }
    public bool IsSold { get; set; }

    public string? Price { get; set; }

    public string? Secret { get; set; }
}
