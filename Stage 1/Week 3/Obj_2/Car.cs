
// Car.cs
public class Car
{
    public string Make { get; set; }
    public string Color { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Car(string make, string color, string model, int year)
    {
        this.Make = make;
        this.Color = color;
        this.Model = model;
        this.Year = year;
    }
}