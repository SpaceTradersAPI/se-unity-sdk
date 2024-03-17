
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
    
    /// <summary>
    /// The successful transit information including the route details and changes to ship fuel. The route includes the expected time of arrival.
    /// </summary>
    [Serializable]
    public class WarpShipResponseBody
    {

        [SerializeField]
        [JsonProperty("data")]
        public WarpShipData Data { get; set; } = default!;
        
    }
}