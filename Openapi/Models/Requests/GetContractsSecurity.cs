
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
    public class GetContractsSecurity
    {

        [SerializeField]
        [SpeakeasyMetadata("security:scheme=true,type=http,subType=bearer,name=Authorization")]
        public string AgentToken { get; set; } = default!;
        
    }
}