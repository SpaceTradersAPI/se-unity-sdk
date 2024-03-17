# Agents
(*Agents*)

## Overview

Agents

### Available Operations

* [GetMyAgent](#getmyagent) - Get Agent
* [GetAgents](#getagents) - List Agents
* [GetAgent](#getagent) - Get Public Agent

## GetMyAgent

Fetch your agent's details.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Agents.GetMyAgentAsync("<YOUR_BEARER_TOKEN_HERE>"))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `security`                                                                                | [Openapi.Models.Requests.GetMyAgentSecurity](../../models/requests/GetMyAgentSecurity.md) | :heavy_check_mark:                                                                        | The security requirements to use for the request.                                         |


### Response

**[GetMyAgentResponse](../../models/requests/GetMyAgentResponse.md)**


## GetAgents

Fetch agents details.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Components;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Agents.GetAgentsAsync(
    page: 648237,
    limit: 113864))
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

**[GetAgentsResponse](../../models/requests/GetAgentsResponse.md)**


## GetAgent

Fetch agent details.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Components;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Agents.GetAgentAsync(agentSymbol: "<value>"))
{
    // handle response
}
```

### Parameters

| Parameter          | Type               | Required           | Description        |
| ------------------ | ------------------ | ------------------ | ------------------ |
| `AgentSymbol`      | *string*           | :heavy_check_mark: | The agent symbol   |


### Response

**[GetAgentResponse](../../models/requests/GetAgentResponse.md)**

