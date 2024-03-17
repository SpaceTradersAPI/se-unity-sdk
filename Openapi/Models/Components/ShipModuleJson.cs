
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
    /// A module can be installed in a ship and provides a set of capabilities such as storage space or quarters for crew. Module installations are permanent.
    /// </summary>
    [Serializable]
    public class ShipModuleJson
    {

        /// <summary>
        /// The symbol of the module.
        /// </summary>
        [SerializeField]
        [JsonProperty("symbol")]
        public ShipModuleJsonSymbol Symbol { get; set; } = default!;
        

        /// <summary>
        /// Modules that provide capacity, such as cargo hold or crew quarters will show this value to denote how much of a bonus the module grants.
        /// </summary>
        [SerializeField]
        [JsonProperty("capacity")]
        public long? Capacity { get; set; }
        

        /// <summary>
        /// Modules that have a range will such as a sensor array show this value to denote how far can the module reach with its capabilities.
        /// </summary>
        [SerializeField]
        [JsonProperty("range")]
        public long? Range { get; set; }
        

        /// <summary>
        /// Name of this module.
        /// </summary>
        [SerializeField]
        [JsonProperty("name")]
        public string Name { get; set; } = default!;
        

        /// <summary>
        /// Description of this module.
        /// </summary>
        [SerializeField]
        [JsonProperty("description")]
        public string Description { get; set; } = default!;
        

        /// <summary>
        /// The requirements for installation on a ship
        /// </summary>
        [SerializeField]
        [JsonProperty("requirements")]
        public ShipRequirementsJson Requirements { get; set; } = default!;
        
    }
}