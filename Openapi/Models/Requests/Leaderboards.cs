
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
    using System.Collections.Generic;
    using System;
    using UnityEngine;
    
    [Serializable]
    public class Leaderboards
    {

        /// <summary>
        /// Top agents with the most credits.
        /// </summary>
        [SerializeField]
        [JsonProperty("mostCredits")]
        public List<MostCredits> MostCredits { get; set; } = default!;
        

        /// <summary>
        /// Top agents with the most charted submitted.
        /// </summary>
        [SerializeField]
        [JsonProperty("mostSubmittedCharts")]
        public List<MostSubmittedCharts> MostSubmittedCharts { get; set; } = default!;
        
    }
}