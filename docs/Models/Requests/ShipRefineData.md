# ShipRefineData


## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `Cargo`                                                                        | [ShipCargoJson](../../Models/Components/ShipCargoJson.md)                      | :heavy_check_mark:                                                             | Ship cargo details.                                                            |
| `Cooldown`                                                                     | [CooldownJson](../../Models/Components/CooldownJson.md)                        | :heavy_check_mark:                                                             | A cooldown is a period of time in which a ship cannot perform certain actions. |
| `Produced`                                                                     | List<[Produced](../../Models/Requests/Produced.md)>                            | :heavy_check_mark:                                                             | Goods that were produced by this refining process.                             |
| `Consumed`                                                                     | List<[Openapi.Models.Requests.Consumed](../../Models/Requests/Consumed.md)>    | :heavy_check_mark:                                                             | Goods that were consumed during this refining process.                         |