# ScannedSystemJson

Details of a system was that scanned.


## Fields

| Field                                                       | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `Symbol`                                                    | *string*                                                    | :heavy_check_mark:                                          | Symbol of the system.                                       |
| `SectorSymbol`                                              | *string*                                                    | :heavy_check_mark:                                          | Symbol of the system's sector.                              |
| `Type`                                                      | [SystemTypeJson](../../Models/Components/SystemTypeJson.md) | :heavy_check_mark:                                          | The type of system.                                         |
| `X`                                                         | *long*                                                      | :heavy_check_mark:                                          | Position in the universe in the x axis.                     |
| `Y`                                                         | *long*                                                      | :heavy_check_mark:                                          | Position in the universe in the y axis.                     |
| `Distance`                                                  | *long*                                                      | :heavy_check_mark:                                          | The system's distance from the scanning ship.               |