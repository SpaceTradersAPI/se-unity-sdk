# Factions
(*Factions*)

## Overview

Factions

### Available Operations

* [GetFactions](#getfactions) - List Factions
* [GetFaction](#getfaction) - Get Faction

## GetFactions

Return a paginated list of all the factions in the game.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Components;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Factions.GetFactionsAsync(
    page: 112445,
    limit: 467771))
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

**[GetFactionsResponse](../../models/requests/GetFactionsResponse.md)**


## GetFaction

View the details of a faction.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Components;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK(AgentToken: "<YOUR_BEARER_TOKEN_HERE>");

using(var res = await sdk.Factions.GetFactionAsync(factionSymbol: "COSMIC"))
{
    // handle response
}
```

### Parameters

| Parameter          | Type               | Required           | Description        | Example            |
| ------------------ | ------------------ | ------------------ | ------------------ | ------------------ |
| `FactionSymbol`    | *string*           | :heavy_check_mark: | The faction symbol | COSMIC             |


### Response

**[GetFactionResponse](../../models/requests/GetFactionResponse.md)**

