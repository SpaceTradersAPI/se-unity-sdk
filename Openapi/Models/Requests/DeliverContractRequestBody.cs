
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
    public class DeliverContractRequestBody
    {

        /// <summary>
        /// Symbol of a ship located in the destination to deliver a contract and that has a good to deliver in its cargo.
        /// </summary>
        [SerializeField]
        [JsonProperty("shipSymbol")]
        public string ShipSymbol { get; set; } = default!;
        

        /// <summary>
        /// The symbol of the good to deliver.
        /// </summary>
        [SerializeField]
        [JsonProperty("tradeSymbol")]
        public string TradeSymbol { get; set; } = default!;
        

        /// <summary>
        /// Amount of units to deliver.
        /// </summary>
        [SerializeField]
        [JsonProperty("units")]
        public long Units { get; set; } = default!;
        
    }
}