
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Openapi
{
    using Newtonsoft.Json;
    using Openapi.Models.Components;
    using Openapi.Models.Requests;
    using Openapi.Utils;
    using System.Threading.Tasks;
    using System;
    using UnityEngine.Networking;

    /// <summary>
    /// Factions
    /// </summary>
    public interface IFactions
    {

        /// <summary>
        /// List Factions
        /// 
        /// <remarks>
        /// Return a paginated list of all the factions in the game.
        /// </remarks>
        /// </summary>
        Task<GetFactionsResponse> GetFactionsAsync(long? page = null, long? limit = null);

        /// <summary>
        /// Get Faction
        /// 
        /// <remarks>
        /// View the details of a faction.
        /// </remarks>
        /// </summary>
        Task<GetFactionResponse> GetFactionAsync(string factionSymbol);
    }

    /// <summary>
    /// Factions
    /// </summary>
    public class Factions: IFactions
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _target = "unity";
        private const string _sdkVersion = "0.0.1";
        private const string _sdkGenVersion = "2.281.2";
        private const string _openapiDocVersion = "2.0.0";
        private const string _userAgent = "speakeasy-sdk/unity 0.0.1 2.281.2 2.0.0 openapi";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _defaultClient;
        private Func<Security>? _securitySource;

        public Factions(ISpeakeasyHttpClient defaultClient, Func<Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _defaultClient = defaultClient;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }
        

        
        public async Task<GetFactionsResponse> GetFactionsAsync(long? page = null, long? limit = null)
        {
            var request = new GetFactionsRequest()
            {
                Page = page,
                Limit = limit,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/factions", request);

            var httpRequest = new UnityWebRequest(urlString, UnityWebRequest.kHttpVerbGET);
            DownloadHandlerStream downloadHandler = new DownloadHandlerStream();
            httpRequest.downloadHandler = downloadHandler;
            httpRequest.SetRequestHeader("user-agent", _userAgent);

            var client = _defaultClient;

            var httpResponse = await client.SendAsync(httpRequest);
            switch (httpResponse.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                case UnityWebRequest.Result.ProtocolError:
                    var errorMsg = httpResponse.error;
                    httpRequest.Dispose();
                    throw new Exception(errorMsg);
            }

            var contentType = httpResponse.GetResponseHeader("Content-Type");

            var response = new GetFactionsResponse
            {
                StatusCode = (int)httpResponse.responseCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Object = JsonConvert.DeserializeObject<GetFactionsResponseBody>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new DateOnlyConverter(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        

        
        public async Task<GetFactionResponse> GetFactionAsync(string factionSymbol)
        {
            var request = new GetFactionRequest()
            {
                FactionSymbol = factionSymbol,
            };
            string baseUrl = this.SDKConfiguration.GetTemplatedServerDetails();
            var urlString = URLBuilder.Build(baseUrl, "/factions/{factionSymbol}", request);

            var httpRequest = new UnityWebRequest(urlString, UnityWebRequest.kHttpVerbGET);
            DownloadHandlerStream downloadHandler = new DownloadHandlerStream();
            httpRequest.downloadHandler = downloadHandler;
            httpRequest.SetRequestHeader("user-agent", _userAgent);

            var client = _defaultClient;
            if (_securitySource != null)
            {
                client = SecuritySerializer.Apply(_defaultClient, _securitySource);
            }

            var httpResponse = await client.SendAsync(httpRequest);
            switch (httpResponse.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                case UnityWebRequest.Result.ProtocolError:
                    var errorMsg = httpResponse.error;
                    httpRequest.Dispose();
                    throw new Exception(errorMsg);
            }

            var contentType = httpResponse.GetResponseHeader("Content-Type");

            var response = new GetFactionResponse
            {
                StatusCode = (int)httpResponse.responseCode,
                ContentType = contentType,
                RawResponse = httpResponse
            };

            if((response.StatusCode == 200))
            {
                if(Utilities.IsContentTypeMatch("application/json",response.ContentType))
                {
                    response.Object = JsonConvert.DeserializeObject<GetFactionResponseBody>(httpResponse.downloadHandler.text, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new FlexibleObjectDeserializer(), new DateOnlyConverter(), new EnumSerializer() }});
                }

                return response;
            }
            return response;
        }

        
    }
}