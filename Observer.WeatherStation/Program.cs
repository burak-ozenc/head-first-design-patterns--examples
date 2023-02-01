// See https://aka.ms/new-console-template for more information

using Observer.WeatherStation;
using Observer.WeatherStation.Display;
using Observer.WeatherStation.WeatherData;

WeatherData weatherData = new WeatherData();
{
    Console.WriteLine("Start with one observer");
    CurrentConditionDisplay currentDisplay = new CurrentConditionDisplay(weatherData);
    
    weatherData.SetMeasurements(52,23,43.2f);
    
    Console.WriteLine();
    Console.WriteLine();
    
    Console.WriteLine("Another observer added");
    CurrentConditionDisplay currentDisplay2 = new CurrentConditionDisplay(weatherData);
    
    weatherData.SetMeasurements(32,53,23.2f);
    
    Console.WriteLine();
    Console.WriteLine();
    
    Console.WriteLine("One observer removed");
    weatherData.RemoveObserver(currentDisplay2);
    
    weatherData.SetMeasurements(42,13,33.2f);
}