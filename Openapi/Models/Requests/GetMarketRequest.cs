
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
    public class GetMarketRequest
    {

        /// <summary>
        /// The system symbol
        /// </summary>
        [SerializeField]
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=systemSymbol")]
        public string SystemSymbol { get; set; } = default!;
        

        /// <summary>
        /// The waypoint symbol
        /// </summary>
        [SerializeField]
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=waypointSymbol")]
        public string WaypointSymbol { get; set; } = default!;
        
    }
}