# SeUnitySDK


## Overview

SpaceTraders API: SpaceTraders is an open-universe game and learning platform that offers a set of HTTP endpoints to control a fleet of ships and explore a multiplayer universe.

The API is documented using [OpenAPI](https://github.com/SpaceTradersAPI/api-docs). You can send your first request right here in your browser to check the status of the game server.

```json http
{
  "method": "GET",
  "url": "https://api.spacetraders.io/v2",
}
```

Unlike a traditional game, SpaceTraders does not have a first-party client or app to play the game. Instead, you can use the API to build your own client, write a script to automate your ships, or try an app built by the community.

We have a [Discord channel](https://discord.com/invite/jh6zurdWk5) where you can share your projects, ask questions, and get help from other players.




### Available Operations

* [GetStatus](#getstatus) - Get Status
* [Register](#register) - Register New Agent

## GetStatus

Return the status of the game server.
This also includes a few global elements, such as announcements, server reset dates and leaderboards.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Components;

var sdk = new SeUnitySDK();

using(var res = await sdk.GetStatusAsync())
{
    // handle response
}
```


### Response

**[GetStatusResponse](../../models/requests/GetStatusResponse.md)**


## Register

Creates a new agent and ties it to an account. 
The agent symbol must consist of a 3-14 character string, and will be used to represent your agent. This symbol will prefix the symbol of every ship you own. Agent symbols will be cast to all uppercase characters.

This new agent will be tied to a starting faction of your choice, which determines your starting location, and will be granted an authorization token, a contract with their starting faction, a command ship that can fly across space with advanced capabilities, a small probe ship that can be used for reconnaissance, and 150,000 credits.

> #### Keep your token safe and secure
>
> Save your token during the alpha phase. There is no way to regenerate this token without starting a new agent. In the future you will be able to generate and manage your tokens from the SpaceTraders website.

If you are new to SpaceTraders, It is recommended to register with the COSMIC faction, a faction that is well connected to the rest of the universe. After registering, you should try our interactive [quickstart guide](https://docs.spacetraders.io/quickstart/new-game) which will walk you through basic API requests in just a few minutes.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Components;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

RegisterRequestBody req = new RegisterRequestBody() {
    Faction = FactionSymbolJson.Quantum,
    Symbol = "BADGER",
};

using(var res = await sdk.RegisterAsync(req))
{
    // handle response
}
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [RegisterRequestBody](../../Models/Requests/RegisterRequestBody.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |


### Response

**[RegisterResponse](../../models/requests/RegisterResponse.md)**

