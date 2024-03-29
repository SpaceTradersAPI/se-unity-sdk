
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Openapi.Models.Components
{
    using Newtonsoft.Json;
    using System;
    using UnityEngine;
    
    /// <summary>
    /// Contract details.
    /// </summary>
    [Serializable]
    public class ContractJson
    {

        /// <summary>
        /// ID of the contract.
        /// </summary>
        [SerializeField]
        [JsonProperty("id")]
        public string Id { get; set; } = default!;
        

        /// <summary>
        /// The symbol of the faction that this contract is for.
        /// </summary>
        [SerializeField]
        [JsonProperty("factionSymbol")]
        public string FactionSymbol { get; set; } = default!;
        

        /// <summary>
        /// Type of contract.
        /// </summary>
        [SerializeField]
        [JsonProperty("type")]
        public Type Type { get; set; } = default!;
        

        /// <summary>
        /// The terms to fulfill the contract.
        /// </summary>
        [SerializeField]
        [JsonProperty("terms")]
        public ContractTermsJson Terms { get; set; } = default!;
        

        /// <summary>
        /// Whether the contract has been accepted by the agent
        /// </summary>
        [SerializeField]
        [JsonProperty("accepted")]
        public bool Accepted { get; set; } = default!;
        

        /// <summary>
        /// Whether the contract has been fulfilled
        /// </summary>
        [SerializeField]
        [JsonProperty("fulfilled")]
        public bool Fulfilled { get; set; } = default!;
        

        /// <summary>
        /// Deprecated in favor of deadlineToAccept
        /// </summary>
        [Obsolete("This field will be removed in a future release, please migrate away from it as soon as possible")]
        [SerializeField]
        [JsonProperty("expiration")]
        public DateTime Expiration { get; set; } = default!;
        

        /// <summary>
        /// The time at which the contract is no longer available to be accepted
        /// </summary>
        [SerializeField]
        [JsonProperty("deadlineToAccept")]
        public DateTime? DeadlineToAccept { get; set; }
        
    }
}