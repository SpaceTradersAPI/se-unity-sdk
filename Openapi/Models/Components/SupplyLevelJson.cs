
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Openapi.Models.Components
{
    using Newtonsoft.Json;
    using System;
    using UnityEngine;
    
    /// <summary>
    /// The supply level of a trade good.
    /// </summary>
    public enum SupplyLevelJson
    {
        [JsonProperty("SCARCE")]
        Scarce,
        [JsonProperty("LIMITED")]
        Limited,
        [JsonProperty("MODERATE")]
        Moderate,
        [JsonProperty("HIGH")]
        High,
        [JsonProperty("ABUNDANT")]
        Abundant,
    }

    public static class SupplyLevelJsonExtension
    {
        public static string Value(this SupplyLevelJson value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static SupplyLevelJson ToEnum(this string value)
        {
            foreach(var field in typeof(SupplyLevelJson).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    return (SupplyLevelJson)field.GetValue(null);
                }
            }

            throw new Exception($"Unknown value {value} for enum SupplyLevelJson");
        }
    }

}