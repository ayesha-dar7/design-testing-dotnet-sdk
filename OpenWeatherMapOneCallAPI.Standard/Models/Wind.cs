// <copyright file="Wind.cs" company="APIMatic">
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
    /// Wind.
    /// </summary>
    public class Wind
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Wind"/> class.
        /// </summary>
        public Wind()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Wind"/> class.
        /// </summary>
        /// <param name="max">max.</param>
        public Wind(
            Models.Max max = null)
        {
            this.Max = max;
        }

        /// <summary>
        /// Gets or sets Max.
        /// </summary>
        [JsonProperty("max", NullValueHandling = NullValueHandling.Ignore)]
        public Models.Max Max { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Wind : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Wind other &&
                (this.Max == null && other.Max == null ||
                 this.Max?.Equals(other.Max) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Max = {(this.Max == null ? "null" : this.Max.ToString())}");
        }
    }
}