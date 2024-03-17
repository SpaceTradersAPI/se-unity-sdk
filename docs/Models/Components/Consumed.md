# Consumed

An object that only shows up when an action has consumed fuel in the process. Shows the fuel consumption data.


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `Amount`                                                                              | *long*                                                                                | :heavy_check_mark:                                                                    | The amount of fuel consumed by the most recent transit or action.                     |
| `Timestamp`                                                                           | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_check_mark:                                                                    | The time at which the fuel was consumed.                                              |