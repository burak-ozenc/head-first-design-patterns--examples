// See https://aka.ms/new-console-template for more information

using WeatherStation;
using WeatherStation.Display;
using WeatherStation.WeatherData;

WeatherData weatherData = new WeatherData();
{
    CurrentConditionDisplay currentDisplay = new CurrentConditionDisplay(weatherData);
    
    weatherData.SetMeasurements(52,23,43.2f);
    weatherData.SetMeasurements(42,13,33.2f);
    weatherData.SetMeasurements(62,33,53.2f);
    
}