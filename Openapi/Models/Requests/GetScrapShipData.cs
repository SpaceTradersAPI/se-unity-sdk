
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
    public class GetScrapShipData
    {

        /// <summary>
        /// Result of a scrap transaction.
        /// </summary>
        [SerializeField]
        [JsonProperty("transaction")]
        public ScrapTransactionJson Transaction { get; set; } = default!;
        
    }
}