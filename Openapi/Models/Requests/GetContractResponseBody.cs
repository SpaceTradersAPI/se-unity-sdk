
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
    /// Successfully fetched contract.
    /// </summary>
    [Serializable]
    public class GetContractResponseBody
    {

        /// <summary>
        /// Contract details.
        /// </summary>
        [SerializeField]
        [JsonProperty("data")]
        public ContractJson Data { get; set; } = default!;
        
    }
}