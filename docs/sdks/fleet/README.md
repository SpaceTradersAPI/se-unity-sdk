# Fleet
(*Fleet*)

## Overview

Fleet

### Available Operations

* [GetMyShips](#getmyships) - List Ships
* [PurchaseShip](#purchaseship) - Purchase Ship
* [GetMyShip](#getmyship) - Get Ship
* [GetMyShipCargo](#getmyshipcargo) - Get Ship Cargo
* [OrbitShip](#orbitship) - Orbit Ship
* [ShipRefine](#shiprefine) - Ship Refine
* [CreateChart](#createchart) - Create Chart
* [GetShipCooldown](#getshipcooldown) - Get Ship Cooldown
* [DockShip](#dockship) - Dock Ship
* [CreateSurvey](#createsurvey) - Create Survey
* [ExtractResources](#extractresources) - Extract Resources
* [SiphonResources](#siphonresources) - Siphon Resources
* [ExtractResourcesWithSurvey](#extractresourceswithsurvey) - Extract Resources with Survey
* [Jettison](#jettison) - Jettison Cargo
* [JumpShip](#jumpship) - Jump Ship
* [NavigateShip](#navigateship) - Navigate Ship
* [PatchShipNav](#patchshipnav) - Patch Ship Nav
* [GetShipNav](#getshipnav) - Get Ship Nav
* [WarpShip](#warpship) - Warp Ship
* [SellCargo](#sellcargo) - Sell Cargo
* [CreateShipSystemScan](#createshipsystemscan) - Scan Systems
* [CreateShipWaypointScan](#createshipwaypointscan) - Scan Waypoints
* [CreateShipShipScan](#createshipshipscan) - Scan Ships
* [RefuelShip](#refuelship) - Refuel Ship
* [PurchaseCargo](#purchasecargo) - Purchase Cargo
* [TransferCargo](#transfercargo) - Transfer Cargo
* [NegotiateContract](#negotiatecontract) - Negotiate Contract
* [GetMounts](#getmounts) - Get Mounts
* [InstallMount](#installmount) - Install Mount
* [RemoveMount](#removemount) - Remove Mount
* [GetScrapShip](#getscrapship) - Get Scrap Ship
* [ScrapShip](#scrapship) - Scrap Ship
* [GetRepairShip](#getrepairship) - Get Repair Ship
* [RepairShip](#repairship) - Repair Ship

## GetMyShips

Return a paginated list of all of ships under your agent's ownership.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Fleet.GetMyShipsAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    page: 778259,
    limit: 565031))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `security`                                                                                | [Openapi.Models.Requests.GetMyShipsSecurity](../../models/requests/GetMyShipsSecurity.md) | :heavy_check_mark:                                                                        | The security requirements to use for the request.                                         |
| `Page`                                                                                    | *long*                                                                                    | :heavy_minus_sign:                                                                        | What entry offset to request                                                              |
| `Limit`                                                                                   | *long*                                                                                    | :heavy_minus_sign:                                                                        | How many entries to return per page                                                       |


### Response

**[GetMyShipsResponse](../../models/requests/GetMyShipsResponse.md)**


## PurchaseShip

Purchase a ship from a Shipyard. In order to use this function, a ship under your agent's ownership must be in a waypoint that has the `Shipyard` trait, and the Shipyard must sell the type of the desired ship.

Shipyards typically offer ship types, which are predefined templates of ships that have dedicated roles. A template comes with a preset of an engine, a reactor, and a frame. It may also include a few modules and mounts.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;
using Openapi.Models.Components;

var sdk = new SeUnitySDK();

PurchaseShipRequestBody req = new PurchaseShipRequestBody() {
    ShipType = ShipTypeJson.ShipOreHound,
    WaypointSymbol = "<value>",
};

using(var res = await sdk.Fleet.PurchaseShipAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    req))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [PurchaseShipRequestBody](../../Models/Requests/PurchaseShipRequestBody.md)                   | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |
| `security`                                                                                    | [Openapi.Models.Requests.PurchaseShipSecurity](../../models/requests/PurchaseShipSecurity.md) | :heavy_check_mark:                                                                            | The security requirements to use for the request.                                             |


### Response

**[PurchaseShipResponse](../../models/requests/PurchaseShipResponse.md)**


## GetMyShip

Retrieve the details of a ship under your agent's ownership.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Fleet.GetMyShipAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    shipSymbol: "<value>"))
{
    // handle response
}
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `security`                                                                              | [Openapi.Models.Requests.GetMyShipSecurity](../../models/requests/GetMyShipSecurity.md) | :heavy_check_mark:                                                                      | The security requirements to use for the request.                                       |
| `ShipSymbol`                                                                            | *string*                                                                                | :heavy_check_mark:                                                                      | The symbol of the ship.                                                                 |


### Response

**[GetMyShipResponse](../../models/requests/GetMyShipResponse.md)**


## GetMyShipCargo

Retrieve the cargo of a ship under your agent's ownership.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Fleet.GetMyShipCargoAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    shipSymbol: "<value>"))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `security`                                                                                        | [Openapi.Models.Requests.GetMyShipCargoSecurity](../../models/requests/GetMyShipCargoSecurity.md) | :heavy_check_mark:                                                                                | The security requirements to use for the request.                                                 |
| `ShipSymbol`                                                                                      | *string*                                                                                          | :heavy_check_mark:                                                                                | The symbol of the ship.                                                                           |


### Response

**[GetMyShipCargoResponse](../../models/requests/GetMyShipCargoResponse.md)**


## OrbitShip

Attempt to move your ship into orbit at its current location. The request will only succeed if your ship is capable of moving into orbit at the time of the request.

Orbiting ships are able to do actions that require the ship to be above surface such as navigating or extracting, but cannot access elements in their current waypoint, such as the market or a shipyard.

The endpoint is idempotent - successive calls will succeed even if the ship is already in orbit.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Fleet.OrbitShipAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    shipSymbol: "<value>"))
{
    // handle response
}
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `security`                                                                              | [Openapi.Models.Requests.OrbitShipSecurity](../../models/requests/OrbitShipSecurity.md) | :heavy_check_mark:                                                                      | The security requirements to use for the request.                                       |
| `ShipSymbol`                                                                            | *string*                                                                                | :heavy_check_mark:                                                                      | The symbol of the ship.                                                                 |


### Response

**[OrbitShipResponse](../../models/requests/OrbitShipResponse.md)**


## ShipRefine

Attempt to refine the raw materials on your ship. The request will only succeed if your ship is capable of refining at the time of the request. In order to be able to refine, a ship must have goods that can be refined and have installed a `Refinery` module that can refine it.

When refining, 30 basic goods will be converted into 10 processed goods.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Fleet.ShipRefineAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    shipSymbol: "<value>",
    requestBody: new ShipRefineRequestBody() {
    Produce = Produce.Silver,
}))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `security`                                                                                | [Openapi.Models.Requests.ShipRefineSecurity](../../models/requests/ShipRefineSecurity.md) | :heavy_check_mark:                                                                        | The security requirements to use for the request.                                         |
| `ShipSymbol`                                                                              | *string*                                                                                  | :heavy_check_mark:                                                                        | The symbol of the ship.                                                                   |
| `RequestBody`                                                                             | [ShipRefineRequestBody](../../Models/Requests/ShipRefineRequestBody.md)                   | :heavy_minus_sign:                                                                        | N/A                                                                                       |


### Response

**[ShipRefineResponse](../../models/requests/ShipRefineResponse.md)**


## CreateChart

Command a ship to chart the waypoint at its current location.

Most waypoints in the universe are uncharted by default. These waypoints have their traits hidden until they have been charted by a ship.

Charting a waypoint will record your agent as the one who created the chart, and all other agents would also be able to see the waypoint's traits.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Fleet.CreateChartAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    shipSymbol: "<value>"))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `security`                                                                                  | [Openapi.Models.Requests.CreateChartSecurity](../../models/requests/CreateChartSecurity.md) | :heavy_check_mark:                                                                          | The security requirements to use for the request.                                           |
| `ShipSymbol`                                                                                | *string*                                                                                    | :heavy_check_mark:                                                                          | The symbol of the ship.                                                                     |


### Response

**[CreateChartResponse](../../models/requests/CreateChartResponse.md)**


## GetShipCooldown

Retrieve the details of your ship's reactor cooldown. Some actions such as activating your jump drive, scanning, or extracting resources taxes your reactor and results in a cooldown.

Your ship cannot perform additional actions until your cooldown has expired. The duration of your cooldown is relative to the power consumption of the related modules or mounts for the action taken.

Response returns a 204 status code (no-content) when the ship has no cooldown.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Fleet.GetShipCooldownAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    shipSymbol: "<value>"))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `security`                                                                                          | [Openapi.Models.Requests.GetShipCooldownSecurity](../../models/requests/GetShipCooldownSecurity.md) | :heavy_check_mark:                                                                                  | The security requirements to use for the request.                                                   |
| `ShipSymbol`                                                                                        | *string*                                                                                            | :heavy_check_mark:                                                                                  | The symbol of the ship.                                                                             |


### Response

**[GetShipCooldownResponse](../../models/requests/GetShipCooldownResponse.md)**


## DockShip

Attempt to dock your ship at its current location. Docking will only succeed if your ship is capable of docking at the time of the request.

Docked ships can access elements in their current location, such as the market or a shipyard, but cannot do actions that require the ship to be above surface such as navigating or extracting.

The endpoint is idempotent - successive calls will succeed even if the ship is already docked.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Fleet.DockShipAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    shipSymbol: "<value>"))
{
    // handle response
}
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `security`                                                                            | [Openapi.Models.Requests.DockShipSecurity](../../models/requests/DockShipSecurity.md) | :heavy_check_mark:                                                                    | The security requirements to use for the request.                                     |
| `ShipSymbol`                                                                          | *string*                                                                              | :heavy_check_mark:                                                                    | The symbol of the ship.                                                               |


### Response

**[DockShipResponse](../../models/requests/DockShipResponse.md)**


## CreateSurvey

Create surveys on a waypoint that can be extracted such as asteroid fields. A survey focuses on specific types of deposits from the extracted location. When ships extract using this survey, they are guaranteed to procure a high amount of one of the goods in the survey.

In order to use a survey, send the entire survey details in the body of the extract request.

Each survey may have multiple deposits, and if a symbol shows up more than once, that indicates a higher chance of extracting that resource.

Your ship will enter a cooldown after surveying in which it is unable to perform certain actions. Surveys will eventually expire after a period of time or will be exhausted after being extracted several times based on the survey's size. Multiple ships can use the same survey for extraction.

A ship must have the `Surveyor` mount installed in order to use this function.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Fleet.CreateSurveyAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    shipSymbol: "<value>"))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `security`                                                                                    | [Openapi.Models.Requests.CreateSurveySecurity](../../models/requests/CreateSurveySecurity.md) | :heavy_check_mark:                                                                            | The security requirements to use for the request.                                             |
| `ShipSymbol`                                                                                  | *string*                                                                                      | :heavy_check_mark:                                                                            | The symbol of the ship.                                                                       |


### Response

**[CreateSurveyResponse](../../models/requests/CreateSurveyResponse.md)**


## ExtractResources

Extract resources from a waypoint that can be extracted, such as asteroid fields, into your ship. Send an optional survey as the payload to target specific yields.

The ship must be in orbit to be able to extract and must have mining equipments installed that can extract goods, such as the `Gas Siphon` mount for gas-based goods or `Mining Laser` mount for ore-based goods.

The survey property is now deprecated. See the `extract/survey` endpoint for more details.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;
using Openapi.Models.Components;
using System.Collections.Generic;

var sdk = new SeUnitySDK();

using(var res = await sdk.Fleet.ExtractResourcesAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    shipSymbol: "<value>",
    requestBody: new ExtractResourcesRequestBody() {}))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `security`                                                                                            | [Openapi.Models.Requests.ExtractResourcesSecurity](../../models/requests/ExtractResourcesSecurity.md) | :heavy_check_mark:                                                                                    | The security requirements to use for the request.                                                     |
| `ShipSymbol`                                                                                          | *string*                                                                                              | :heavy_check_mark:                                                                                    | The ship symbol.                                                                                      |
| `RequestBody`                                                                                         | [ExtractResourcesRequestBody](../../Models/Requests/ExtractResourcesRequestBody.md)                   | :heavy_minus_sign:                                                                                    | N/A                                                                                                   |


### Response

**[ExtractResourcesResponse](../../models/requests/ExtractResourcesResponse.md)**


## SiphonResources

Siphon gases, such as hydrocarbon, from gas giants.

The ship must be in orbit to be able to siphon and must have siphon mounts and a gas processor installed.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Fleet.SiphonResourcesAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    shipSymbol: "<value>"))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `security`                                                                                          | [Openapi.Models.Requests.SiphonResourcesSecurity](../../models/requests/SiphonResourcesSecurity.md) | :heavy_check_mark:                                                                                  | The security requirements to use for the request.                                                   |
| `ShipSymbol`                                                                                        | *string*                                                                                            | :heavy_check_mark:                                                                                  | The ship symbol.                                                                                    |


### Response

**[SiphonResourcesResponse](../../models/requests/SiphonResourcesResponse.md)**


## ExtractResourcesWithSurvey

Use a survey when extracting resources from a waypoint. This endpoint requires a survey as the payload, which allows your ship to extract specific yields.

Send the full survey object as the payload which will be validated according to the signature. If the signature is invalid, or any properties of the survey are changed, the request will fail.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;
using Openapi.Models.Components;
using System.Collections.Generic;

var sdk = new SeUnitySDK();

using(var res = await sdk.Fleet.ExtractResourcesWithSurveyAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    shipSymbol: "<value>",
    surveyJson: new SurveyJson() {
    Signature = "<value>",
    Symbol = "<value>",
    Deposits = new List<SurveyDepositJson>() {
        new SurveyDepositJson() {
            Symbol = "<value>",
        },
    },
    Expiration = System.DateTime.Parse("2023-08-10T19:17:49.847Z"),
    Size = Size.Small,
}))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                                                 | Type                                                                                                                      | Required                                                                                                                  | Description                                                                                                               |
| ------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                                | [Openapi.Models.Requests.ExtractResourcesWithSurveySecurity](../../models/requests/ExtractResourcesWithSurveySecurity.md) | :heavy_check_mark:                                                                                                        | The security requirements to use for the request.                                                                         |
| `ShipSymbol`                                                                                                              | *string*                                                                                                                  | :heavy_check_mark:                                                                                                        | The ship symbol.                                                                                                          |
| `SurveyJson`                                                                                                              | [SurveyJson](../../Models/Components/SurveyJson.md)                                                                       | :heavy_minus_sign:                                                                                                        | N/A                                                                                                                       |


### Response

**[ExtractResourcesWithSurveyResponse](../../models/requests/ExtractResourcesWithSurveyResponse.md)**


## Jettison

Jettison cargo from your ship's cargo hold.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;
using Openapi.Models.Components;

var sdk = new SeUnitySDK();

using(var res = await sdk.Fleet.JettisonAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    shipSymbol: "<value>",
    requestBody: new JettisonRequestBody() {
    Symbol = TradeSymbolJson.Supergrains,
    Units = 333405,
}))
{
    // handle response
}
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `security`                                                                            | [Openapi.Models.Requests.JettisonSecurity](../../models/requests/JettisonSecurity.md) | :heavy_check_mark:                                                                    | The security requirements to use for the request.                                     |
| `ShipSymbol`                                                                          | *string*                                                                              | :heavy_check_mark:                                                                    | The ship symbol.                                                                      |
| `RequestBody`                                                                         | [JettisonRequestBody](../../Models/Requests/JettisonRequestBody.md)                   | :heavy_minus_sign:                                                                    | N/A                                                                                   |


### Response

**[JettisonResponse](../../models/requests/JettisonResponse.md)**


## JumpShip

Jump your ship instantly to a target connected waypoint. The ship must be in orbit to execute a jump.

A unit of antimatter is purchased and consumed from the market when jumping. The price of antimatter is determined by the market and is subject to change. A ship can only jump to connected waypoints

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Fleet.JumpShipAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    shipSymbol: "<value>",
    requestBody: new JumpShipRequestBody() {
    WaypointSymbol = "<value>",
}))
{
    // handle response
}
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `security`                                                                            | [Openapi.Models.Requests.JumpShipSecurity](../../models/requests/JumpShipSecurity.md) | :heavy_check_mark:                                                                    | The security requirements to use for the request.                                     |
| `ShipSymbol`                                                                          | *string*                                                                              | :heavy_check_mark:                                                                    | The ship symbol.                                                                      |
| `RequestBody`                                                                         | [JumpShipRequestBody](../../Models/Requests/JumpShipRequestBody.md)                   | :heavy_minus_sign:                                                                    | N/A                                                                                   |


### Response

**[JumpShipResponse](../../models/requests/JumpShipResponse.md)**


## NavigateShip

Navigate to a target destination. The ship must be in orbit to use this function. The destination waypoint must be within the same system as the ship's current location. Navigating will consume the necessary fuel from the ship's manifest based on the distance to the target waypoint.

The returned response will detail the route information including the expected time of arrival. Most ship actions are unavailable until the ship has arrived at it's destination.

To travel between systems, see the ship's Warp or Jump actions.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Fleet.NavigateShipAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    shipSymbol: "<value>",
    requestBody: new NavigateShipRequestBody() {
    WaypointSymbol = "<value>",
}))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `security`                                                                                    | [Openapi.Models.Requests.NavigateShipSecurity](../../models/requests/NavigateShipSecurity.md) | :heavy_check_mark:                                                                            | The security requirements to use for the request.                                             |
| `ShipSymbol`                                                                                  | *string*                                                                                      | :heavy_check_mark:                                                                            | The ship symbol.                                                                              |
| `RequestBody`                                                                                 | [NavigateShipRequestBody](../../Models/Requests/NavigateShipRequestBody.md)                   | :heavy_minus_sign:                                                                            | N/A                                                                                           |


### Response

**[NavigateShipResponse](../../models/requests/NavigateShipResponse.md)**


## PatchShipNav

Update the nav configuration of a ship.

Currently only supports configuring the Flight Mode of the ship, which affects its speed and fuel consumption.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;
using Openapi.Models.Components;

var sdk = new SeUnitySDK();

using(var res = await sdk.Fleet.PatchShipNavAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    shipSymbol: "<value>",
    requestBody: new PatchShipNavRequestBody() {}))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `security`                                                                                    | [Openapi.Models.Requests.PatchShipNavSecurity](../../models/requests/PatchShipNavSecurity.md) | :heavy_check_mark:                                                                            | The security requirements to use for the request.                                             |
| `ShipSymbol`                                                                                  | *string*                                                                                      | :heavy_check_mark:                                                                            | The ship symbol.                                                                              |
| `RequestBody`                                                                                 | [PatchShipNavRequestBody](../../Models/Requests/PatchShipNavRequestBody.md)                   | :heavy_minus_sign:                                                                            | N/A                                                                                           |


### Response

**[PatchShipNavResponse](../../models/requests/PatchShipNavResponse.md)**


## GetShipNav

Get the current nav status of a ship.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Fleet.GetShipNavAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    shipSymbol: "<value>"))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `security`                                                                                | [Openapi.Models.Requests.GetShipNavSecurity](../../models/requests/GetShipNavSecurity.md) | :heavy_check_mark:                                                                        | The security requirements to use for the request.                                         |
| `ShipSymbol`                                                                              | *string*                                                                                  | :heavy_check_mark:                                                                        | The ship symbol.                                                                          |


### Response

**[GetShipNavResponse](../../models/requests/GetShipNavResponse.md)**


## WarpShip

Warp your ship to a target destination in another system. The ship must be in orbit to use this function and must have the `Warp Drive` module installed. Warping will consume the necessary fuel from the ship's manifest.

The returned response will detail the route information including the expected time of arrival. Most ship actions are unavailable until the ship has arrived at its destination.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Fleet.WarpShipAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    shipSymbol: "<value>",
    requestBody: new WarpShipRequestBody() {
    WaypointSymbol = "<value>",
}))
{
    // handle response
}
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `security`                                                                            | [Openapi.Models.Requests.WarpShipSecurity](../../models/requests/WarpShipSecurity.md) | :heavy_check_mark:                                                                    | The security requirements to use for the request.                                     |
| `ShipSymbol`                                                                          | *string*                                                                              | :heavy_check_mark:                                                                    | The ship symbol.                                                                      |
| `RequestBody`                                                                         | [WarpShipRequestBody](../../Models/Requests/WarpShipRequestBody.md)                   | :heavy_minus_sign:                                                                    | N/A                                                                                   |


### Response

**[WarpShipResponse](../../models/requests/WarpShipResponse.md)**


## SellCargo

Sell cargo in your ship to a market that trades this cargo. The ship must be docked in a waypoint that has the `Marketplace` trait in order to use this function.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;
using Openapi.Models.Components;

var sdk = new SeUnitySDK();

using(var res = await sdk.Fleet.SellCargoAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    shipSymbol: "<value>",
    requestBody: new SellCargoSellCargoRequest() {
    Symbol = TradeSymbolJson.Supergrains,
    Units = 584156,
}))
{
    // handle response
}
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `security`                                                                              | [Openapi.Models.Requests.SellCargoSecurity](../../models/requests/SellCargoSecurity.md) | :heavy_check_mark:                                                                      | The security requirements to use for the request.                                       |
| `ShipSymbol`                                                                            | *string*                                                                                | :heavy_check_mark:                                                                      | Symbol of a ship.                                                                       |
| `RequestBody`                                                                           | [SellCargoSellCargoRequest](../../Models/Requests/SellCargoSellCargoRequest.md)         | :heavy_minus_sign:                                                                      | N/A                                                                                     |


### Response

**[SellCargoResponse](../../models/requests/SellCargoResponse.md)**


## CreateShipSystemScan

Scan for nearby systems, retrieving information on the systems' distance from the ship and their waypoints. Requires a ship to have the `Sensor Array` mount installed to use.

The ship will enter a cooldown after using this function, during which it cannot execute certain actions.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Fleet.CreateShipSystemScanAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    shipSymbol: "<value>"))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                    | [Openapi.Models.Requests.CreateShipSystemScanSecurity](../../models/requests/CreateShipSystemScanSecurity.md) | :heavy_check_mark:                                                                                            | The security requirements to use for the request.                                                             |
| `ShipSymbol`                                                                                                  | *string*                                                                                                      | :heavy_check_mark:                                                                                            | The ship symbol.                                                                                              |


### Response

**[CreateShipSystemScanResponse](../../models/requests/CreateShipSystemScanResponse.md)**


## CreateShipWaypointScan

Scan for nearby waypoints, retrieving detailed information on each waypoint in range. Scanning uncharted waypoints will allow you to ignore their uncharted state and will list the waypoints' traits.

Requires a ship to have the `Sensor Array` mount installed to use.

The ship will enter a cooldown after using this function, during which it cannot execute certain actions.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Fleet.CreateShipWaypointScanAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    shipSymbol: "<value>"))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                        | [Openapi.Models.Requests.CreateShipWaypointScanSecurity](../../models/requests/CreateShipWaypointScanSecurity.md) | :heavy_check_mark:                                                                                                | The security requirements to use for the request.                                                                 |
| `ShipSymbol`                                                                                                      | *string*                                                                                                          | :heavy_check_mark:                                                                                                | The ship symbol.                                                                                                  |


### Response

**[CreateShipWaypointScanResponse](../../models/requests/CreateShipWaypointScanResponse.md)**


## CreateShipShipScan

Scan for nearby ships, retrieving information for all ships in range.

Requires a ship to have the `Sensor Array` mount installed to use.

The ship will enter a cooldown after using this function, during which it cannot execute certain actions.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Fleet.CreateShipShipScanAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    shipSymbol: "<value>"))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `security`                                                                                                | [Openapi.Models.Requests.CreateShipShipScanSecurity](../../models/requests/CreateShipShipScanSecurity.md) | :heavy_check_mark:                                                                                        | The security requirements to use for the request.                                                         |
| `ShipSymbol`                                                                                              | *string*                                                                                                  | :heavy_check_mark:                                                                                        | The ship symbol.                                                                                          |


### Response

**[CreateShipShipScanResponse](../../models/requests/CreateShipShipScanResponse.md)**


## RefuelShip

Refuel your ship by buying fuel from the local market.

Requires the ship to be docked in a waypoint that has the `Marketplace` trait, and the market must be selling fuel in order to refuel.

Each fuel bought from the market replenishes 100 units in your ship's fuel.

Ships will always be refuel to their frame's maximum fuel capacity when using this action.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Fleet.RefuelShipAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    shipSymbol: "<value>",
    requestBody: new RefuelShipRequestBody() {
    Units = 100,
    FromCargo = false,
}))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `security`                                                                                | [Openapi.Models.Requests.RefuelShipSecurity](../../models/requests/RefuelShipSecurity.md) | :heavy_check_mark:                                                                        | The security requirements to use for the request.                                         |
| `ShipSymbol`                                                                              | *string*                                                                                  | :heavy_check_mark:                                                                        | The ship symbol.                                                                          |
| `RequestBody`                                                                             | [RefuelShipRequestBody](../../Models/Requests/RefuelShipRequestBody.md)                   | :heavy_minus_sign:                                                                        | N/A                                                                                       |


### Response

**[RefuelShipResponse](../../models/requests/RefuelShipResponse.md)**


## PurchaseCargo

Purchase cargo from a market.

The ship must be docked in a waypoint that has `Marketplace` trait, and the market must be selling a good to be able to purchase it.

The maximum amount of units of a good that can be purchased in each transaction are denoted by the `tradeVolume` value of the good, which can be viewed by using the Get Market action.

Purchased goods are added to the ship's cargo hold.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;
using Openapi.Models.Components;

var sdk = new SeUnitySDK();

using(var res = await sdk.Fleet.PurchaseCargoAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    shipSymbol: "<value>",
    requestBody: new PurchaseCargoPurchaseCargoRequest() {
    Symbol = TradeSymbolJson.PreciousStones,
    Units = 309761,
}))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `security`                                                                                      | [Openapi.Models.Requests.PurchaseCargoSecurity](../../models/requests/PurchaseCargoSecurity.md) | :heavy_check_mark:                                                                              | The security requirements to use for the request.                                               |
| `ShipSymbol`                                                                                    | *string*                                                                                        | :heavy_check_mark:                                                                              | The ship's symbol.                                                                              |
| `RequestBody`                                                                                   | [PurchaseCargoPurchaseCargoRequest](../../Models/Requests/PurchaseCargoPurchaseCargoRequest.md) | :heavy_minus_sign:                                                                              | N/A                                                                                             |


### Response

**[PurchaseCargoResponse](../../models/requests/PurchaseCargoResponse.md)**


## TransferCargo

Transfer cargo between ships.

The receiving ship must be in the same waypoint as the transferring ship, and it must able to hold the additional cargo after the transfer is complete. Both ships also must be in the same state, either both are docked or both are orbiting.

The response body's cargo shows the cargo of the transferring ship after the transfer is complete.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;
using Openapi.Models.Components;

var sdk = new SeUnitySDK();

using(var res = await sdk.Fleet.TransferCargoAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    shipSymbol: "<value>",
    requestBody: new TransferCargoTransferCargoRequest() {
    TradeSymbol = TradeSymbolJson.EngineHyperDriveI,
    Units = 300373,
    ShipSymbol = "<value>",
}))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `security`                                                                                      | [Openapi.Models.Requests.TransferCargoSecurity](../../models/requests/TransferCargoSecurity.md) | :heavy_check_mark:                                                                              | The security requirements to use for the request.                                               |
| `ShipSymbol`                                                                                    | *string*                                                                                        | :heavy_check_mark:                                                                              | The transferring ship's symbol.                                                                 |
| `RequestBody`                                                                                   | [TransferCargoTransferCargoRequest](../../Models/Requests/TransferCargoTransferCargoRequest.md) | :heavy_minus_sign:                                                                              | N/A                                                                                             |


### Response

**[TransferCargoResponse](../../models/requests/TransferCargoResponse.md)**


## NegotiateContract

Negotiate a new contract with the HQ.

In order to negotiate a new contract, an agent must not have ongoing or offered contracts over the allowed maximum amount. Currently the maximum contracts an agent can have at a time is 1.

Once a contract is negotiated, it is added to the list of contracts offered to the agent, which the agent can then accept. 

The ship must be present at any waypoint with a faction present to negotiate a contract with that faction.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Fleet.NegotiateContractAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    shipSymbol: "<value>"))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `security`                                                                                              | [Openapi.Models.Requests.NegotiateContractSecurity](../../models/requests/NegotiateContractSecurity.md) | :heavy_check_mark:                                                                                      | The security requirements to use for the request.                                                       |
| `ShipSymbol`                                                                                            | *string*                                                                                                | :heavy_check_mark:                                                                                      | The ship's symbol.                                                                                      |


### Response

**[NegotiateContractResponse](../../models/requests/NegotiateContractResponse.md)**


## GetMounts

Get the mounts installed on a ship.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Fleet.GetMountsAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    shipSymbol: "<value>"))
{
    // handle response
}
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `security`                                                                              | [Openapi.Models.Requests.GetMountsSecurity](../../models/requests/GetMountsSecurity.md) | :heavy_check_mark:                                                                      | The security requirements to use for the request.                                       |
| `ShipSymbol`                                                                            | *string*                                                                                | :heavy_check_mark:                                                                      | The ship's symbol.                                                                      |


### Response

**[GetMountsResponse](../../models/requests/GetMountsResponse.md)**


## InstallMount

Install a mount on a ship.

In order to install a mount, the ship must be docked and located in a waypoint that has a `Shipyard` trait. The ship also must have the mount to install in its cargo hold.

An installation fee will be deduced by the Shipyard for installing the mount on the ship. 

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Fleet.InstallMountAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    shipSymbol: "<value>",
    requestBody: new InstallMountInstallMountRequest() {
    Symbol = "<value>",
}))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `security`                                                                                    | [Openapi.Models.Requests.InstallMountSecurity](../../models/requests/InstallMountSecurity.md) | :heavy_check_mark:                                                                            | The security requirements to use for the request.                                             |
| `ShipSymbol`                                                                                  | *string*                                                                                      | :heavy_check_mark:                                                                            | The ship's symbol.                                                                            |
| `RequestBody`                                                                                 | [InstallMountInstallMountRequest](../../Models/Requests/InstallMountInstallMountRequest.md)   | :heavy_minus_sign:                                                                            | N/A                                                                                           |


### Response

**[InstallMountResponse](../../models/requests/InstallMountResponse.md)**


## RemoveMount

Remove a mount from a ship.

The ship must be docked in a waypoint that has the `Shipyard` trait, and must have the desired mount that it wish to remove installed.

A removal fee will be deduced from the agent by the Shipyard.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Fleet.RemoveMountAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    shipSymbol: "<value>",
    requestBody: new RemoveMountRemoveMountRequest() {
    Symbol = "<value>",
}))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `security`                                                                                  | [Openapi.Models.Requests.RemoveMountSecurity](../../models/requests/RemoveMountSecurity.md) | :heavy_check_mark:                                                                          | The security requirements to use for the request.                                           |
| `ShipSymbol`                                                                                | *string*                                                                                    | :heavy_check_mark:                                                                          | The ship's symbol.                                                                          |
| `RequestBody`                                                                               | [RemoveMountRemoveMountRequest](../../Models/Requests/RemoveMountRemoveMountRequest.md)     | :heavy_minus_sign:                                                                          | N/A                                                                                         |


### Response

**[RemoveMountResponse](../../models/requests/RemoveMountResponse.md)**


## GetScrapShip

Get the amount of value that will be returned when scrapping a ship.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Fleet.GetScrapShipAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    shipSymbol: "<value>"))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `security`                                                                                    | [Openapi.Models.Requests.GetScrapShipSecurity](../../models/requests/GetScrapShipSecurity.md) | :heavy_check_mark:                                                                            | The security requirements to use for the request.                                             |
| `ShipSymbol`                                                                                  | *string*                                                                                      | :heavy_check_mark:                                                                            | The ship symbol.                                                                              |


### Response

**[GetScrapShipResponse](../../models/requests/GetScrapShipResponse.md)**


## ScrapShip

Scrap a ship, removing it from the game and returning a portion of the ship's value to the agent. The ship must be docked in a waypoint that has the `Shipyard` trait in order to use this function. To preview the amount of value that will be returned, use the Get Ship action.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Fleet.ScrapShipAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    shipSymbol: "<value>"))
{
    // handle response
}
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `security`                                                                              | [Openapi.Models.Requests.ScrapShipSecurity](../../models/requests/ScrapShipSecurity.md) | :heavy_check_mark:                                                                      | The security requirements to use for the request.                                       |
| `ShipSymbol`                                                                            | *string*                                                                                | :heavy_check_mark:                                                                      | The ship symbol.                                                                        |


### Response

**[ScrapShipResponse](../../models/requests/ScrapShipResponse.md)**


## GetRepairShip

Get the cost of repairing a ship.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Fleet.GetRepairShipAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    shipSymbol: "<value>"))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `security`                                                                                      | [Openapi.Models.Requests.GetRepairShipSecurity](../../models/requests/GetRepairShipSecurity.md) | :heavy_check_mark:                                                                              | The security requirements to use for the request.                                               |
| `ShipSymbol`                                                                                    | *string*                                                                                        | :heavy_check_mark:                                                                              | The ship symbol.                                                                                |


### Response

**[GetRepairShipResponse](../../models/requests/GetRepairShipResponse.md)**


## RepairShip

Repair a ship, restoring the ship to maximum condition. The ship must be docked at a waypoint that has the `Shipyard` trait in order to use this function. To preview the cost of repairing the ship, use the Get action.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Fleet.RepairShipAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    shipSymbol: "<value>"))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `security`                                                                                | [Openapi.Models.Requests.RepairShipSecurity](../../models/requests/RepairShipSecurity.md) | :heavy_check_mark:                                                                        | The security requirements to use for the request.                                         |
| `ShipSymbol`                                                                              | *string*                                                                                  | :heavy_check_mark:                                                                        | The ship symbol.                                                                          |


### Response

**[RepairShipResponse](../../models/requests/RepairShipResponse.md)**

