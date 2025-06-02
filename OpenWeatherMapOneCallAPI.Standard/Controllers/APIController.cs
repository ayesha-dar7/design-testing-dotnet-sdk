// <copyright file="APIController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using APIMatic.Core;
using APIMatic.Core.Types;
using APIMatic.Core.Utilities;
using APIMatic.Core.Utilities.Date.Xml;
using Newtonsoft.Json.Converters;
using OpenWeatherMapOneCallAPI.Standard;
using OpenWeatherMapOneCallAPI.Standard.Exceptions;
using OpenWeatherMapOneCallAPI.Standard.Http.Client;
using OpenWeatherMapOneCallAPI.Standard.Utilities;
using System.Net.Http;

namespace OpenWeatherMapOneCallAPI.Standard.Controllers
{
    /// <summary>
    /// APIController.
    /// </summary>
    public class APIController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APIController"/> class.
        /// </summary>
        internal APIController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// Retrieve current weather, hourly forecast, and daily forecast based on latitude and longitude.
        /// </summary>
        /// <param name="lat">Required parameter: Latitude of the location..</param>
        /// <param name="lon">Required parameter: Longitude of the location..</param>
        /// <param name="appid">Required parameter: API key for authentication..</param>
        /// <returns>Returns the Models.WeatherResponse response from the API call.</returns>
        public Models.WeatherResponse GetWeatherData(
                double lat,
                double lon,
                string appid)
            => CoreHelper.RunTask(GetWeatherDataAsync(lat, lon, appid));

        /// <summary>
        /// Retrieve current weather, hourly forecast, and daily forecast based on latitude and longitude.
        /// </summary>
        /// <param name="lat">Required parameter: Latitude of the location..</param>
        /// <param name="lon">Required parameter: Longitude of the location..</param>
        /// <param name="appid">Required parameter: API key for authentication..</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.WeatherResponse response from the API call.</returns>
        public async Task<Models.WeatherResponse> GetWeatherDataAsync(
                double lat,
                double lon,
                string appid,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.WeatherResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/data/2.5/weather")
                  .Parameters(_parameters => _parameters
                      .Query(_query => _query.Setup("lat", lat))
                      .Query(_query => _query.Setup("lon", lon))
                      .Query(_query => _query.Setup("appid", appid))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .ErrorCase("401", CreateErrorCase("Unauthorized due to missing or invalid API key.", (_reason, _context) => new ApiException(_reason, _context))))
              .ExecuteAsync(cancellationToken).ConfigureAwait(false);
    }
}