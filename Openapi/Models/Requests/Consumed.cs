
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
    public class Consumed
    {

        /// <summary>
        /// Symbol of the good.
        /// </summary>
        [SerializeField]
        [JsonProperty("tradeSymbol")]
        public string TradeSymbol { get; set; } = default!;
        

        /// <summary>
        /// Amount of units of the good.
        /// </summary>
        [SerializeField]
        [JsonProperty("units")]
        public long Units { get; set; } = default!;
        
    }
}