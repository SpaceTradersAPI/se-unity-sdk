
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
    using Openapi.Models.Components;
    using System.Collections.Generic;
    using System;
    using UnityEngine;
    
    [Serializable]
    public class CreateSurveyData
    {

        /// <summary>
        /// A cooldown is a period of time in which a ship cannot perform certain actions.
        /// </summary>
        [SerializeField]
        [JsonProperty("cooldown")]
        public CooldownJson Cooldown { get; set; } = default!;
        

        /// <summary>
        /// Surveys created by this action.
        /// </summary>
        [SerializeField]
        [JsonProperty("surveys")]
        public List<SurveyJson> Surveys { get; set; } = default!;
        
    }
}