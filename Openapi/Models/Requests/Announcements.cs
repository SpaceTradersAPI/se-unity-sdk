
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
    public class Announcements
    {

        [SerializeField]
        [JsonProperty("title")]
        public string Title { get; set; } = default!;
        

        [SerializeField]
        [JsonProperty("body")]
        public string Body { get; set; } = default!;
        
    }
}