
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
    public class TransferCargoTransferCargoRequest
    {

        /// <summary>
        /// The good&apos;s symbol.
        /// </summary>
        [SerializeField]
        [JsonProperty("tradeSymbol")]
        public TradeSymbolJson TradeSymbol { get; set; } = default!;
        

        /// <summary>
        /// Amount of units to transfer.
        /// </summary>
        [SerializeField]
        [JsonProperty("units")]
        public long Units { get; set; } = default!;
        

        /// <summary>
        /// The symbol of the ship to transfer to.
        /// </summary>
        [SerializeField]
        [JsonProperty("shipSymbol")]
        public string ShipSymbol { get; set; } = default!;
        
    }
}