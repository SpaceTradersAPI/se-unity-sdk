# ContractTermsJson

The terms to fulfill the contract.


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `Deadline`                                                                            | [DateTime](https://learn.microsoft.com/en-us/dotnet/api/system.datetime?view=net-5.0) | :heavy_check_mark:                                                                    | The deadline for the contract.                                                        |
| `Payment`                                                                             | [ContractPaymentJson](../../Models/Components/ContractPaymentJson.md)                 | :heavy_check_mark:                                                                    | Payments for the contract.                                                            |
| `Deliver`                                                                             | List<[ContractDeliverGoodJson](../../Models/Components/ContractDeliverGoodJson.md)>   | :heavy_minus_sign:                                                                    | The cargo that needs to be delivered to fulfill the contract.                         |