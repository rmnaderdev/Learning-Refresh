namespace ObserverDesignPattern;

class Program
{
    static void Main(string[] args)
    {
        WeatherData weatherData = new WeatherData();
        
        CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
        StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
        
        weatherData.SetMeasurements(80, 65, 30.4);
        weatherData.SetMeasurements(82, 70, 29.2);
        weatherData.SetMeasurements(78, 90, 29.2);
    }
}