# ConstructionJson

The construction details of a waypoint.


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `Symbol`                                                                              | *string*                                                                              | :heavy_check_mark:                                                                    | The symbol of the waypoint.                                                           |
| `Materials`                                                                           | List<[ConstructionMaterialJson](../../Models/Components/ConstructionMaterialJson.md)> | :heavy_check_mark:                                                                    | The materials required to construct the waypoint.                                     |
| `IsComplete`                                                                          | *bool*                                                                                | :heavy_check_mark:                                                                    | Whether the waypoint has been constructed.                                            |