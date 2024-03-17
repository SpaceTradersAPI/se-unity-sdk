
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
    /// The reactor of the ship. The reactor is responsible for powering the ship&apos;s systems and weapons.
    /// </summary>
    [Serializable]
    public class ShipReactorJson
    {

        /// <summary>
        /// Symbol of the reactor.
        /// </summary>
        [SerializeField]
        [JsonProperty("symbol")]
        public ShipReactorJsonSymbol Symbol { get; set; } = default!;
        

        /// <summary>
        /// Name of the reactor.
        /// </summary>
        [SerializeField]
        [JsonProperty("name")]
        public string Name { get; set; } = default!;
        

        /// <summary>
        /// Description of the reactor.
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
        /// The amount of power provided by this reactor. The more power a reactor provides to the ship, the lower the cooldown it gets when using a module or mount that taxes the ship&apos;s power.
        /// </summary>
        [SerializeField]
        [JsonProperty("powerOutput")]
        public long PowerOutput { get; set; } = default!;
        

        /// <summary>
        /// The requirements for installation on a ship
        /// </summary>
        [SerializeField]
        [JsonProperty("requirements")]
        public ShipRequirementsJson Requirements { get; set; } = default!;
        
    }
}