// Create a Car class property with constructor overloads
public class Car
{

// set variables
    public int Year;
    public string Model;
    public string Make;
    public string Color;
    public int Price;

    // constructor with one string param
    public Car(string make, int price) 
    {
      Make = make;
      Price = price;
    }
   // constructor with one string param
    public Car(string color)
    {
      Color = color;
    }
   // constructor with one int, 3 strings, and another int param
    public Car(int year, string make, string model, string color, int price)
    {
      Year = year;
      Make = make;
      Model = model;
      Color = color;
      Price = price;
    }



}
