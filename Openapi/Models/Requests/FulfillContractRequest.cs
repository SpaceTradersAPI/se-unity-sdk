
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
    using Openapi.Utils;
    using System;
    using UnityEngine;
    
    [Serializable]
    public class FulfillContractRequest
    {

        /// <summary>
        /// The ID of the contract to fulfill.
        /// </summary>
        [SerializeField]
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=contractId")]
        public string ContractId { get; set; } = default!;
        
    }
}