
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
    public class GetShipCooldownRequest
    {

        /// <summary>
        /// The symbol of the ship.
        /// </summary>
        [SerializeField]
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=shipSymbol")]
        public string ShipSymbol { get; set; } = default!;
        
    }
}