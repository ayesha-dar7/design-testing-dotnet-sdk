// <copyright file="Precipitation.cs" company="APIMatic">
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
    /// Precipitation.
    /// </summary>
    public class Precipitation
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Precipitation"/> class.
        /// </summary>
        public Precipitation()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Precipitation"/> class.
        /// </summary>
        /// <param name="total">total.</param>
        public Precipitation(
            int? total = null)
        {
            this.Total = total;
        }

        /// <summary>
        /// Gets or sets Total.
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Precipitation : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Precipitation other &&
                (this.Total == null && other.Total == null ||
                 this.Total?.Equals(other.Total) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Total = {(this.Total == null ? "null" : this.Total.ToString())}");
        }
    }
}