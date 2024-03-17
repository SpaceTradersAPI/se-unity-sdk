# Systems
(*Systems*)

## Overview

Systems

### Available Operations

* [GetSystems](#getsystems) - List Systems
* [GetSystem](#getsystem) - Get System
* [GetSystemWaypoints](#getsystemwaypoints) - List Waypoints in System
* [GetWaypoint](#getwaypoint) - Get Waypoint
* [GetMarket](#getmarket) - Get Market
* [GetShipyard](#getshipyard) - Get Shipyard
* [GetJumpGate](#getjumpgate) - Get Jump Gate
* [GetConstruction](#getconstruction) - Get Construction Site
* [SupplyConstruction](#supplyconstruction) - Supply Construction Site

## GetSystems

Return a paginated list of all systems.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Components;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Systems.GetSystemsAsync(
    page: 493948,
    limit: 878388))
{
    // handle response
}
```

### Parameters

| Parameter                           | Type                                | Required                            | Description                         |
| ----------------------------------- | ----------------------------------- | ----------------------------------- | ----------------------------------- |
| `Page`                              | *long*                              | :heavy_minus_sign:                  | What entry offset to request        |
| `Limit`                             | *long*                              | :heavy_minus_sign:                  | How many entries to return per page |


### Response

**[GetSystemsResponse](../../models/requests/GetSystemsResponse.md)**


## GetSystem

Get the details of a system.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Components;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Systems.GetSystemAsync(systemSymbol: "<value>"))
{
    // handle response
}
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `SystemSymbol`     | *string*           | :heavy_check_mark: | The system symbol  |


### Response

**[GetSystemResponse](../../models/requests/GetSystemResponse.md)**


## GetSystemWaypoints

Return a paginated list of all of the waypoints for a given system.

If a waypoint is uncharted, it will return the `Uncharted` trait instead of its actual traits.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Components;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

GetSystemWaypointsRequest req = new GetSystemWaypointsRequest() {
    SystemSymbol = "<value>",
};

using(var res = await sdk.Systems.GetSystemWaypointsAsync(req))
{
    // handle response
}
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [GetSystemWaypointsRequest](../../Models/Requests/GetSystemWaypointsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[GetSystemWaypointsResponse](../../models/requests/GetSystemWaypointsResponse.md)**


## GetWaypoint

View the details of a waypoint.

If the waypoint is uncharted, it will return the 'Uncharted' trait instead of its actual traits.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Components;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Systems.GetWaypointAsync(
    systemSymbol: "<value>",
    waypointSymbol: "<value>"))
{
    // handle response
}
```

### Parameters

| Parameter           | Type                | Required            | Description         |
| ------------------- | ------------------- | ------------------- | ------------------- |
| `SystemSymbol`      | *string*            | :heavy_check_mark:  | The system symbol   |
| `WaypointSymbol`    | *string*            | :heavy_check_mark:  | The waypoint symbol |


### Response

**[GetWaypointResponse](../../models/requests/GetWaypointResponse.md)**


## GetMarket

Retrieve imports, exports and exchange data from a marketplace. Requires a waypoint that has the `Marketplace` trait to use.

Send a ship to the waypoint to access trade good prices and recent transactions. Refer to the [Market Overview page](https://docs.spacetraders.io/game-concepts/markets) to gain better a understanding of the market in the game.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Components;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Systems.GetMarketAsync(
    systemSymbol: "<value>",
    waypointSymbol: "<value>"))
{
    // handle response
}
```

### Parameters

| Parameter           | Type                | Required            | Description         |
| ------------------- | ------------------- | ------------------- | ------------------- |
| `SystemSymbol`      | *string*            | :heavy_check_mark:  | The system symbol   |
| `WaypointSymbol`    | *string*            | :heavy_check_mark:  | The waypoint symbol |


### Response

**[GetMarketResponse](../../models/requests/GetMarketResponse.md)**


## GetShipyard

Get the shipyard for a waypoint. Requires a waypoint that has the `Shipyard` trait to use. Send a ship to the waypoint to access data on ships that are currently available for purchase and recent transactions.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Components;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Systems.GetShipyardAsync(
    systemSymbol: "<value>",
    waypointSymbol: "<value>"))
{
    // handle response
}
```

### Parameters

| Parameter           | Type                | Required            | Description         |
| ------------------- | ------------------- | ------------------- | ------------------- |
| `SystemSymbol`      | *string*            | :heavy_check_mark:  | The system symbol   |
| `WaypointSymbol`    | *string*            | :heavy_check_mark:  | The waypoint symbol |


### Response

**[GetShipyardResponse](../../models/requests/GetShipyardResponse.md)**


## GetJumpGate

Get jump gate details for a waypoint. Requires a waypoint of type `JUMP_GATE` to use.

Waypoints connected to this jump gate can be 

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Components;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Systems.GetJumpGateAsync(
    systemSymbol: "<value>",
    waypointSymbol: "<value>"))
{
    // handle response
}
```

### Parameters

| Parameter           | Type                | Required            | Description         |
| ------------------- | ------------------- | ------------------- | ------------------- |
| `SystemSymbol`      | *string*            | :heavy_check_mark:  | The system symbol   |
| `WaypointSymbol`    | *string*            | :heavy_check_mark:  | The waypoint symbol |


### Response

**[GetJumpGateResponse](../../models/requests/GetJumpGateResponse.md)**


## GetConstruction

Get construction details for a waypoint. Requires a waypoint with a property of `isUnderConstruction` to be true.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Components;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Systems.GetConstructionAsync(
    systemSymbol: "<value>",
    waypointSymbol: "<value>"))
{
    // handle response
}
```

### Parameters

| Parameter           | Type                | Required            | Description         |
| ------------------- | ------------------- | ------------------- | ------------------- |
| `SystemSymbol`      | *string*            | :heavy_check_mark:  | The system symbol   |
| `WaypointSymbol`    | *string*            | :heavy_check_mark:  | The waypoint symbol |


### Response

**[GetConstructionResponse](../../models/requests/GetConstructionResponse.md)**


## SupplyConstruction

Supply a construction site with the specified good. Requires a waypoint with a property of `isUnderConstruction` to be true.

The good must be in your ship's cargo. The good will be removed from your ship's cargo and added to the construction site's materials.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Systems.SupplyConstructionAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    systemSymbol: "<value>",
    waypointSymbol: "<value>",
    requestBody: new SupplyConstructionRequestBody() {
    ShipSymbol = "<value>",
    TradeSymbol = "<value>",
    Units = 110828,
}))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                | [Openapi.Models.Requests.SupplyConstructionSecurity](../../models/requests/SupplyConstructionSecurity.md) | :heavy_check_mark:                                                                                        | The security requirements to use for the request.                                                         |
| `SystemSymbol`                                                                                            | *string*                                                                                                  | :heavy_check_mark:                                                                                        | The system symbol                                                                                         |
| `WaypointSymbol`                                                                                          | *string*                                                                                                  | :heavy_check_mark:                                                                                        | The waypoint symbol                                                                                       |
| `RequestBody`                                                                                             | [SupplyConstructionRequestBody](../../Models/Requests/SupplyConstructionRequestBody.md)                   | :heavy_minus_sign:                                                                                        | N/A                                                                                                       |


### Response

**[SupplyConstructionResponse](../../models/requests/SupplyConstructionResponse.md)**

