# ShipCargoJsonShipCargoJson

Ship cargo details.


## Fields

| Field                                                                   | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `Capacity`                                                              | *long*                                                                  | :heavy_check_mark:                                                      | The max number of items that can be stored in the cargo hold.           |
| `Units`                                                                 | *long*                                                                  | :heavy_check_mark:                                                      | The number of items currently stored in the cargo hold.                 |
| `Inventory`                                                             | List<[ShipCargoItemJson](../../Models/Components/ShipCargoItemJson.md)> | :heavy_check_mark:                                                      | The items currently in the cargo hold.                                  |