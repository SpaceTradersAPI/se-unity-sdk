
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
    using System.Collections.Generic;
    using System;
    using UnityEngine;
    
    /// <summary>
    /// Succesfully fetched factions.
    /// </summary>
    [Serializable]
    public class GetFactionsResponseBody
    {

        [SerializeField]
        [JsonProperty("data")]
        public List<FactionJson> Data { get; set; } = default!;
        

        /// <summary>
        /// Meta details for pagination.
        /// </summary>
        [SerializeField]
        [JsonProperty("meta")]
        public MetaJson Meta { get; set; } = default!;
        
    }
}