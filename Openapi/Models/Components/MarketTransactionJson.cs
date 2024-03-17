
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
    /// Result of a transaction with a market.
    /// </summary>
    [Serializable]
    public class MarketTransactionJson
    {

        /// <summary>
        /// The symbol of the waypoint.
        /// </summary>
        [SerializeField]
        [JsonProperty("waypointSymbol")]
        public string WaypointSymbol { get; set; } = default!;
        

        /// <summary>
        /// The symbol of the ship that made the transaction.
        /// </summary>
        [SerializeField]
        [JsonProperty("shipSymbol")]
        public string ShipSymbol { get; set; } = default!;
        

        /// <summary>
        /// The symbol of the trade good.
        /// </summary>
        [SerializeField]
        [JsonProperty("tradeSymbol")]
        public string TradeSymbol { get; set; } = default!;
        

        /// <summary>
        /// The type of transaction.
        /// </summary>
        [SerializeField]
        [JsonProperty("type")]
        public MarketTransactionJsonType1 Type { get; set; } = default!;
        

        /// <summary>
        /// The number of units of the transaction.
        /// </summary>
        [SerializeField]
        [JsonProperty("units")]
        public long Units { get; set; } = default!;
        

        /// <summary>
        /// The price per unit of the transaction.
        /// </summary>
        [SerializeField]
        [JsonProperty("pricePerUnit")]
        public long PricePerUnit { get; set; } = default!;
        

        /// <summary>
        /// The total price of the transaction.
        /// </summary>
        [SerializeField]
        [JsonProperty("totalPrice")]
        public long TotalPrice { get; set; } = default!;
        

        /// <summary>
        /// The timestamp of the transaction.
        /// </summary>
        [SerializeField]
        [JsonProperty("timestamp")]
        public DateTime Timestamp { get; set; } = default!;
        
    }
}