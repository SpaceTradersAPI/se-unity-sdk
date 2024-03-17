# ChartJson

The chart of a system or waypoint, which makes the location visible to other agents.


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `WaypointSymbol`                                                                      | *string*                                                                              | :heavy_minus_sign:                                                                    | The symbol of the waypoint.                                                           |
| `SubmittedBy`                                                                         | *string*                                                                              | :heavy_minus_sign:                                                                    | The agent that submitted the chart for this waypoint.                                 |
| `SubmittedOn`                                                                         | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_minus_sign:                                                                    | The time the chart for this waypoint was submitted.                                   |