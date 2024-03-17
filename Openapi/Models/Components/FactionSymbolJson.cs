
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
    /// The symbol of the faction.
    /// </summary>
    public enum FactionSymbolJson
    {
        [JsonProperty("COSMIC")]
        Cosmic,
        [JsonProperty("VOID")]
        Void,
        [JsonProperty("GALACTIC")]
        Galactic,
        [JsonProperty("QUANTUM")]
        Quantum,
        [JsonProperty("DOMINION")]
        Dominion,
        [JsonProperty("ASTRO")]
        Astro,
        [JsonProperty("CORSAIRS")]
        Corsairs,
        [JsonProperty("OBSIDIAN")]
        Obsidian,
        [JsonProperty("AEGIS")]
        Aegis,
        [JsonProperty("UNITED")]
        United,
        [JsonProperty("SOLITARY")]
        Solitary,
        [JsonProperty("COBALT")]
        Cobalt,
        [JsonProperty("OMEGA")]
        Omega,
        [JsonProperty("ECHO")]
        Echo,
        [JsonProperty("LORDS")]
        Lords,
        [JsonProperty("CULT")]
        Cult,
        [JsonProperty("ANCIENTS")]
        Ancients,
        [JsonProperty("SHADOW")]
        Shadow,
        [JsonProperty("ETHEREAL")]
        Ethereal,
    }

    public static class FactionSymbolJsonExtension
    {
        public static string Value(this FactionSymbolJson value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static FactionSymbolJson ToEnum(this string value)
        {
            foreach(var field in typeof(FactionSymbolJson).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    return (FactionSymbolJson)field.GetValue(null);
                }
            }

            throw new Exception($"Unknown value {value} for enum FactionSymbolJson");
        }
    }

}