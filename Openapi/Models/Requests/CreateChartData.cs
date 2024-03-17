
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Openapi.Models.Requests
{
    using Newtonsoft.Json;
    using Openapi.Models.Components;
    using System;
    using UnityEngine;
    
    [Serializable]
    public class CreateChartData
    {

        /// <summary>
        /// The chart of a system or waypoint, which makes the location visible to other agents.
        /// </summary>
        [SerializeField]
        [JsonProperty("chart")]
        public ChartJson Chart { get; set; } = default!;
        

        /// <summary>
        /// A waypoint is a location that ships can travel to such as a Planet, Moon or Space Station.
        /// </summary>
        [SerializeField]
        [JsonProperty("waypoint")]
        public WaypointJson Waypoint { get; set; } = default!;
        
    }
}