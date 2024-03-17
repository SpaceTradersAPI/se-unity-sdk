# ConstructionMaterialJson

The details of the required construction materials for a given waypoint under construction.


## Fields

| Field                                                                                       | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `TradeSymbol`                                                                               | [TradeSymbolJsonTradeSymbolJson](../../Models/Components/TradeSymbolJsonTradeSymbolJson.md) | :heavy_check_mark:                                                                          | The good's symbol.                                                                          |
| `Required`                                                                                  | *long*                                                                                      | :heavy_check_mark:                                                                          | The number of units required.                                                               |
| `Fulfilled`                                                                                 | *long*                                                                                      | :heavy_check_mark:                                                                          | The number of units fulfilled toward the required amount.                                   |