// Class Declaration
public class Dog {
 
    // Instance Variables
    String name;
    String breed;
    int age;
    String color;
 
    // Constructor Declaration of Class
    public Dog(String name, String breed, int age, String color)
    {
        this.name = name;
        this.breed = breed;
        this.age = age;
        this.color = color;
    }
 
    // Property 1
    public String GetName()
    {
        return name;
    }
 
    // Property 2
    public String GetBreed()
    {
        return breed;
    }
 
    // Property 3
    public int GetAge()
    {
        return age;
    }
 
    // Property 4
    public String GetColor()
    {
        return color;
    }
 
    // Method 1
    public String ToString()
    {
        return ("Hi my name is " + this.GetName()
                + ".\nMy breed, age and color are " + this.GetBreed()
                + ", " + this.GetAge() + ", " + this.GetColor());
    }
}