using System;
using System.Collections.Generic;
using RestSharp;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBlacklistApi
    {
        /// <summary>
        ///  Добавить запись в черный список
        /// </summary>
        /// <param name="action">Тип действия</param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20030</returns>
        InlineResponse20030 ContentMute (string action, long? id);
        /// <summary>
        ///  Добавить хэштег в черный список
        /// </summary>
        /// <param name="action">Тип действия</param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20030</returns>
        InlineResponse20030 HashtagMute (string action, long? id);
        /// <summary>
        ///  Добавить подсайт в черный список
        /// </summary>
        /// <param name="action">Тип действия</param>
        /// <param name="id"></param>
        /// <returns>InlineResponse20030</returns>
        InlineResponse20030 SubsitegMute (string action, long? id);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class BlacklistApi : IBlacklistApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlacklistApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public BlacklistApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BlacklistApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BlacklistApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        ///  Добавить запись в черный список
        /// </summary>
        /// <param name="action">Тип действия</param> 
        /// <param name="id"></param> 
        /// <returns>InlineResponse20030</returns>            
        public InlineResponse20030 ContentMute (string action, long? id)
        {
            
    
            var path = "/content/mute";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (action != null) formParams.Add("action", ApiClient.ParameterToString(action)); // form parameter
if (id != null) formParams.Add("id", ApiClient.ParameterToString(id)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] { "XDeviceToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ContentMute: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ContentMute: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20030) ApiClient.Deserialize(response.Content, typeof(InlineResponse20030), response.Headers);
        }
    
        /// <summary>
        ///  Добавить хэштег в черный список
        /// </summary>
        /// <param name="action">Тип действия</param> 
        /// <param name="id"></param> 
        /// <returns>InlineResponse20030</returns>            
        public InlineResponse20030 HashtagMute (string action, long? id)
        {
            
    
            var path = "/hashtag/mute";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (action != null) formParams.Add("action", ApiClient.ParameterToString(action)); // form parameter
if (id != null) formParams.Add("id", ApiClient.ParameterToString(id)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] { "XDeviceToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling HashtagMute: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HashtagMute: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20030) ApiClient.Deserialize(response.Content, typeof(InlineResponse20030), response.Headers);
        }
    
        /// <summary>
        ///  Добавить подсайт в черный список
        /// </summary>
        /// <param name="action">Тип действия</param> 
        /// <param name="id"></param> 
        /// <returns>InlineResponse20030</returns>            
        public InlineResponse20030 SubsitegMute (string action, long? id)
        {
            
    
            var path = "/subsite/mute";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (action != null) formParams.Add("action", ApiClient.ParameterToString(action)); // form parameter
if (id != null) formParams.Add("id", ApiClient.ParameterToString(id)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] { "XDeviceToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SubsitegMute: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SubsitegMute: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20030) ApiClient.Deserialize(response.Content, typeof(InlineResponse20030), response.Headers);
        }
    
    }
}
