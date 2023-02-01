using Observer.WeatherStation.Interfaces;

namespace Observer.WeatherStation.Display;

public class CurrentConditionDisplay : IObserver, IDisplayElement
{
    private float temperature;
    private float humidity;
    private ISubject weatherData;

    public CurrentConditionDisplay(ISubject weatherData)
    {
        this.weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    public void Update(float temperature, float humidity, float pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        Display();
    }

    public void Display()
    {
        Console.WriteLine("Current conditions: " + temperature + "C degrees and " + humidity + "% humidity.");
    }
}