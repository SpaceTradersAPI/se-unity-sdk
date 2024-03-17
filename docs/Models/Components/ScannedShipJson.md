# ScannedShipJson

The ship that was scanned. Details include information about the ship that could be detected by the scanner.


## Fields

| Field                                                                       | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `Symbol`                                                                    | *string*                                                                    | :heavy_check_mark:                                                          | The globally unique identifier of the ship.                                 |
| `Registration`                                                              | [ShipRegistrationJson](../../Models/Components/ShipRegistrationJson.md)     | :heavy_check_mark:                                                          | The public registration information of the ship                             |
| `Nav`                                                                       | [ShipNavJsonShipNavJson](../../Models/Components/ShipNavJsonShipNavJson.md) | :heavy_check_mark:                                                          | The navigation information of the ship.                                     |
| `Frame`                                                                     | [Frame](../../Models/Components/Frame.md)                                   | :heavy_minus_sign:                                                          | The frame of the ship.                                                      |
| `Reactor`                                                                   | [Reactor](../../Models/Components/Reactor.md)                               | :heavy_minus_sign:                                                          | The reactor of the ship.                                                    |
| `Engine`                                                                    | [Engine](../../Models/Components/Engine.md)                                 | :heavy_check_mark:                                                          | The engine of the ship.                                                     |
| `Mounts`                                                                    | List<[Mounts](../../Models/Components/Mounts.md)>                           | :heavy_minus_sign:                                                          | List of mounts installed in the ship.                                       |