# CreateShipSystemScanData


## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `Cooldown`                                                                     | [CooldownJson](../../Models/Components/CooldownJson.md)                        | :heavy_check_mark:                                                             | A cooldown is a period of time in which a ship cannot perform certain actions. |
| `Systems`                                                                      | List<[ScannedSystemJson](../../Models/Components/ScannedSystemJson.md)>        | :heavy_check_mark:                                                             | List of scanned systems.                                                       |