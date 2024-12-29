using System;
namespace App
{
  class Program
  {
    static void Main(string[] args)
    {

      //Creating an object holding the random values
      Weather weather = new Weather();
      weather.RandomTemperature();
      weather.RandomCondition();
      weather.RandomCloudiness();

      if (weather.temperature < -10 && weather.condition == "Snow") // if temp is lower than -10 and the its snowy then dont go outside
      {
        Console.WriteLine($"Warning: It's extremely cold with a temperature of {weather.temperature}°C and it is also very snowy. Dont go outside!"); 
      } else{ // every other weather will just write out the ToString method from the weather class, printing out their respective values
        Console.WriteLine(weather.ToString());
      }



    } // end of main
  } // end of class
} // end of namespace
