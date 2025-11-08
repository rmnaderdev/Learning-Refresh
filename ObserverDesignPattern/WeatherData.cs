using ObserverDesignPattern.Interfaces;

namespace ObserverDesignPattern;

public class WeatherData : ISubject
{
    private List<IObserver> Observers { get; set; } = new();
    
    // State of the weather data
    public double Temperature { get; private set; }
    public double Humidity { get; private set; }
    public double Pressure { get; private set; }

    private void MeasurementsChanged()
    {
        NotifyObservers();
    }

    // TODO: Find a better way to pass this data without needing to change so much code in the future
    public void SetMeasurements(double temperature, double humidity, double pressure)
    {
        Temperature = temperature;
        Humidity = humidity;
        Pressure = pressure;
        MeasurementsChanged();
    }
    
    public void RegisterObserver(IObserver observer)
    {
        Observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        Observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        Observers.ForEach(o =>
        {
            o.Update();
        });
    }
}