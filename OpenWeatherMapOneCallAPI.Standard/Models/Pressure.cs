// <copyright file="Pressure.cs" company="APIMatic">
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
    /// Pressure.
    /// </summary>
    public class Pressure
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pressure"/> class.
        /// </summary>
        public Pressure()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Pressure"/> class.
        /// </summary>
        /// <param name="afternoon">afternoon.</param>
        public Pressure(
            int? afternoon = null)
        {
            this.Afternoon = afternoon;
        }

        /// <summary>
        /// Gets or sets Afternoon.
        /// </summary>
        [JsonProperty("afternoon", NullValueHandling = NullValueHandling.Ignore)]
        public int? Afternoon { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var toStringOutput = new List<string>();
            this.ToString(toStringOutput);
            return $"Pressure : ({string.Join(", ", toStringOutput)})";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;

            return obj is Pressure other &&
                (this.Afternoon == null && other.Afternoon == null ||
                 this.Afternoon?.Equals(other.Afternoon) == true);
        }

        /// <summary>
        /// ToString overload.
        /// </summary>
        /// <param name="toStringOutput">List of strings.</param>
        protected void ToString(List<string> toStringOutput)
        {
            toStringOutput.Add($"Afternoon = {(this.Afternoon == null ? "null" : this.Afternoon.ToString())}");
        }
    }
}