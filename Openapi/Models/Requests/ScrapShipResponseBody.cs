
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
    /// Ship scrapped successfully.
    /// </summary>
    [Serializable]
    public class ScrapShipResponseBody
    {

        [SerializeField]
        [JsonProperty("data")]
        public ScrapShipData Data { get; set; } = default!;
        
    }
}