
public class Restaurant
{
    // declare variables using data hiding
    private int Rating;
    private string RestName;
    private string RestType;

//  Constructs
    public Restaurant()
    {   
      RestName = "undefined name";  
      Rating = -1;
      RestType = "undefined type";     
    }

    public Restaurant(int rating, string name, string type)
    {
        RestName = name; 
        Rating = rating;
        RestType = type;

    }
    public Restaurant(string name)
    {
        RestName  = name;
    }

    public Restaurant(int rating)
    {
        Rating = rating;
    }

    public Restaurant(string cuisine, string service)
    {
        RestType = (cuisine + " -  " + service);
    }

    public string getRestName()
    {
     return RestName;
    }
    public int getRating()
    {
     return Rating;
    }
        public string getRestType()
    {
     return RestType;
    }
}