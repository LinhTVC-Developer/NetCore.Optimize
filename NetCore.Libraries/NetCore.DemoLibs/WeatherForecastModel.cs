using System.Text.Json.Serialization;

namespace NetCore.DataTest
{
    public class WeatherForecastModel
    {
        [JsonPropertyName("datas")]
        public List<string> datas { get; set; } = new List<string>();
    }
}
