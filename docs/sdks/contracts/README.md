# Contracts
(*Contracts*)

## Overview

Contracts

### Available Operations

* [GetContracts](#getcontracts) - List Contracts
* [GetContract](#getcontract) - Get Contract
* [AcceptContract](#acceptcontract) - Accept Contract
* [DeliverContract](#delivercontract) - Deliver Cargo to Contract
* [FulfillContract](#fulfillcontract) - Fulfill Contract

## GetContracts

Return a paginated list of all your contracts.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Contracts.GetContractsAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    page: 907785,
    limit: 306163))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `security`                                                                                    | [Openapi.Models.Requests.GetContractsSecurity](../../models/requests/GetContractsSecurity.md) | :heavy_check_mark:                                                                            | The security requirements to use for the request.                                             |
| `Page`                                                                                        | *long*                                                                                        | :heavy_minus_sign:                                                                            | What entry offset to request                                                                  |
| `Limit`                                                                                       | *long*                                                                                        | :heavy_minus_sign:                                                                            | How many entries to return per page                                                           |


### Response

**[GetContractsResponse](../../models/requests/GetContractsResponse.md)**


## GetContract

Get the details of a contract by ID.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Contracts.GetContractAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    contractId: "<value>"))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `security`                                                                                  | [Openapi.Models.Requests.GetContractSecurity](../../models/requests/GetContractSecurity.md) | :heavy_check_mark:                                                                          | The security requirements to use for the request.                                           |
| `ContractId`                                                                                | *string*                                                                                    | :heavy_check_mark:                                                                          | The contract ID                                                                             |


### Response

**[GetContractResponse](../../models/requests/GetContractResponse.md)**


## AcceptContract

Accept a contract by ID. 

You can only accept contracts that were offered to you, were not accepted yet, and whose deadlines has not passed yet.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Contracts.AcceptContractAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    contractId: "<value>"))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `security`                                                                                        | [Openapi.Models.Requests.AcceptContractSecurity](../../models/requests/AcceptContractSecurity.md) | :heavy_check_mark:                                                                                | The security requirements to use for the request.                                                 |
| `ContractId`                                                                                      | *string*                                                                                          | :heavy_check_mark:                                                                                | The contract ID to accept.                                                                        |


### Response

**[AcceptContractResponse](../../models/requests/AcceptContractResponse.md)**


## DeliverContract

Deliver cargo to a contract.

In order to use this API, a ship must be at the delivery location (denoted in the delivery terms as `destinationSymbol` of a contract) and must have a number of units of a good required by this contract in its cargo.

Cargo that was delivered will be removed from the ship's cargo.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Contracts.DeliverContractAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    contractId: "<value>",
    requestBody: new DeliverContractRequestBody() {
    ShipSymbol = "<value>",
    TradeSymbol = "<value>",
    Units = 800350,
}))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `security`                                                                                          | [Openapi.Models.Requests.DeliverContractSecurity](../../models/requests/DeliverContractSecurity.md) | :heavy_check_mark:                                                                                  | The security requirements to use for the request.                                                   |
| `ContractId`                                                                                        | *string*                                                                                            | :heavy_check_mark:                                                                                  | The ID of the contract.                                                                             |
| `RequestBody`                                                                                       | [DeliverContractRequestBody](../../Models/Requests/DeliverContractRequestBody.md)                   | :heavy_minus_sign:                                                                                  | N/A                                                                                                 |


### Response

**[DeliverContractResponse](../../models/requests/DeliverContractResponse.md)**


## FulfillContract

Fulfill a contract. Can only be used on contracts that have all of their delivery terms fulfilled.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;

var sdk = new SeUnitySDK();

using(var res = await sdk.Contracts.FulfillContractAsync(
    "<YOUR_BEARER_TOKEN_HERE>",
    contractId: "<value>"))
{
    // handle response
}
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `security`                                                                                          | [Openapi.Models.Requests.FulfillContractSecurity](../../models/requests/FulfillContractSecurity.md) | :heavy_check_mark:                                                                                  | The security requirements to use for the request.                                                   |
| `ContractId`                                                                                        | *string*                                                                                            | :heavy_check_mark:                                                                                  | The ID of the contract to fulfill.                                                                  |


### Response

**[FulfillContractResponse](../../models/requests/FulfillContractResponse.md)**

