# MarketTradeGoodJson


## Fields

| Field                                                                                                                                                                                                                                                                                                                                                 | Type                                                                                                                                                                                                                                                                                                                                                  | Required                                                                                                                                                                                                                                                                                                                                              | Description                                                                                                                                                                                                                                                                                                                                           |
| ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `Symbol`                                                                                                                                                                                                                                                                                                                                              | [TradeSymbolJsonTradeSymbolJson](../../Models/Components/TradeSymbolJsonTradeSymbolJson.md)                                                                                                                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                    | The good's symbol.                                                                                                                                                                                                                                                                                                                                    |
| `Type`                                                                                                                                                                                                                                                                                                                                                | [MarketTradeGoodJsonType](../../Models/Components/MarketTradeGoodJsonType.md)                                                                                                                                                                                                                                                                         | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                    | The type of trade good (export, import, or exchange).                                                                                                                                                                                                                                                                                                 |
| `TradeVolume`                                                                                                                                                                                                                                                                                                                                         | *long*                                                                                                                                                                                                                                                                                                                                                | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                    | This is the maximum number of units that can be purchased or sold at this market in a single trade for this good. Trade volume also gives an indication of price volatility. A market with a low trade volume will have large price swings, while high trade volume will be more resilient to price changes.                                          |
| `Supply`                                                                                                                                                                                                                                                                                                                                              | [SupplyLevelJson](../../Models/Components/SupplyLevelJson.md)                                                                                                                                                                                                                                                                                         | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                    | The supply level of a trade good.                                                                                                                                                                                                                                                                                                                     |
| `Activity`                                                                                                                                                                                                                                                                                                                                            | [ActivityLevelJson](../../Models/Components/ActivityLevelJson.md)                                                                                                                                                                                                                                                                                     | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                    | The activity level of a trade good. If the good is an import, this represents how strong consumption is. If the good is an export, this represents how strong the production is for the good. When activity is strong, consumption or production is near maximum capacity. When activity is weak, consumption or production is near minimum capacity. |
| `PurchasePrice`                                                                                                                                                                                                                                                                                                                                       | *long*                                                                                                                                                                                                                                                                                                                                                | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                    | The price at which this good can be purchased from the market.                                                                                                                                                                                                                                                                                        |
| `SellPrice`                                                                                                                                                                                                                                                                                                                                           | *long*                                                                                                                                                                                                                                                                                                                                                | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                    | The price at which this good can be sold to the market.                                                                                                                                                                                                                                                                                               |