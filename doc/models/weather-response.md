
# Weather Response

## Structure

`WeatherResponse`

## Fields

| Name | Type | Tags | Description |
|  --- | --- | --- | --- |
| `Current` | [`Current`](../../doc/models/current.md) | Optional | - |
| `Hourly` | [`List<Hourly>`](../../doc/models/hourly.md) | Optional | - |
| `Daily` | [`List<Daily>`](../../doc/models/daily.md) | Optional | - |

## Example (as JSON)

```json
{
  "current": {
    "lat": 204.74,
    "lon": 37.84,
    "tz": "tz8",
    "date": "2016-03-13",
    "units": "units8"
  },
  "hourly": [
    {
      "lat": 54.8,
      "lon": 143.9,
      "tz": "tz4",
      "date": "2016-03-13",
      "units": "units2"
    },
    {
      "lat": 54.8,
      "lon": 143.9,
      "tz": "tz4",
      "date": "2016-03-13",
      "units": "units2"
    },
    {
      "lat": 54.8,
      "lon": 143.9,
      "tz": "tz4",
      "date": "2016-03-13",
      "units": "units2"
    }
  ],
  "daily": [
    {
      "lat": 17.96,
      "lon": 107.06,
      "tz": "tz0",
      "date": "2016-03-13",
      "units": "units6"
    },
    {
      "lat": 17.96,
      "lon": 107.06,
      "tz": "tz0",
      "date": "2016-03-13",
      "units": "units6"
    },
    {
      "lat": 17.96,
      "lon": 107.06,
      "tz": "tz0",
      "date": "2016-03-13",
      "units": "units6"
    }
  ]
}
```

