
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
    using Openapi.Models.Components;
    using Openapi.Utils;
    using System;
    using UnityEngine;
    
    [Serializable]
    public class GetSystemWaypointsRequest
    {

        /// <summary>
        /// The system symbol
        /// </summary>
        [SerializeField]
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=systemSymbol")]
        public string SystemSymbol { get; set; } = default!;
        

        /// <summary>
        /// What entry offset to request
        /// </summary>
        [SerializeField]
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=page")]
        public long? Page { get; set; }
        

        /// <summary>
        /// How many entries to return per page
        /// </summary>
        [SerializeField]
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=limit")]
        public long? Limit { get; set; }
        

        /// <summary>
        /// Filter waypoints by type.
        /// </summary>
        [SerializeField]
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=type")]
        public WaypointTypeJson? Type { get; set; }
        

        /// <summary>
        /// Filter waypoints by one or more traits.
        /// </summary>
        [SerializeField]
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=traits")]
        public object? Traits { get; set; }
        
    }
}