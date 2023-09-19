namespace RealEstate.Models;

public class ListingItems
{
    public long Id { get; set; }
    public int? AddressNo { get; set; }
    public string? AddressSt { get; set; }
    public string? AddressStType { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Agent { get; set; }
    public bool IsSold { get; set; }
    public double Price { get; set; }
    // not using the Secret field
    public string? Secret { get; set; }
}
