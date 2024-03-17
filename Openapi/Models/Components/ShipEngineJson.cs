
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
    /// The engine determines how quickly a ship travels between waypoints.
    /// </summary>
    [Serializable]
    public class ShipEngineJson
    {

        /// <summary>
        /// The symbol of the engine.
        /// </summary>
        [SerializeField]
        [JsonProperty("symbol")]
        public ShipEngineJsonSymbol Symbol { get; set; } = default!;
        

        /// <summary>
        /// The name of the engine.
        /// </summary>
        [SerializeField]
        [JsonProperty("name")]
        public string Name { get; set; } = default!;
        

        /// <summary>
        /// The description of the engine.
        /// </summary>
        [SerializeField]
        [JsonProperty("description")]
        public string Description { get; set; } = default!;
        

        /// <summary>
        /// The repairable condition of a component. A value of 0 indicates the component needs significant repairs, while a value of 1 indicates the component is in near perfect condition. As the condition of a component is repaired, the overall integrity of the component decreases.
        /// </summary>
        [SerializeField]
        [JsonProperty("condition")]
        public double Condition { get; set; } = default!;
        

        /// <summary>
        /// The overall integrity of the component, which determines the performance of the component. A value of 0 indicates that the component is almost completely degraded, while a value of 1 indicates that the component is in near perfect condition. The integrity of the component is non-repairable, and represents permanent wear over time.
        /// </summary>
        [SerializeField]
        [JsonProperty("integrity")]
        public double Integrity { get; set; } = default!;
        

        /// <summary>
        /// The speed stat of this engine. The higher the speed, the faster a ship can travel from one point to another. Reduces the time of arrival when navigating the ship.
        /// </summary>
        [SerializeField]
        [JsonProperty("speed")]
        public long Speed { get; set; } = default!;
        

        /// <summary>
        /// The requirements for installation on a ship
        /// </summary>
        [SerializeField]
        [JsonProperty("requirements")]
        public ShipRequirementsJson Requirements { get; set; } = default!;
        
    }
}