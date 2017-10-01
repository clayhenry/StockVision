using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StockVision.Models
{
        public class Alphavantage
    {
        [JsonProperty("Meta Data")]
        public MetaData MetaData { get; set; }

        [JsonProperty("Time Series (1min)")]
        public Dictionary<string, TimeSeries> TimeSeries1min { get; set; }
    }

    public class MetaData
    {
        [JsonProperty("2. Symbol")]
        public string Symbol { get; set; }

        [JsonProperty("4. Interval")]
        public string Interval { get; set; }

        [JsonProperty("1. Information")]
        public string Information { get; set; }

        [JsonProperty("3. Last Refreshed")]
        public DateTime LastRefreshed { get; set; }

        [JsonProperty("5. Output Size")]
        public string OutputSize { get; set; }

        [JsonProperty("6. Time Zone")]
        public string TimeZone { get; set; }
    }

    public class TimeSeries
    {
        [JsonProperty("2. high")]
        public float High { get; set; }

        [JsonProperty("4. close")]
        public float Close { get; set; }

        [JsonProperty("1. open")]
        public float Open { get; set; }

        [JsonProperty("3. low")]
        public float Low { get; set; }

        [JsonProperty("5. volume")]
        public float Volume { get; set; }
    }
}