# openapi

<div align="left">
    <a href="https://speakeasyapi.dev/"><img src="https://custom-icon-badges.demolab.com/badge/-Built%20By%20Speakeasy-212015?style=for-the-badge&logoColor=FBE331&logo=speakeasy&labelColor=545454" /></a>
    <a href="https://opensource.org/licenses/MIT">
        <img src="https://img.shields.io/badge/License-MIT-blue.svg" style="width: 100px; height: 28px;" />
    </a>
</div>


## 🏗 **Welcome to your new SDK!** 🏗

It has been generated successfully based on your OpenAPI spec. However, it is not yet ready for production use. Here are some next steps:
- [ ] 🛠 Make your SDK feel handcrafted by [customizing it](https://www.speakeasyapi.dev/docs/customize-sdks)
- [ ] ♻️ Refine your SDK quickly by iterating locally with the [Speakeasy CLI](https://github.com/speakeasy-api/speakeasy)
- [ ] 🎁 Publish your SDK to package managers by [configuring automatic publishing](https://www.speakeasyapi.dev/docs/productionize-sdks/publish-sdks)
- [ ] ✨ When ready to productionize, delete this section from the README

<!-- Start SDK Installation [installation] -->
## SDK Installation

The SDK can either be compiled using `dotnet build` and the resultant `.dll` file can be copied into your Unity project's `Assets` folder, or you can copy the source code directly into your project.

The SDK relies on Newtonsoft's JSON.NET Package which can be installed via the Unity Package Manager.

To do so open the Package Manager via `Window > Package Manager` and click the `+` button then `Add package from git URL...` and enter `com.unity.nuget.newtonsoft-json` and click `Add`.
<!-- End SDK Installation [installation] -->

<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using Openapi;
using Openapi.Models.Components;

var sdk = new SeUnitySDK();

using(var res = await sdk.GetStatusAsync())
{
    // handle response
}
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

### [SeUnitySDK](docs/sdks/seunitysdk/README.md)

* [GetStatus](docs/sdks/seunitysdk/README.md#getstatus) - Get Status
* [Register](docs/sdks/seunitysdk/README.md#register) - Register New Agent

### [Systems](docs/sdks/systems/README.md)

* [GetSystems](docs/sdks/systems/README.md#getsystems) - List Systems
* [GetSystem](docs/sdks/systems/README.md#getsystem) - Get System
* [GetSystemWaypoints](docs/sdks/systems/README.md#getsystemwaypoints) - List Waypoints in System
* [GetWaypoint](docs/sdks/systems/README.md#getwaypoint) - Get Waypoint
* [GetMarket](docs/sdks/systems/README.md#getmarket) - Get Market
* [GetShipyard](docs/sdks/systems/README.md#getshipyard) - Get Shipyard
* [GetJumpGate](docs/sdks/systems/README.md#getjumpgate) - Get Jump Gate
* [GetConstruction](docs/sdks/systems/README.md#getconstruction) - Get Construction Site
* [SupplyConstruction](docs/sdks/systems/README.md#supplyconstruction) - Supply Construction Site

### [Factions](docs/sdks/factions/README.md)

* [GetFactions](docs/sdks/factions/README.md#getfactions) - List Factions
* [GetFaction](docs/sdks/factions/README.md#getfaction) - Get Faction

### [Agents](docs/sdks/agents/README.md)

* [GetMyAgent](docs/sdks/agents/README.md#getmyagent) - Get Agent
* [GetAgents](docs/sdks/agents/README.md#getagents) - List Agents
* [GetAgent](docs/sdks/agents/README.md#getagent) - Get Public Agent

### [Contracts](docs/sdks/contracts/README.md)

* [GetContracts](docs/sdks/contracts/README.md#getcontracts) - List Contracts
* [GetContract](docs/sdks/contracts/README.md#getcontract) - Get Contract
* [AcceptContract](docs/sdks/contracts/README.md#acceptcontract) - Accept Contract
* [DeliverContract](docs/sdks/contracts/README.md#delivercontract) - Deliver Cargo to Contract
* [FulfillContract](docs/sdks/contracts/README.md#fulfillcontract) - Fulfill Contract

### [Fleet](docs/sdks/fleet/README.md)

* [GetMyShips](docs/sdks/fleet/README.md#getmyships) - List Ships
* [PurchaseShip](docs/sdks/fleet/README.md#purchaseship) - Purchase Ship
* [GetMyShip](docs/sdks/fleet/README.md#getmyship) - Get Ship
* [GetMyShipCargo](docs/sdks/fleet/README.md#getmyshipcargo) - Get Ship Cargo
* [OrbitShip](docs/sdks/fleet/README.md#orbitship) - Orbit Ship
* [ShipRefine](docs/sdks/fleet/README.md#shiprefine) - Ship Refine
* [CreateChart](docs/sdks/fleet/README.md#createchart) - Create Chart
* [GetShipCooldown](docs/sdks/fleet/README.md#getshipcooldown) - Get Ship Cooldown
* [DockShip](docs/sdks/fleet/README.md#dockship) - Dock Ship
* [CreateSurvey](docs/sdks/fleet/README.md#createsurvey) - Create Survey
* [ExtractResources](docs/sdks/fleet/README.md#extractresources) - Extract Resources
* [SiphonResources](docs/sdks/fleet/README.md#siphonresources) - Siphon Resources
* [ExtractResourcesWithSurvey](docs/sdks/fleet/README.md#extractresourceswithsurvey) - Extract Resources with Survey
* [Jettison](docs/sdks/fleet/README.md#jettison) - Jettison Cargo
* [JumpShip](docs/sdks/fleet/README.md#jumpship) - Jump Ship
* [NavigateShip](docs/sdks/fleet/README.md#navigateship) - Navigate Ship
* [PatchShipNav](docs/sdks/fleet/README.md#patchshipnav) - Patch Ship Nav
* [GetShipNav](docs/sdks/fleet/README.md#getshipnav) - Get Ship Nav
* [WarpShip](docs/sdks/fleet/README.md#warpship) - Warp Ship
* [SellCargo](docs/sdks/fleet/README.md#sellcargo) - Sell Cargo
* [CreateShipSystemScan](docs/sdks/fleet/README.md#createshipsystemscan) - Scan Systems
* [CreateShipWaypointScan](docs/sdks/fleet/README.md#createshipwaypointscan) - Scan Waypoints
* [CreateShipShipScan](docs/sdks/fleet/README.md#createshipshipscan) - Scan Ships
* [RefuelShip](docs/sdks/fleet/README.md#refuelship) - Refuel Ship
* [PurchaseCargo](docs/sdks/fleet/README.md#purchasecargo) - Purchase Cargo
* [TransferCargo](docs/sdks/fleet/README.md#transfercargo) - Transfer Cargo
* [NegotiateContract](docs/sdks/fleet/README.md#negotiatecontract) - Negotiate Contract
* [GetMounts](docs/sdks/fleet/README.md#getmounts) - Get Mounts
* [InstallMount](docs/sdks/fleet/README.md#installmount) - Install Mount
* [RemoveMount](docs/sdks/fleet/README.md#removemount) - Remove Mount
* [GetScrapShip](docs/sdks/fleet/README.md#getscrapship) - Get Scrap Ship
* [ScrapShip](docs/sdks/fleet/README.md#scrapship) - Scrap Ship
* [GetRepairShip](docs/sdks/fleet/README.md#getrepairship) - Get Repair Ship
* [RepairShip](docs/sdks/fleet/README.md#repairship) - Repair Ship
<!-- End Available Resources and Operations [operations] -->

<!-- Start Server Selection [server] -->
## Server Selection

## Server Selection

### Select Server by Index

You can override the default server globally by passing a server index to the `serverIndex: number` optional parameter when initializing the SDK client instance. The selected server will then be used as the default on the operations that use it. This table lists the indexes associated with the available servers:

| # | Server | Variables |
| - | ------ | --------- |
| 0 | `https://api.spacetraders.io/v2` | None |




### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverUrl: str` optional parameter when initializing the SDK client instance. For example:
<!-- End Server Selection [server] -->

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name         | Type         | Scheme       |
| ------------ | ------------ | ------------ |
| `AgentToken` | http         | HTTP Bearer  |

To authenticate with the API the `AgentToken` parameter must be set when initializing the SDK client instance. For example:
```csharp
using Openapi;
using Openapi.Models.Components;

var sdk = new SeUnitySDK(AgentToken: "<YOUR_BEARER_TOKEN_HERE>");

using(var res = await sdk.GetStatusAsync())
{
    // handle response
}
```

### Per-Operation Security Schemes

Some operations in this SDK require the security scheme to be specified at the request level. For example:
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
<!-- End Authentication [security] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->

# Development

## Maturity

This SDK is in beta, and there may be breaking changes between versions without a major version update. Therefore, we recommend pinning usage
to a specific package version. This way, you can install the same version each time without breaking changes unless you are intentionally
looking for the latest version.

## Contributions

While we value open-source contributions to this SDK, this library is generated programmatically.
Feel free to open a PR or a Github issue as a proof of concept and we'll do our best to include it in a future release!

### SDK Created by [Speakeasy](https://docs.speakeasyapi.dev/docs/using-speakeasy/client-sdks)
