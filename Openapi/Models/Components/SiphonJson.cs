
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
    /// Siphon details.
    /// </summary>
    [Serializable]
    public class SiphonJson
    {

        /// <summary>
        /// Symbol of the ship that executed the siphon.
        /// </summary>
        [SerializeField]
        [JsonProperty("shipSymbol")]
        public string ShipSymbol { get; set; } = default!;
        

        /// <summary>
        /// A yield from the siphon operation.
        /// </summary>
        [SerializeField]
        [JsonProperty("yield")]
        public SiphonYieldJson Yield { get; set; } = default!;
        
    }
}