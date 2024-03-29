
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
    
    [Serializable]
    public class ShipyardShipJson
    {

        /// <summary>
        /// Type of ship
        /// </summary>
        [SerializeField]
        [JsonProperty("type")]
        public ShipTypeJsonShipTypeJson Type { get; set; } = default!;
        

        [SerializeField]
        [JsonProperty("name")]
        public string Name { get; set; } = default!;
        

        [SerializeField]
        [JsonProperty("description")]
        public string Description { get; set; } = default!;
        

        /// <summary>
        /// The supply level of a trade good.
        /// </summary>
        [SerializeField]
        [JsonProperty("supply")]
        public SupplyLevelJson Supply { get; set; } = default!;
        

        /// <summary>
        /// The activity level of a trade good. If the good is an import, this represents how strong consumption is. If the good is an export, this represents how strong the production is for the good. When activity is strong, consumption or production is near maximum capacity. When activity is weak, consumption or production is near minimum capacity.
        /// </summary>
        [SerializeField]
        [JsonProperty("activity")]
        public ActivityLevelJson? Activity { get; set; }
        

        [SerializeField]
        [JsonProperty("purchasePrice")]
        public long PurchasePrice { get; set; } = default!;
        

        /// <summary>
        /// The frame of the ship. The frame determines the number of modules and mounting points of the ship, as well as base fuel capacity. As the condition of the frame takes more wear, the ship will become more sluggish and less maneuverable.
        /// </summary>
        [SerializeField]
        [JsonProperty("frame")]
        public ShipFrameJson Frame { get; set; } = default!;
        

        /// <summary>
        /// The reactor of the ship. The reactor is responsible for powering the ship&apos;s systems and weapons.
        /// </summary>
        [SerializeField]
        [JsonProperty("reactor")]
        public ShipReactorJson Reactor { get; set; } = default!;
        

        /// <summary>
        /// The engine determines how quickly a ship travels between waypoints.
        /// </summary>
        [SerializeField]
        [JsonProperty("engine")]
        public ShipEngineJson Engine { get; set; } = default!;
        

        [SerializeField]
        [JsonProperty("modules")]
        public List<ShipModuleJson> Modules { get; set; } = default!;
        

        [SerializeField]
        [JsonProperty("mounts")]
        public List<ShipMountJsonShipMountJson> Mounts { get; set; } = default!;
        

        [SerializeField]
        [JsonProperty("crew")]
        public Crew Crew { get; set; } = default!;
        
    }
}