using ObserverDesignPattern.Interfaces;

namespace ObserverDesignPattern;

public class StatisticsDisplay : IObserver, IDisplayElement
{
    private readonly WeatherData _weatherData;
    private double _currentTemperature;
    
    // Statistics state
    private List<double> _temperatures = new();
    private double _averageTemperature = 0;
    private double _minTemperature = 0;
    private double _maxTemperature = 0;
    

    public StatisticsDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        _weatherData.RegisterObserver(this);
    }
    
    public void Update(double temperature, double humidity, double pressure)
    {
        _currentTemperature = temperature;
        _temperatures.Add(temperature);
        
        // Compute the statistics with every update
        _averageTemperature = _temperatures.Average();
        _minTemperature = _temperatures.Min();
        _maxTemperature = _temperatures.Max();
        
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Avg/Max/Min temperature = {_averageTemperature:F1}/{_maxTemperature:F1}/{_minTemperature:F1}");
    }
}