// <copyright file="Max.cs" company="APIMatic">
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
    /// Max.
    /// </summary>
    public class Max
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Max"/> class.
        /// </summary>
        public Max()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Max"/> class.
        /// </summary>
        /// <param name="speed">speed.</param>
        /// <param name="direction">direction.</param>
        public Max(
            double? speed = null,
            int? direction = null)
        {
            this.Speed = speed;
            this.Direction = direction;
        }

        /// <summary>
        /// Gets or sets Speed.
        /// </summary>
        [JsonProperty("speed", NullValueHandling = NullValueHandling.Ignore)]
        public double? Speed { get; set; }

        /// <summary>
        /// Gets or sets Direction.
        /// </summary>
        [JsonProperty("direction", NullValueHandling = NullValueHandling.Ignore)]
        public int? Direction { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Max : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Max other &&
                (this.Speed == null && other.Speed == null ||
                 this.Speed?.Equals(other.Speed) == true) &&
                (this.Direction == null && other.Direction == null ||
                 this.Direction?.Equals(other.Direction) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Speed = {(this.Speed == null ? "null" : this.Speed.ToString())}");
            toStringOutput.Add($"Direction = {(this.Direction == null ? "null" : this.Direction.ToString())}");
        }
    }
}