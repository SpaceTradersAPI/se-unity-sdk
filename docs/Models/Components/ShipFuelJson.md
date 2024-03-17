# ShipFuelJson

Details of the ship's fuel tanks including how much fuel was consumed during the last transit or action.


## Fields

| Field                                                                                                          | Type                                                                                                           | Required                                                                                                       | Description                                                                                                    |
| -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| `Current`                                                                                                      | *long*                                                                                                         | :heavy_check_mark:                                                                                             | The current amount of fuel in the ship's tanks.                                                                |
| `Capacity`                                                                                                     | *long*                                                                                                         | :heavy_check_mark:                                                                                             | The maximum amount of fuel the ship's tanks can hold.                                                          |
| `Consumed`                                                                                                     | [ShipFuelJsonConsumed](../../Models/Components/ShipFuelJsonConsumed.md)                                        | :heavy_minus_sign:                                                                                             | An object that only shows up when an action has consumed fuel in the process. Shows the fuel consumption data. |