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
    public interface IPushApi
    {
        /// <summary>
        ///  Получить настройки пушей для текущего пользователя
        /// </summary>
        /// <returns>InlineResponse20020</returns>
        InlineResponse20020 GetUserPushSettings ();
        /// <summary>
        ///  Получить topic для текущего пользователя, чтобы подписаться на пуши
        /// </summary>
        /// <returns>InlineResponse20019</returns>
        InlineResponse20019 GetUserPushTopic ();
        /// <summary>
        ///  Отправить на сервер настройки пушей для текущего пользователя
        /// </summary>
        /// <param name="settings">Битовая маска настроек</param>
        /// <returns>InlineResponse2008</returns>
        InlineResponse2008 UpdateUserPushSettings (long? settings);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PushApi : IPushApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PushApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PushApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PushApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PushApi(String basePath)
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
        ///  Получить настройки пушей для текущего пользователя
        /// </summary>
        /// <returns>InlineResponse20020</returns>            
        public InlineResponse20020 GetUserPushSettings ()
        {
            
    
            var path = "/user/push/settings/get";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "XDeviceToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserPushSettings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserPushSettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20020) ApiClient.Deserialize(response.Content, typeof(InlineResponse20020), response.Headers);
        }
    
        /// <summary>
        ///  Получить topic для текущего пользователя, чтобы подписаться на пуши
        /// </summary>
        /// <returns>InlineResponse20019</returns>            
        public InlineResponse20019 GetUserPushTopic ()
        {
            
    
            var path = "/user/push/topic";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "XDeviceToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserPushTopic: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUserPushTopic: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20019) ApiClient.Deserialize(response.Content, typeof(InlineResponse20019), response.Headers);
        }
    
        /// <summary>
        ///  Отправить на сервер настройки пушей для текущего пользователя
        /// </summary>
        /// <param name="settings">Битовая маска настроек</param> 
        /// <returns>InlineResponse2008</returns>            
        public InlineResponse2008 UpdateUserPushSettings (long? settings)
        {
            
    
            var path = "/user/push/settings/update";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    if (settings != null) formParams.Add("settings", ApiClient.ParameterToString(settings)); // form parameter
                
            // authentication setting, if any
            String[] authSettings = new String[] { "XDeviceToken" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUserPushSettings: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling UpdateUserPushSettings: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2008) ApiClient.Deserialize(response.Content, typeof(InlineResponse2008), response.Headers);
        }
    
    }
}
