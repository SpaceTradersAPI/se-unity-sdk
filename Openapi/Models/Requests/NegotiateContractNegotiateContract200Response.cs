
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
    /// Successfully negotiated a new contract.
    /// </summary>
    [Serializable]
    public class NegotiateContractNegotiateContract200Response
    {

        [SerializeField]
        [JsonProperty("data")]
        public NegotiateContractData Data { get; set; } = default!;
        
    }
}