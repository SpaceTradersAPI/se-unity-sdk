
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
    /// Agent details.
    /// </summary>
    [Serializable]
    public class AgentJson
    {

        /// <summary>
        /// Account ID that is tied to this agent. Only included on your own agent.
        /// </summary>
        [SerializeField]
        [JsonProperty("accountId")]
        public string? AccountId { get; set; }
        

        /// <summary>
        /// Symbol of the agent.
        /// </summary>
        [SerializeField]
        [JsonProperty("symbol")]
        public string Symbol { get; set; } = default!;
        

        /// <summary>
        /// The headquarters of the agent.
        /// </summary>
        [SerializeField]
        [JsonProperty("headquarters")]
        public string Headquarters { get; set; } = default!;
        

        /// <summary>
        /// The number of credits the agent has available. Credits can be negative if funds have been overdrawn.
        /// </summary>
        [SerializeField]
        [JsonProperty("credits")]
        public long Credits { get; set; } = default!;
        

        /// <summary>
        /// The faction the agent started with.
        /// </summary>
        [SerializeField]
        [JsonProperty("startingFaction")]
        public string StartingFaction { get; set; } = default!;
        

        /// <summary>
        /// How many ships are owned by the agent.
        /// </summary>
        [SerializeField]
        [JsonProperty("shipCount")]
        public long ShipCount { get; set; } = default!;
        
    }
}