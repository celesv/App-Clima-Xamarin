namespace App_Clima_Proyecto.Models
{

    public class WeatherData
    {
        public decimal latitude { get; set; }
        public decimal longitude { get; set; }
        public string timezone { get; set; }
        public decimal offset { get; set; }
        public decimal elevation { get; set; }
        public Currently currently { get; set; }
        public Minutely minutely { get; set; }
        public Hourly hourly { get; set; }
        public Daily daily { get; set; }
        public Flags flags { get; set; }
    }

    public class Currently
    {
        public int time { get; set; }
        public string summary { get; set; }
        public string icon { get; set; }
        public decimal nearestStormDistance { get; set; }
        public decimal nearestStormBearing { get; set; }
        public decimal precipIntensity { get; set; }
        public decimal precipProbability { get; set; }
        public decimal precipIntensityError { get; set; }
        public string precipType { get; set; }
        public decimal temperature { get; set; }
        public decimal apparentTemperature { get; set; }
        public decimal dewPoint { get; set; }
        public decimal humidity { get; set; }
        public decimal pressure { get; set; }
        public decimal windSpeed { get; set; }
        public decimal windGust { get; set; }
        public decimal windBearing { get; set; }
        public decimal cloudCover { get; set; }
        public decimal uvIndex { get; set; }
        public decimal visibility { get; set; }
        public decimal ozone { get; set; }
    }

    public class Minutely
    {
        public string summary { get; set; }
        public string icon { get; set; }
        public Datum[] data { get; set; }
    }

    public class Datum
    {
        public int time { get; set; }
        public decimal precipIntensity { get; set; }
        public decimal precipProbability { get; set; }
        public decimal precipIntensityError { get; set; }
        public string precipType { get; set; }
    }

    public class Hourly
    {
        public string summary { get; set; }
        public string icon { get; set; }
        public Datum1[] data { get; set; }
    }

    public class Datum1
    {
        public int time { get; set; }
        public string icon { get; set; }
        public string summary { get; set; }
        public decimal precipIntensity { get; set; }
        public decimal precipProbability { get; set; }
        public decimal precipIntensityError { get; set; }
        public decimal precipAccumulation { get; set; }
        public string precipType { get; set; }
        public decimal temperature { get; set; }
        public decimal apparentTemperature { get; set; }
        public decimal dewPoint { get; set; }
        public decimal humidity { get; set; }
        public decimal pressure { get; set; }
        public decimal windSpeed { get; set; }
        public decimal windGust { get; set; }
        public decimal windBearing { get; set; }
        public decimal cloudCover { get; set; }
        public decimal uvIndex { get; set; }
        public decimal visibility { get; set; }
        public decimal ozone { get; set; }
    }

    public class Daily
    {
        public string summary { get; set; }
        public string icon { get; set; }
        public Datum2[] data { get; set; }
    }

    public class Datum2
    {
        public int time { get; set; }
        public string icon { get; set; }
        public string summary { get; set; }
        public int sunriseTime { get; set; }
        public int sunsetTime { get; set; }
        public decimal moonPhase { get; set; }
        public decimal precipIntensity { get; set; }
        public decimal precipIntensityMax { get; set; }
        public int precipIntensityMaxTime { get; set; }
        public decimal precipProbability { get; set; }
        public decimal precipAccumulation { get; set; }
        public string precipType { get; set; }
        public decimal temperatureHigh { get; set; }
        public int temperatureHighTime { get; set; }
        public decimal temperatureLow { get; set; }
        public int temperatureLowTime { get; set; }
        public decimal apparentTemperatureHigh { get; set; }
        public int apparentTemperatureHighTime { get; set; }
        public decimal apparentTemperatureLow { get; set; }
        public int apparentTemperatureLowTime { get; set; }
        public decimal dewPoint { get; set; }
        public decimal humidity { get; set; }
        public decimal pressure { get; set; }
        public decimal windSpeed { get; set; }
        public decimal windGust { get; set; }
        public int windGustTime { get; set; }
        public decimal windBearing { get; set; }
        public decimal cloudCover { get; set; }
        public decimal uvIndex { get; set; }
        public int uvIndexTime { get; set; }
        public decimal visibility { get; set; }
        public decimal temperatureMin { get; set; }
        public int temperatureMinTime { get; set; }
        public decimal temperatureMax { get; set; }
        public int temperatureMaxTime { get; set; }
        public decimal apparentTemperatureMin { get; set; }
        public int apparentTemperatureMinTime { get; set; }
        public decimal apparentTemperatureMax { get; set; }
        public int apparentTemperatureMaxTime { get; set; }
    }

    public class Flags
    {
        public string[] sources { get; set; }
        public Sourcetimes sourceTimes { get; set; }
        public decimal neareststation { get; set; }
        public string units { get; set; }
        public string version { get; set; }
    }

    public class Sourcetimes
    {
        public string gfs { get; set; }
        public string gefs { get; set; }
    }
}
