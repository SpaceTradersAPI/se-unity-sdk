
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
    /// Succesfully accepted contract.
    /// </summary>
    [Serializable]
    public class AcceptContractResponseBody
    {

        [SerializeField]
        [JsonProperty("data")]
        public AcceptContractData Data { get; set; } = default!;
        
    }
}