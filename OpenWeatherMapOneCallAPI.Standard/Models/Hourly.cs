// <copyright file="Hourly.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenWeatherMapOneCallAPI.Standard;
using OpenWeatherMapOneCallAPI.Standard.Utilities;

namespace OpenWeatherMapOneCallAPI.Standard.Models
{
    /// <summary>
    /// Hourly.
    /// </summary>
    public class Hourly
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Hourly"/> class.
        /// </summary>
        public Hourly()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Hourly"/> class.
        /// </summary>
        /// <param name="lat">lat.</param>
        /// <param name="lon">lon.</param>
        /// <param name="tz">tz.</param>
        /// <param name="date">date.</param>
        /// <param name="units">units.</param>
        /// <param name="cloudCover">cloud_cover.</param>
        /// <param name="humidity">humidity.</param>
        /// <param name="precipitation">precipitation.</param>
        /// <param name="temperature">temperature.</param>
        /// <param name="pressure">pressure.</param>
        /// <param name="wind">wind.</param>
        public Hourly(
            double? lat = null,
            double? lon = null,
            string tz = null,
            DateTime? date = null,
            string units = null,
            Models.CloudCover cloudCover = null,
            Models.Humidity humidity = null,
            Models.Precipitation precipitation = null,
            Models.Temperature temperature = null,
            Models.Pressure pressure = null,
            Models.Wind wind = null)
        {
            this.Lat = lat;
            this.Lon = lon;
            this.Tz = tz;
            this.Date = date;
            this.Units = units;
            this.CloudCover = cloudCover;
            this.Humidity = humidity;
            this.Precipitation = precipitation;
            this.Temperature = temperature;
            this.Pressure = pressure;
            this.Wind = wind;
        }

        /// <summary>
        /// Gets or sets Lat.
        /// </summary>
        [JsonProperty("lat", NullValueHandling = NullValueHandling.Ignore)]
        public double? Lat { get; set; }

        /// <summary>
        /// Gets or sets Lon.
        /// </summary>
        [JsonProperty("lon", NullValueHandling = NullValueHandling.Ignore)]
        public double? Lon { get; set; }

        /// <summary>
        /// Gets or sets Tz.
        /// </summary>
        [JsonProperty("tz", NullValueHandling = NullValueHandling.Ignore)]
        public string Tz { get; set; }

        /// <summary>
        /// Gets or sets Date.
        /// </summary>
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy'-'MM'-'dd")]
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Gets or sets Units.
        /// </summary>
        [JsonProperty("units", NullValueHandling = NullValueHandling.Ignore)]
        public string Units { get; set; }

        /// <summary>
        /// Gets or sets CloudCover.
        /// </summary>
        [JsonProperty("cloud_cover", NullValueHandling = NullValueHandling.Ignore)]
        public Models.CloudCover CloudCover { get; set; }

        /// <summary>
        /// Gets or sets Humidity.
        /// </summary>
        [JsonProperty("humidity", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Humidity Humidity { get; set; }

        /// <summary>
        /// Gets or sets Precipitation.
        /// </summary>
        [JsonProperty("precipitation", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Precipitation Precipitation { get; set; }

        /// <summary>
        /// Gets or sets Temperature.
        /// </summary>
        [JsonProperty("temperature", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Temperature Temperature { get; set; }

        /// <summary>
        /// Gets or sets Pressure.
        /// </summary>
        [JsonProperty("pressure", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Pressure Pressure { get; set; }

        /// <summary>
        /// Gets or sets Wind.
        /// </summary>
        [JsonProperty("wind", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Wind Wind { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Hourly : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Hourly other &&
                (this.Lat == null && other.Lat == null ||
                 this.Lat?.Equals(other.Lat) == true) &&
                (this.Lon == null && other.Lon == null ||
                 this.Lon?.Equals(other.Lon) == true) &&
                (this.Tz == null && other.Tz == null ||
                 this.Tz?.Equals(other.Tz) == true) &&
                (this.Date == null && other.Date == null ||
                 this.Date?.Equals(other.Date) == true) &&
                (this.Units == null && other.Units == null ||
                 this.Units?.Equals(other.Units) == true) &&
                (this.CloudCover == null && other.CloudCover == null ||
                 this.CloudCover?.Equals(other.CloudCover) == true) &&
                (this.Humidity == null && other.Humidity == null ||
                 this.Humidity?.Equals(other.Humidity) == true) &&
                (this.Precipitation == null && other.Precipitation == null ||
                 this.Precipitation?.Equals(other.Precipitation) == true) &&
                (this.Temperature == null && other.Temperature == null ||
                 this.Temperature?.Equals(other.Temperature) == true) &&
                (this.Pressure == null && other.Pressure == null ||
                 this.Pressure?.Equals(other.Pressure) == true) &&
                (this.Wind == null && other.Wind == null ||
                 this.Wind?.Equals(other.Wind) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Lat = {(this.Lat == null ? "null" : this.Lat.ToString())}");
            toStringOutput.Add($"Lon = {(this.Lon == null ? "null" : this.Lon.ToString())}");
            toStringOutput.Add($"Tz = {this.Tz ?? "null"}");
            toStringOutput.Add($"Date = {(this.Date == null ? "null" : this.Date.ToString())}");
            toStringOutput.Add($"Units = {this.Units ?? "null"}");
            toStringOutput.Add($"CloudCover = {(this.CloudCover == null ? "null" : this.CloudCover.ToString())}");
            toStringOutput.Add($"Humidity = {(this.Humidity == null ? "null" : this.Humidity.ToString())}");
            toStringOutput.Add($"Precipitation = {(this.Precipitation == null ? "null" : this.Precipitation.ToString())}");
            toStringOutput.Add($"Temperature = {(this.Temperature == null ? "null" : this.Temperature.ToString())}");
            toStringOutput.Add($"Pressure = {(this.Pressure == null ? "null" : this.Pressure.ToString())}");
            toStringOutput.Add($"Wind = {(this.Wind == null ? "null" : this.Wind.ToString())}");
        }
    }
}