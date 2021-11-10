using System;
using System.Collections.Generic;
using System.Text;

namespace M5Integration.Shared
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }
        public string AdditionalNote { get; set; }
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}
