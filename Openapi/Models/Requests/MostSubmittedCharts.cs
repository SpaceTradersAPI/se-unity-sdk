
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
    using System;
    using UnityEngine;
    
    [Serializable]
    public class MostSubmittedCharts
    {

        /// <summary>
        /// Symbol of the agent.
        /// </summary>
        [SerializeField]
        [JsonProperty("agentSymbol")]
        public string AgentSymbol { get; set; } = default!;
        

        /// <summary>
        /// Amount of charts done by the agent.
        /// </summary>
        [SerializeField]
        [JsonProperty("chartCount")]
        public long ChartCount { get; set; } = default!;
        
    }
}