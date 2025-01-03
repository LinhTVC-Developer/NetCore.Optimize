using System.Text.Json.Serialization;

namespace NetCore.DemoLibs
{
    public class WeatherForecastModel
    {
        [JsonPropertyName("datas")]
        public List<string> datas { get; set; } = new List<string>();
    }
}
