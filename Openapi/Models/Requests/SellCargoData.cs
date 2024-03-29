
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
    public class SellCargoData
    {

        /// <summary>
        /// Agent details.
        /// </summary>
        [SerializeField]
        [JsonProperty("agent")]
        public AgentJson Agent { get; set; } = default!;
        

        /// <summary>
        /// Ship cargo details.
        /// </summary>
        [SerializeField]
        [JsonProperty("cargo")]
        public ShipCargoJson Cargo { get; set; } = default!;
        

        /// <summary>
        /// Result of a transaction with a market.
        /// </summary>
        [SerializeField]
        [JsonProperty("transaction")]
        public MarketTransactionJson Transaction { get; set; } = default!;
        
    }
}