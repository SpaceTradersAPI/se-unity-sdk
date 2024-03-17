# CooldownJsonCooldownJson

A cooldown is a period of time in which a ship cannot perform certain actions.


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `ShipSymbol`                                                                          | *string*                                                                              | :heavy_check_mark:                                                                    | The symbol of the ship that is on cooldown                                            |
| `TotalSeconds`                                                                        | *long*                                                                                | :heavy_check_mark:                                                                    | The total duration of the cooldown in seconds                                         |
| `RemainingSeconds`                                                                    | *long*                                                                                | :heavy_check_mark:                                                                    | The remaining duration of the cooldown in seconds                                     |
| `Expiration`                                                                          | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_minus_sign:                                                                    | The date and time when the cooldown expires in ISO 8601 format                        |