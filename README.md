
# Getting Started with OpenWeatherMap One Call API

## Introduction

Provides access to current weather, hourly forecast, and daily forecast data.

## Install the Package

If you are building with .NET CLI tools then you can also use the following command:

```bash
dotnet add package vg --version 11.27.65
```

You can also view the package at:
https://www.nuget.org/packages/vg/11.27.65

## Initialize the API Client

**_Note:_** Documentation for the client can be found [here.](https://www.github.com/ayesha-dar7/design-testing-dotnet-sdk/tree/11.27.65/doc/client.md)

The following parameters are configurable for the API Client:

| Parameter | Type | Description |
|  --- | --- | --- |
| Timeout | `TimeSpan` | Http client timeout.<br>*Default*: `TimeSpan.FromSeconds(100)` |
| HttpClientConfiguration | [`Action<HttpClientConfiguration.Builder>`](https://www.github.com/ayesha-dar7/design-testing-dotnet-sdk/tree/11.27.65/doc/http-client-configuration-builder.md) | Action delegate that configures the HTTP client by using the HttpClientConfiguration.Builder for customizing API call settings.<br>*Default*: `new HttpClient()` |

The API client can be initialized as follows:

```csharp
OpenWeatherMapOneCallAPIClient client = new OpenWeatherMapOneCallAPIClient.Builder()
    .Build();
```

## List of APIs

* [API](https://www.github.com/ayesha-dar7/design-testing-dotnet-sdk/tree/11.27.65/doc/controllers/api.md)

## SDK Infrastructure

### Configuration

* [HttpClientConfiguration](https://www.github.com/ayesha-dar7/design-testing-dotnet-sdk/tree/11.27.65/doc/http-client-configuration.md)
* [HttpClientConfigurationBuilder](https://www.github.com/ayesha-dar7/design-testing-dotnet-sdk/tree/11.27.65/doc/http-client-configuration-builder.md)
* [ProxyConfigurationBuilder](https://www.github.com/ayesha-dar7/design-testing-dotnet-sdk/tree/11.27.65/doc/proxy-configuration-builder.md)

### HTTP

* [HttpCallback](https://www.github.com/ayesha-dar7/design-testing-dotnet-sdk/tree/11.27.65/doc/http-callback.md)
* [HttpContext](https://www.github.com/ayesha-dar7/design-testing-dotnet-sdk/tree/11.27.65/doc/http-context.md)
* [HttpRequest](https://www.github.com/ayesha-dar7/design-testing-dotnet-sdk/tree/11.27.65/doc/http-request.md)
* [HttpResponse](https://www.github.com/ayesha-dar7/design-testing-dotnet-sdk/tree/11.27.65/doc/http-response.md)
* [HttpStringResponse](https://www.github.com/ayesha-dar7/design-testing-dotnet-sdk/tree/11.27.65/doc/http-string-response.md)

### Utilities

* [ApiException](https://www.github.com/ayesha-dar7/design-testing-dotnet-sdk/tree/11.27.65/doc/api-exception.md)
* [ApiHelper](https://www.github.com/ayesha-dar7/design-testing-dotnet-sdk/tree/11.27.65/doc/api-helper.md)
* [CustomDateTimeConverter](https://www.github.com/ayesha-dar7/design-testing-dotnet-sdk/tree/11.27.65/doc/custom-date-time-converter.md)
* [UnixDateTimeConverter](https://www.github.com/ayesha-dar7/design-testing-dotnet-sdk/tree/11.27.65/doc/unix-date-time-converter.md)

