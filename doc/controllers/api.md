# API

```csharp
APIController aPIController = client.APIController;
```

## Class Name

`APIController`


# Get Weather Data

Retrieve current weather, hourly forecast, and daily forecast based on latitude and longitude.

```csharp
GetWeatherDataAsync(
    double lat,
    double lon,
    string appid)
```

## Parameters

| Parameter | Type | Tags | Description |
|  --- | --- | --- | --- |
| `lat` | `double` | Query, Required | Latitude of the location. |
| `lon` | `double` | Query, Required | Longitude of the location. |
| `appid` | `string` | Query, Required | API key for authentication. |

## Response Type

[`Task<Models.WeatherResponse>`](../../doc/models/weather-response.md)

## Example Usage

```csharp
double lat = 78.08;
double lon = 88.82;
string appid = "appid6";
try
{
    WeatherResponse result = await aPIController.GetWeatherDataAsync(
        lat,
        lon,
        appid
    );
}
catch (ApiException e)
{
    // TODO: Handle exception here
    Console.WriteLine(e.Message);
}
```

## Errors

| HTTP Status Code | Error Description | Exception Class |
|  --- | --- | --- |
| 401 | Unauthorized due to missing or invalid API key. | `ApiException` |

