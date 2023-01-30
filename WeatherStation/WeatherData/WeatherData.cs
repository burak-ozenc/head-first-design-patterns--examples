using System.Collections;
using WeatherStation.Interfaces;

namespace WeatherStation.WeatherData;

public class WeatherData : ISubject
{
    private ArrayList observers;
    private float temperature;
    private float humidity;
    private float pressure;

    public WeatherData()
    {
        this.observers = new ArrayList();
    }

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        int i = observers.IndexOf(observer);
        if (i >= 0)
            observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        for (int i = 0; i < observers.Count; i++)
        {
            IObserver observer = (IObserver)observers[i]!;
            observer.Update(temperature,humidity,pressure);
        }
    }

    public void MeasurementsChanged()
    {
        NotifyObservers();
    }

    public void SetMeasurements(float temp, float humid, float press)
    {
        this.temperature = temp;
        this.humidity = humid;
        this.pressure = press;
        MeasurementsChanged();
    }
}