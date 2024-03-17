
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
    /// The ship&apos;s set speed when traveling between waypoints or systems.
    /// </summary>
    public enum ShipNavFlightModeJson
    {
        [JsonProperty("DRIFT")]
        Drift,
        [JsonProperty("STEALTH")]
        Stealth,
        [JsonProperty("CRUISE")]
        Cruise,
        [JsonProperty("BURN")]
        Burn,
    }

    public static class ShipNavFlightModeJsonExtension
    {
        public static string Value(this ShipNavFlightModeJson value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ShipNavFlightModeJson ToEnum(this string value)
        {
            foreach(var field in typeof(ShipNavFlightModeJson).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    return (ShipNavFlightModeJson)field.GetValue(null);
                }
            }

            throw new Exception($"Unknown value {value} for enum ShipNavFlightModeJson");
        }
    }

}