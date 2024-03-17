# CreateSurveyData


## Fields

| Field                                                                          | Type                                                                           | Required                                                                       | Description                                                                    |
| ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------ |
| `Cooldown`                                                                     | [CooldownJson](../../Models/Components/CooldownJson.md)                        | :heavy_check_mark:                                                             | A cooldown is a period of time in which a ship cannot perform certain actions. |
| `Surveys`                                                                      | List<[SurveyJson](../../Models/Components/SurveyJson.md)>                      | :heavy_check_mark:                                                             | Surveys created by this action.                                                |