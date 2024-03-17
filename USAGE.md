<!-- Start SDK Example Usage [usage] -->
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