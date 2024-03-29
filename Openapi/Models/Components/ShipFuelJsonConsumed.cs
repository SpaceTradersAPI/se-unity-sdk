
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
    /// An object that only shows up when an action has consumed fuel in the process. Shows the fuel consumption data.
    /// </summary>
    [Serializable]
    public class ShipFuelJsonConsumed
    {

        /// <summary>
        /// The amount of fuel consumed by the most recent transit or action.
        /// </summary>
        [SerializeField]
        [JsonProperty("amount")]
        public long Amount { get; set; } = default!;
        

        /// <summary>
        /// The time at which the fuel was consumed.
        /// </summary>
        [SerializeField]
        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; } = default!;
        
    }
}