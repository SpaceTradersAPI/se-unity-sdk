
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
    
    /// <summary>
    /// Successfully fetched the shipyard.
    /// </summary>
    [Serializable]
    public class GetShipyardResponseBody
    {

        [SerializeField]
        [JsonProperty("data")]
        public ShipyardJson Data { get; set; } = default!;
        
    }
}