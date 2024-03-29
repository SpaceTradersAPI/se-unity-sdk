
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
    
    [Serializable]
    public class ServerResets
    {

        /// <summary>
        /// The date and time when the game server will reset.
        /// </summary>
        [SerializeField]
        [JsonProperty("next")]
        public string Next { get; set; } = default!;
        

        /// <summary>
        /// How often we intend to reset the game server.
        /// </summary>
        [SerializeField]
        [JsonProperty("frequency")]
        public string Frequency { get; set; } = default!;
        
    }
}