# GetStatusResponseBody

Fetched status successfully.


## Fields

| Field                                                         | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `Status`                                                      | *string*                                                      | :heavy_check_mark:                                            | The current status of the game server.                        |
| `Version`                                                     | *string*                                                      | :heavy_check_mark:                                            | The current version of the API.                               |
| `ResetDate`                                                   | *string*                                                      | :heavy_check_mark:                                            | The date when the game server was last reset.                 |
| `Description`                                                 | *string*                                                      | :heavy_check_mark:                                            | N/A                                                           |
| `Stats`                                                       | [Stats](../../Models/Requests/Stats.md)                       | :heavy_check_mark:                                            | N/A                                                           |
| `Leaderboards`                                                | [Leaderboards](../../Models/Requests/Leaderboards.md)         | :heavy_check_mark:                                            | N/A                                                           |
| `ServerResets`                                                | [ServerResets](../../Models/Requests/ServerResets.md)         | :heavy_check_mark:                                            | N/A                                                           |
| `Announcements`                                               | List<[Announcements](../../Models/Requests/Announcements.md)> | :heavy_check_mark:                                            | N/A                                                           |
| `Links`                                                       | List<[Links](../../Models/Requests/Links.md)>                 | :heavy_check_mark:                                            | N/A                                                           |