using NetCore.DemoLibs;
using NetCore.Module.FileProcessing;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        string filePath = Path.Combine("NetCore.Data", "WeatherForecastData.json");
        var ts = JsonFile.ReadJsonFileBy<WeatherForecastModel>("~/../../../../../../NetCore.Data/WeatherForecastData.json");
        foreach (var item in ts.datas)
        {
            Console.WriteLine(item);
        }
    }
}
