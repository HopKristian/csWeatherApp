namespace App
{
  public class Weather{
    
    public int temperature{get; set;} = 0;
    public string condition{get; set;} = "";
    public int cloudiness{get; set;} = 0;

    public Weather() // Open constructor
    {
      
    }


    public void RandomTemperature()
    {
      Random random = new Random();
      temperature = random.Next(-30, 31); // using next to get a random number between -10 and 30.
    }

    public void RandomCondition()
    {
      Random random = new Random();
      string[] conditions = {"Rain", "Snow", "Clear"};
      condition = conditions[random.Next(0, conditions.Length)]; // from the list we made, we randomize a index number based on the length of the list 0 = rain, 1 = snow and 2 = clear
    }

    public void RandomCloudiness()
    {
      Random random = new Random();
      cloudiness = random.Next(0, 100); // Random number with help from the random class, that gives us a number between 0-100%
    }

    public override string ToString() // creating a ToString method to be able to test/write out the values to the console.
        {
            return $"Todays Weather:\nTemperature: {temperature}°C\nCondition: {condition}\nCloudiness: {cloudiness}%";
        }


  } //end of class
} // end of namespace