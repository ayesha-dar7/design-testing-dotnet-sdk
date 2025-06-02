// <copyright file="Temperature.cs" company="APIMatic">
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
    /// Temperature.
    /// </summary>
    public class Temperature
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Temperature"/> class.
        /// </summary>
        public Temperature()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Temperature"/> class.
        /// </summary>
        /// <param name="min">min.</param>
        /// <param name="max">max.</param>
        /// <param name="afternoon">afternoon.</param>
        /// <param name="night">night.</param>
        /// <param name="evening">evening.</param>
        /// <param name="morning">morning.</param>
        public Temperature(
            double? min = null,
            double? max = null,
            double? afternoon = null,
            double? night = null,
            double? evening = null,
            double? morning = null)
        {
            this.Min = min;
            this.Max = max;
            this.Afternoon = afternoon;
            this.Night = night;
            this.Evening = evening;
            this.Morning = morning;
        }

        /// <summary>
        /// Gets or sets Min.
        /// </summary>
        [JsonProperty("min", NullValueHandling = NullValueHandling.Ignore)]
        public double? Min { get; set; }

        /// <summary>
        /// Gets or sets Max.
        /// </summary>
        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public double? Max { get; set; }

        /// <summary>
        /// Gets or sets Afternoon.
        /// </summary>
        [JsonProperty("afternoon", NullValueHandling = NullValueHandling.Ignore)]
        public double? Afternoon { get; set; }

        /// <summary>
        /// Gets or sets Night.
        /// </summary>
        [JsonProperty("night", NullValueHandling = NullValueHandling.Ignore)]
        public double? Night { get; set; }

        /// <summary>
        /// Gets or sets Evening.
        /// </summary>
        [JsonProperty("evening", NullValueHandling = NullValueHandling.Ignore)]
        public double? Evening { get; set; }

        /// <summary>
        /// Gets or sets Morning.
        /// </summary>
        [JsonProperty("morning", NullValueHandling = NullValueHandling.Ignore)]
        public double? Morning { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Temperature : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Temperature other &&
                (this.Min == null && other.Min == null ||
                 this.Min?.Equals(other.Min) == true) &&
                (this.Max == null && other.Max == null ||
                 this.Max?.Equals(other.Max) == true) &&
                (this.Afternoon == null && other.Afternoon == null ||
                 this.Afternoon?.Equals(other.Afternoon) == true) &&
                (this.Night == null && other.Night == null ||
                 this.Night?.Equals(other.Night) == true) &&
                (this.Evening == null && other.Evening == null ||
                 this.Evening?.Equals(other.Evening) == true) &&
                (this.Morning == null && other.Morning == null ||
                 this.Morning?.Equals(other.Morning) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Min = {(this.Min == null ? "null" : this.Min.ToString())}");
            toStringOutput.Add($"Max = {(this.Max == null ? "null" : this.Max.ToString())}");
            toStringOutput.Add($"Afternoon = {(this.Afternoon == null ? "null" : this.Afternoon.ToString())}");
            toStringOutput.Add($"Night = {(this.Night == null ? "null" : this.Night.ToString())}");
            toStringOutput.Add($"Evening = {(this.Evening == null ? "null" : this.Evening.ToString())}");
            toStringOutput.Add($"Morning = {(this.Morning == null ? "null" : this.Morning.ToString())}");
        }
    }
}