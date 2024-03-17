
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
    /// The symbol of the module.
    /// </summary>
    public enum ShipModuleJsonSymbol
    {
        [JsonProperty("MODULE_MINERAL_PROCESSOR_I")]
        ModuleMineralProcessorI,
        [JsonProperty("MODULE_GAS_PROCESSOR_I")]
        ModuleGasProcessorI,
        [JsonProperty("MODULE_CARGO_HOLD_I")]
        ModuleCargoHoldI,
        [JsonProperty("MODULE_CARGO_HOLD_II")]
        ModuleCargoHoldIi,
        [JsonProperty("MODULE_CARGO_HOLD_III")]
        ModuleCargoHoldIii,
        [JsonProperty("MODULE_CREW_QUARTERS_I")]
        ModuleCrewQuartersI,
        [JsonProperty("MODULE_ENVOY_QUARTERS_I")]
        ModuleEnvoyQuartersI,
        [JsonProperty("MODULE_PASSENGER_CABIN_I")]
        ModulePassengerCabinI,
        [JsonProperty("MODULE_MICRO_REFINERY_I")]
        ModuleMicroRefineryI,
        [JsonProperty("MODULE_ORE_REFINERY_I")]
        ModuleOreRefineryI,
        [JsonProperty("MODULE_FUEL_REFINERY_I")]
        ModuleFuelRefineryI,
        [JsonProperty("MODULE_SCIENCE_LAB_I")]
        ModuleScienceLabI,
        [JsonProperty("MODULE_JUMP_DRIVE_I")]
        ModuleJumpDriveI,
        [JsonProperty("MODULE_JUMP_DRIVE_II")]
        ModuleJumpDriveIi,
        [JsonProperty("MODULE_JUMP_DRIVE_III")]
        ModuleJumpDriveIii,
        [JsonProperty("MODULE_WARP_DRIVE_I")]
        ModuleWarpDriveI,
        [JsonProperty("MODULE_WARP_DRIVE_II")]
        ModuleWarpDriveIi,
        [JsonProperty("MODULE_WARP_DRIVE_III")]
        ModuleWarpDriveIii,
        [JsonProperty("MODULE_SHIELD_GENERATOR_I")]
        ModuleShieldGeneratorI,
        [JsonProperty("MODULE_SHIELD_GENERATOR_II")]
        ModuleShieldGeneratorIi,
    }

    public static class ShipModuleJsonSymbolExtension
    {
        public static string Value(this ShipModuleJsonSymbol value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ShipModuleJsonSymbol ToEnum(this string value)
        {
            foreach(var field in typeof(ShipModuleJsonSymbol).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    return (ShipModuleJsonSymbol)field.GetValue(null);
                }
            }

            throw new Exception($"Unknown value {value} for enum ShipModuleJsonSymbol");
        }
    }

}