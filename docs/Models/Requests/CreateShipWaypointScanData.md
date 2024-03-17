# CreateShipWaypointScanData


## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `Cooldown`                                                                     | [CooldownJson](../../Models/Components/CooldownJson.md)                        | :heavy_check_mark:                                                             | A cooldown is a period of time in which a ship cannot perform certain actions. |
| `Waypoints`                                                                    | List<[ScannedWaypointJson](../../Models/Components/ScannedWaypointJson.md)>    | :heavy_check_mark:                                                             | List of scanned waypoints.                                                     |