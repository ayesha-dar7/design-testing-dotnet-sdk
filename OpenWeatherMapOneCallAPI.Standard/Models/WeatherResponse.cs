// <copyright file="WeatherResponse.cs" company="APIMatic">
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
    /// WeatherResponse.
    /// </summary>
    public class WeatherResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherResponse"/> class.
        /// </summary>
        public WeatherResponse()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WeatherResponse"/> class.
        /// </summary>
        /// <param name="current">current.</param>
        /// <param name="hourly">hourly.</param>
        /// <param name="daily">daily.</param>
        public WeatherResponse(
            Models.Current current = null,
            List<Models.Hourly> hourly = null,
            List<Models.Daily> daily = null)
        {
            this.Current = current;
            this.Hourly = hourly;
            this.Daily = daily;
        }

        /// <summary>
        /// Gets or sets Current.
        /// </summary>
        [JsonProperty("current", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Current Current { get; set; }

        /// <summary>
        /// Gets or sets Hourly.
        /// </summary>
        [JsonProperty("hourly", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Hourly> Hourly { get; set; }

        /// <summary>
        /// Gets or sets Daily.
        /// </summary>
        [JsonProperty("daily", NullValueHandling = NullValueHandling.Ignore)]
        public List<Models.Daily> Daily { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"WeatherResponse : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is WeatherResponse other &&
                (this.Current == null && other.Current == null ||
                 this.Current?.Equals(other.Current) == true) &&
                (this.Hourly == null && other.Hourly == null ||
                 this.Hourly?.Equals(other.Hourly) == true) &&
                (this.Daily == null && other.Daily == null ||
                 this.Daily?.Equals(other.Daily) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Current = {(this.Current == null ? "null" : this.Current.ToString())}");
            toStringOutput.Add($"Hourly = {(this.Hourly == null ? "null" : $"[{string.Join(", ", this.Hourly)} ]")}");
            toStringOutput.Add($"Daily = {(this.Daily == null ? "null" : $"[{string.Join(", ", this.Daily)} ]")}");
        }
    }
}