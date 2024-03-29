
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
    /// The unique identifier of the trait.
    /// </summary>
    public enum FactionTraitSymbolJson
    {
        [JsonProperty("BUREAUCRATIC")]
        Bureaucratic,
        [JsonProperty("SECRETIVE")]
        Secretive,
        [JsonProperty("CAPITALISTIC")]
        Capitalistic,
        [JsonProperty("INDUSTRIOUS")]
        Industrious,
        [JsonProperty("PEACEFUL")]
        Peaceful,
        [JsonProperty("DISTRUSTFUL")]
        Distrustful,
        [JsonProperty("WELCOMING")]
        Welcoming,
        [JsonProperty("SMUGGLERS")]
        Smugglers,
        [JsonProperty("SCAVENGERS")]
        Scavengers,
        [JsonProperty("REBELLIOUS")]
        Rebellious,
        [JsonProperty("EXILES")]
        Exiles,
        [JsonProperty("PIRATES")]
        Pirates,
        [JsonProperty("RAIDERS")]
        Raiders,
        [JsonProperty("CLAN")]
        Clan,
        [JsonProperty("GUILD")]
        Guild,
        [JsonProperty("DOMINION")]
        Dominion,
        [JsonProperty("FRINGE")]
        Fringe,
        [JsonProperty("FORSAKEN")]
        Forsaken,
        [JsonProperty("ISOLATED")]
        Isolated,
        [JsonProperty("LOCALIZED")]
        Localized,
        [JsonProperty("ESTABLISHED")]
        Established,
        [JsonProperty("NOTABLE")]
        Notable,
        [JsonProperty("DOMINANT")]
        Dominant,
        [JsonProperty("INESCAPABLE")]
        Inescapable,
        [JsonProperty("INNOVATIVE")]
        Innovative,
        [JsonProperty("BOLD")]
        Bold,
        [JsonProperty("VISIONARY")]
        Visionary,
        [JsonProperty("CURIOUS")]
        Curious,
        [JsonProperty("DARING")]
        Daring,
        [JsonProperty("EXPLORATORY")]
        Exploratory,
        [JsonProperty("RESOURCEFUL")]
        Resourceful,
        [JsonProperty("FLEXIBLE")]
        Flexible,
        [JsonProperty("COOPERATIVE")]
        Cooperative,
        [JsonProperty("UNITED")]
        United,
        [JsonProperty("STRATEGIC")]
        Strategic,
        [JsonProperty("INTELLIGENT")]
        Intelligent,
        [JsonProperty("RESEARCH_FOCUSED")]
        ResearchFocused,
        [JsonProperty("COLLABORATIVE")]
        Collaborative,
        [JsonProperty("PROGRESSIVE")]
        Progressive,
        [JsonProperty("MILITARISTIC")]
        Militaristic,
        [JsonProperty("TECHNOLOGICALLY_ADVANCED")]
        TechnologicallyAdvanced,
        [JsonProperty("AGGRESSIVE")]
        Aggressive,
        [JsonProperty("IMPERIALISTIC")]
        Imperialistic,
        [JsonProperty("TREASURE_HUNTERS")]
        TreasureHunters,
        [JsonProperty("DEXTEROUS")]
        Dexterous,
        [JsonProperty("UNPREDICTABLE")]
        Unpredictable,
        [JsonProperty("BRUTAL")]
        Brutal,
        [JsonProperty("FLEETING")]
        Fleeting,
        [JsonProperty("ADAPTABLE")]
        Adaptable,
        [JsonProperty("SELF_SUFFICIENT")]
        SelfSufficient,
        [JsonProperty("DEFENSIVE")]
        Defensive,
        [JsonProperty("PROUD")]
        Proud,
        [JsonProperty("DIVERSE")]
        Diverse,
        [JsonProperty("INDEPENDENT")]
        Independent,
        [JsonProperty("SELF_INTERESTED")]
        SelfInterested,
        [JsonProperty("FRAGMENTED")]
        Fragmented,
        [JsonProperty("COMMERCIAL")]
        Commercial,
        [JsonProperty("FREE_MARKETS")]
        FreeMarkets,
        [JsonProperty("ENTREPRENEURIAL")]
        Entrepreneurial,
    }

    public static class FactionTraitSymbolJsonExtension
    {
        public static string Value(this FactionTraitSymbolJson value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static FactionTraitSymbolJson ToEnum(this string value)
        {
            foreach(var field in typeof(FactionTraitSymbolJson).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    return (FactionTraitSymbolJson)field.GetValue(null);
                }
            }

            throw new Exception($"Unknown value {value} for enum FactionTraitSymbolJson");
        }
    }

}