
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
    /// The ship&apos;s crew service and maintain the ship&apos;s systems and equipment.
    /// </summary>
    [Serializable]
    public class ShipCrewJson
    {

        /// <summary>
        /// The current number of crew members on the ship.
        /// </summary>
        [SerializeField]
        [JsonProperty("current")]
        public long Current { get; set; } = default!;
        

        /// <summary>
        /// The minimum number of crew members required to maintain the ship.
        /// </summary>
        [SerializeField]
        [JsonProperty("required")]
        public long Required { get; set; } = default!;
        

        /// <summary>
        /// The maximum number of crew members the ship can support.
        /// </summary>
        [SerializeField]
        [JsonProperty("capacity")]
        public long Capacity { get; set; } = default!;
        

        /// <summary>
        /// The rotation of crew shifts. A stricter shift improves the ship&apos;s performance. A more relaxed shift improves the crew&apos;s morale.
        /// </summary>
        [SerializeField]
        [JsonProperty("rotation")]
        public Rotation Rotation { get; set; } = default!;
        

        /// <summary>
        /// A rough measure of the crew&apos;s morale. A higher morale means the crew is happier and more productive. A lower morale means the ship is more prone to accidents.
        /// </summary>
        [SerializeField]
        [JsonProperty("morale")]
        public long Morale { get; set; } = default!;
        

        /// <summary>
        /// The amount of credits per crew member paid per hour. Wages are paid when a ship docks at a civilized waypoint.
        /// </summary>
        [SerializeField]
        [JsonProperty("wages")]
        public long Wages { get; set; } = default!;
        
    }
}