
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
    using System.Collections.Generic;
    using System;
    using UnityEngine;
    
    /// <summary>
    /// A mount is installed on the exterier of a ship.
    /// </summary>
    [Serializable]
    public class ShipMountJson
    {

        /// <summary>
        /// Symbo of this mount.
        /// </summary>
        [SerializeField]
        [JsonProperty("symbol")]
        public ShipMountJsonSymbol1 Symbol { get; set; } = default!;
        

        /// <summary>
        /// Name of this mount.
        /// </summary>
        [SerializeField]
        [JsonProperty("name")]
        public string Name { get; set; } = default!;
        

        /// <summary>
        /// Description of this mount.
        /// </summary>
        [SerializeField]
        [JsonProperty("description")]
        public string? Description { get; set; }
        

        /// <summary>
        /// Mounts that have this value, such as mining lasers, denote how powerful this mount&apos;s capabilities are.
        /// </summary>
        [SerializeField]
        [JsonProperty("strength")]
        public long? Strength { get; set; }
        

        /// <summary>
        /// Mounts that have this value denote what goods can be produced from using the mount.
        /// </summary>
        [SerializeField]
        [JsonProperty("deposits")]
        public List<ShipMountJsonDeposits>? Deposits { get; set; }
        

        /// <summary>
        /// The requirements for installation on a ship
        /// </summary>
        [SerializeField]
        [JsonProperty("requirements")]
        public ShipRequirementsJson Requirements { get; set; } = default!;
        
    }
}