
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
    /// Successfully scanned for nearby ships.
    /// </summary>
    [Serializable]
    public class CreateShipShipScanResponseBody
    {

        [SerializeField]
        [JsonProperty("data")]
        public CreateShipShipScanData Data { get; set; } = default!;
        
    }
}