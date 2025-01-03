using NetCore.DataTest;
using NetCore.Module.FileProcessing;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var ts = JsonFile.ReadJsonFileBy<WeatherForecastModel>("~/../../../../WeatherForecastData.json");
        foreach (var item in ts.datas)
        {
            Console.WriteLine(item);
        }
    }
}
