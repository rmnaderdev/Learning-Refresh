using ObserverDesignPattern.Interfaces;

namespace ObserverDesignPattern;

public class CurrentConditionsDisplay : IObserver, IDisplayElement
{
    private readonly WeatherData _weatherData;
    private double _currentTemperature;
    private double _currentHumidity;

    public CurrentConditionsDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }
    
    public void Update()
    {
        _currentTemperature = _weatherData.Temperature;
        _currentHumidity = _weatherData.Humidity;
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Current conditions: {_currentTemperature} F degrees and {_currentHumidity} % humidity");
    }
}