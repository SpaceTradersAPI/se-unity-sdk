
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
    /// Successfully fulfilled a contract.
    /// </summary>
    [Serializable]
    public class FulfillContractResponseBody
    {

        [SerializeField]
        [JsonProperty("data")]
        public FulfillContractData Data { get; set; } = default!;
        
    }
}