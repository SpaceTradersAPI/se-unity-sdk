# GetSystemWaypointsRequest


## Fields

| Field                                                           | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `SystemSymbol`                                                  | *string*                                                        | :heavy_check_mark:                                              | The system symbol                                               |
| `Page`                                                          | *long*                                                          | :heavy_minus_sign:                                              | What entry offset to request                                    |
| `Limit`                                                         | *long*                                                          | :heavy_minus_sign:                                              | How many entries to return per page                             |
| `Type`                                                          | [WaypointTypeJson](../../Models/Components/WaypointTypeJson.md) | :heavy_minus_sign:                                              | Filter waypoints by type.                                       |
| `Traits`                                                        | *object*                                                        | :heavy_minus_sign:                                              | Filter waypoints by one or more traits.                         |